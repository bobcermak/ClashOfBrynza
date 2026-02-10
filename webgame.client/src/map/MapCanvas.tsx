import { type FC, useRef, useState, useLayoutEffect, useMemo } from "react";
import { Tile, Building as BuildingComponent, SpriteAnimation, DestructionEffect } from "../components";
import { Stage, Layer } from "react-konva";
import type { Map, Building, MapBuilding } from "../../types/mapModels";
import { useArmyLogic } from "../hooks/useArmyLogic";
import { useMapDecorations } from "../hooks/useMapDecorations";
import { useMapStage } from "../hooks/useMapStage";
import { useSheep } from "../hooks/useSheep";

type MapCanvasProps = {
  groundMap: Map;
  buildingsMap: Map;
  tileSize?: number;
  placingBuilding?: Building | null;
  onMapClick?: (x: number, y: number) => void;
  onBuildingClick?: (building: MapBuilding) => void;
  inStarvation: boolean;
};
const MapCanvas: FC<MapCanvasProps> = ({ groundMap, buildingsMap, onMapClick, tileSize = 64, placingBuilding = null, onBuildingClick, inStarvation }) => {
  // Hooks
  const { stageRef, containerRef, stageSize, hoverPosition, handleWheel, handleMouseMove, handleStageClick } = useMapStage(tileSize, placingBuilding, onMapClick, groundMap);
  const { decorations, foamPositions } = useMapDecorations(groundMap, buildingsMap, tileSize);
  const { armyGroups } = useArmyLogic(buildingsMap, groundMap, tileSize);
  const { sheepList } = useSheep(groundMap, buildingsMap, tileSize, inStarvation);
  const rocks: { id: number; src: string; x: number; y: number }[] = [
    { id: 1, src: "/images/sprite-animations/rock-1.png", x: 1300, y: 1350 },
    { id: 2, src: "/images/sprite-animations/rock-1.png", x: 2000, y: 1475 },
    { id: 3, src: "/images/sprite-animations/rock-2.png", x: 2100, y: 1200 },
  ];
  const prevBuildingsRef = useRef<MapBuilding[]>(buildingsMap.buildings);
  const [explosions, setExplosions] = useState<{ id: string; building: MapBuilding }[]>([]);

  useLayoutEffect(() => {
    const prevBuildings = prevBuildingsRef.current;
    const currentBuildings = buildingsMap.buildings;
    const removed = prevBuildings.filter((pb) => !currentBuildings.find((cb) => cb.buildingId === pb.buildingId && cb.bottomLeftX === pb.bottomLeftX && cb.bottomLeftY === pb.bottomLeftY));
    if (removed.length > 0) {
      const newExplosions = removed.map((b) => ({
        id: `expl-${b.mapId}-${Date.now()}-${Math.random().toString(36).substr(2, 9)}`,
        building: b,
      }));
      setExplosions((prev) => {
        const existingIds = new Set(prev.map((e) => e.id));
        const uniqueNew = newExplosions.filter((e) => !existingIds.has(e.id));
        return [...prev, ...uniqueNew];
      });
    }
    prevBuildingsRef.current = currentBuildings;
  }, [buildingsMap]);
  const removeExplosion = (id: string) => {
    setExplosions((prev) => prev.filter((e) => e.id !== id));
  };
  const renderables = useMemo(() => {
    type Renderable = {
      id: string;
      sortY: number;
      node: React.ReactNode;
    };
    const list: Renderable[] = [];
    decorations.forEach((deco: { config: { frameHeight: number; rows: number; src: string; frameWidth: number; columns: number; frameRate: number }; pixelY: number; pixelX: number }, i: number) => {
      const height = deco.config.frameHeight / deco.config.rows;
      list.push({
        id: `deco-${i}`,
        sortY: deco.pixelY + height,
        node: (
          <SpriteAnimation
            key={`deco-${i}`}
            src={deco.config.src}
            frameWidth={deco.config.frameWidth}
            frameHeight={deco.config.frameHeight}
            columns={deco.config.columns}
            rows={deco.config.rows}
            frameRate={deco.config.frameRate}
            loop={true}
            autoplay={true}
            x={deco.pixelX}
            y={deco.pixelY}
            listening={false}
          />
        ),
      });
    });
    armyGroups.forEach((group, groupIdx) => {
      group.forEach((sprite, i) => {
        const height = sprite.frameHeight / sprite.rows;
        const unitTileY = Math.floor((sprite.y + height / 2) / tileSize);
        list.push({
          id: `army-${groupIdx}-${i}`,
          sortY: (unitTileY + 1) * tileSize - 1,
          node: (
            <SpriteAnimation
              key={`army-${groupIdx}-${i}`}
              src={sprite.src}
              frameWidth={sprite.frameWidth}
              frameHeight={sprite.frameHeight}
              columns={sprite.columns}
              rows={sprite.rows}
              frameRate={sprite.frameRate}
              loop={sprite.loop}
              autoplay={sprite.autoplay}
              x={sprite.x}
              y={sprite.y}
              delay={sprite.delay}
              listening={false}
            />
          ),
        });
      });
    });
    sheepList.forEach((sheep) => {
      if (sheep.opacity <= 0) return;
      list.push({
        id: sheep.id,
        sortY: sheep.sortY,
        node: (
          <SpriteAnimation
            key={sheep.id}
            src="/images/sprite-animations/sheep.png"
            frameWidth={128}
            frameHeight={128}
            columns={12}
            rows={1}
            frameRate={8}
            loop={true}
            autoplay={true}
            x={sheep.pixelX}
            y={sheep.pixelY}
            opacity={sheep.opacity}
            listening={false}
          />
        ),
      });
    });
    rocks.forEach((rock) => {
      const width = 128;
      const height = 128;
      const spriteMinX = Math.floor(rock.x / tileSize);
      const spriteMaxX = Math.floor((rock.x + width - 1) / tileSize);
      const spriteMinY = Math.floor(rock.y / tileSize);
      const spriteMaxY = Math.floor((rock.y + height - 1) / tileSize);
      const isColliding = buildingsMap.buildings.some((b) => {
        const buildingMinX = b.bottomLeftX;
        const buildingMaxX = b.bottomLeftX + b.building.baseWidth - 1;
        const buildingMaxY = b.bottomLeftY;
        const buildingMinY = b.bottomLeftY - b.building.baseHeight + 1;
        const noOverlap = spriteMinX > buildingMaxX || spriteMaxX < buildingMinX || spriteMinY > buildingMaxY || spriteMaxY < buildingMinY;
        return !noOverlap;
      });
      if (!isColliding) {
        list.push({
          id: `rock-${rock.id}`,
          sortY: rock.y + height,
          node: (
            <SpriteAnimation
              key={`rock-${rock.id}`}
              src={rock.src}
              frameWidth={width}
              frameHeight={height}
              columns={8}
              rows={1}
              frameRate={8}
              loop={true}
              autoplay={true}
              x={rock.x}
              y={rock.y}
              listening={false}
            />
          ),
        });
      }
    });
    buildingsMap.buildings.forEach((building) => {
      const uniqueId = `building-${building.mapId}-${building.bottomLeftX}-${building.bottomLeftY}`;
      list.push({
        id: uniqueId,
        sortY: (building.bottomLeftY + 1) * tileSize,
        node: <BuildingComponent transparentOnHover={!!placingBuilding} key={uniqueId} building={building} tileSize={tileSize} onClick={onBuildingClick} />,
      });
    });
    explosions.forEach((expl) => {
      list.push({
        id: expl.id,
        sortY: (expl.building.bottomLeftY + 1) * tileSize + 100000,
        node: <DestructionEffect key={expl.id} building={expl.building} tileSize={tileSize} onComplete={() => removeExplosion(expl.id)} />,
      });
    });
    list.sort((a, b) => a.sortY - b.sortY);
    return list.map((r) => r.node);
  }, [decorations, armyGroups, rocks, buildingsMap.buildings, explosions, tileSize, placingBuilding, onBuildingClick, sheepList]);
  return (
    <div ref={containerRef} style={{ width: "100svw", height: "100svh", overflow: "hidden" }}>
      <Stage ref={stageRef} width={stageSize.width} height={stageSize.height} draggable onWheel={handleWheel} onMouseMove={handleMouseMove} onClick={handleStageClick}>
        <Layer>
          {useMemo(
            () =>
              foamPositions.map((foam) => (
                <SpriteAnimation
                  key={foam.id}
                  src="/images/sprite-animations/water-foam.png"
                  frameWidth={192}
                  frameHeight={192}
                  columns={16}
                  rows={1}
                  frameRate={8}
                  loop={true}
                  autoplay={true}
                  x={foam.pixelX}
                  y={foam.pixelY}
                  listening={false}
                />
              )),
            [foamPositions],
          )}
          {useMemo(() => groundMap.tiles.map((tile) => <Tile key={`tile-${tile.mapTileId}-${tile.x}-${tile.y}`} tile={tile} tileSize={tileSize} />), [groundMap.tiles, tileSize])}
          {renderables}
          {placingBuilding && hoverPosition && (
            <>
              <BuildingComponent
                building={
                  {
                    building: placingBuilding,
                    buildingId: -1,
                    mapId: -1,
                    bottomLeftX: hoverPosition.x,
                    bottomLeftY: hoverPosition.y,
                  } as MapBuilding
                }
                tileSize={tileSize}
                transparentOnHover={false}
                opacity={0.7}
                listening={false}
              />
            </>
          )}
        </Layer>
      </Stage>
    </div>
  );
};
export default MapCanvas;