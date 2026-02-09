import { useMemo } from "react";
import type { Map } from "../../types/mapModels";
import { getDecorationsForMap } from "../../lib/helpers/mapDecorations";

export const useMapDecorations = (groundMap: Map, buildingsMap: Map, tileSize: number) => {
    const decorations = useMemo(() => {
        return getDecorationsForMap(groundMap, buildingsMap, tileSize);
    }, [groundMap, buildingsMap, tileSize]);
    const foamPositions = useMemo(() => {
        const tileSet = new Set<number>();
        groundMap.tiles.forEach(t => {
            tileSet.add((t.y & 0xFFFF) << 16 | (t.x & 0xFFFF));
        });
        const foam: { id: string; pixelX: number; pixelY: number; sortY: number }[] = [];
        let foamIndex = 0;
        groundMap.tiles.forEach((tile) => {
            const up = (tile.y - 1) & 0xFFFF;
            const down = (tile.y + 1) & 0xFFFF;
            const left = (tile.x - 1) & 0xFFFF;
            const right = (tile.x + 1) & 0xFFFF;
            const y = tile.y & 0xFFFF;
            const x = tile.x & 0xFFFF;
            const hasWest = tileSet.has((y << 16) | left);
            const hasEast = tileSet.has((y << 16) | right);
            const hasNorth = tileSet.has((up << 16) | x);
            const hasSouth = tileSet.has((down << 16) | x);
            const isCoastal = !hasWest || !hasEast || !hasNorth || !hasSouth;
            if (isCoastal) {
                const foamX = tile.x * tileSize;
                const foamY = tile.y * tileSize;
                let offsetX = 0;
                let offsetY = 0;
                const shift = 7.5;
                if (!hasWest) offsetX -= shift;
                if (!hasEast) offsetX += shift;
                if (!hasNorth) offsetY -= shift;
                if (!hasSouth) offsetY += shift;
                foam.push({
                    id: `foam-${foamIndex++}`,
                    pixelX: foamX + tileSize / 2 - 192 / 2 - offsetX,
                    pixelY: foamY + tileSize / 2 - 192 / 2 - offsetY,
                    sortY: (tile.y + 1) * tileSize - 1,
                });
            }
        });
        return foam;
    }, [groundMap, tileSize]);
    return { decorations, foamPositions };
};