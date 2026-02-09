import { useState, useRef, useLayoutEffect } from "react";
import Konva from "konva";
import type { Building, Map } from "../../types/mapModels";

export const useMapStage = (
    tileSize: number,
    placingBuilding: Building | null,
    onMapClick: ((x: number, y: number) => void) | undefined,
    groundMap: Map
) => {
    //Hooks
    const stageRef = useRef<Konva.Stage>(null);
    const containerRef = useRef<HTMLDivElement>(null);
    const [stageSize, setStageSize] = useState<{ width: number; height: number }>({ width: 0, height: 0 });
    const [hoverPosition, setHoverPosition] = useState<{ x: number; y: number } | null>(null);

    useLayoutEffect(() => {
        const handleResize = () => {
            if (containerRef.current) {
                const width = containerRef.current.offsetWidth;
                const height = containerRef.current.offsetHeight;
                setStageSize({ width, height });
                if (stageRef.current && groundMap.tiles.length > 0) {
                    const maxX = Math.max(...groundMap.tiles.map(t => t.x));
                    const maxY = Math.max(...groundMap.tiles.map(t => t.y));
                    const mapWidth = (maxX + 1) * tileSize;
                    const mapHeight = (maxY + 1) * tileSize;
                    const scaleX = width / mapWidth;
                    const scaleY = height / mapHeight;
                    const scale = Math.min(scaleX, scaleY) * 0.75;
                    const rescaledMapWidth = mapWidth * scale;
                    const rescaledMapHeight = mapHeight * scale;
                    const x = (width - rescaledMapWidth) / 2;
                    const y = (height - rescaledMapHeight) / 2;
                    stageRef.current.width(width);
                    stageRef.current.height(height);
                    stageRef.current.scale({ x: scale, y: scale });
                    stageRef.current.position({ x, y });
                }
            }
        };
        window.addEventListener("resize", handleResize);
        handleResize();
        return () => window.removeEventListener("resize", handleResize);
    }, [groundMap, tileSize]);
    const scaleBy = 1.1;
    const handleWheel = (e: Konva.KonvaEventObject<WheelEvent>) => {
        e.evt.preventDefault();
        const stage = stageRef.current;
        if (!stage) return;
        const oldScale = stage.scaleX();
        const pointer = stage.getPointerPosition();
        if (!pointer) return;
        const mousePointTo = {
            x: (pointer.x - stage.x()) / oldScale,
            y: (pointer.y - stage.y()) / oldScale,
        };
        const direction = e.evt.deltaY > 0 ? -1 : 1;
        const newScale = direction > 0 ? oldScale * scaleBy : oldScale / scaleBy;
        const limitedScale = Math.max(0.1, Math.min(newScale, 5));
        stage.scale({ x: limitedScale, y: limitedScale });
        const newPos = {
            x: pointer.x - mousePointTo.x * limitedScale,
            y: pointer.y - mousePointTo.y * limitedScale,
        };
        stage.position(newPos);
    };
    const handleMouseMove = () => {
        if (!placingBuilding) {
            if (hoverPosition) setHoverPosition(null);
            return;
        }
        const stage = stageRef.current;
        if (!stage) return;
        const pointerPosition = stage.getPointerPosition();
        if (!pointerPosition) return;
        const scale = stage.scaleX();
        const x = Math.floor((pointerPosition.x - stage.x()) / scale / tileSize);
        const y = Math.floor((pointerPosition.y - stage.y()) / scale / tileSize);
        setHoverPosition({ x, y });
    };
    const handleStageClick = () => {
        if (!onMapClick) return;
        const stage = stageRef.current;
        if (!stage) return;
        const pointerPosition = stage.getPointerPosition();
        if (!pointerPosition) return;
        const scale = stage.scaleX();
        const x = Math.floor((pointerPosition.x - stage.x()) / scale / tileSize);
        const y = Math.floor((pointerPosition.y - stage.y()) / scale / tileSize);
        onMapClick(x, y);
    };
    return {
        stageRef,
        containerRef,
        stageSize,
        hoverPosition,
        handleWheel,
        handleMouseMove,
        handleStageClick
    };
};