import useImage from "use-image";
import type { MapTile } from "../../../types/mapModels";
import { Image, Text } from "react-konva";
import { useDebugMode } from "../../hooks/useDebugMode";
import React from "react";

type TileProps = {
  tile: MapTile;
  tileSize: number;
};
const TileComponent: React.FC<TileProps> = ({ tile, tileSize }) => {
  const [tileImage] = useImage(tile.tile.imageUrl);
  const { debugMode } = useDebugMode();

  return (
    <>
      <Image x={tile.x * tileSize} y={tile.y * tileSize} width={tileSize + 0.5} height={tileSize + 0.5} image={tileImage} />
      {debugMode && (
        <Text
          text={`x: ${tile.x}\ny: ${tile.y}\n${tile.tile.isPlaceable}`}
          fontSize={12}
          x={tile.x * tileSize}
          y={tile.y * tileSize}
          fill="white"
          shadowColor="black"
          shadowBlur={2}
          padding={5}
          width={tileSize}
          align="center"
          verticalAlign="middle"
          height={tileSize}
          listening={false}
        />
      )}
    </>
  );
};
export default React.memo(TileComponent);