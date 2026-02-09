import { useEffect, useState, useRef } from "react";
import type { Map } from "../../types/mapModels";

type Sheep = {
    id: string;
    pixelX: number;
    pixelY: number;
    tileX: number;
    tileY: number;
    opacity: number;
    targetOpacity: number;
    sortY: number;
};
export const useSheep = (groundMap: Map, buildingsMap: Map, tileSize: number, inStarvation: boolean) => {
    //Hooks
    const [sheepList, setSheepList] = useState<Sheep[]>([]);
    const initialized = useRef(false);

    useEffect(() => {
        if (initialized.current) return;
        if (!groundMap || !groundMap.tiles) return;
        const generatedSheep: Sheep[] = [];
        let sheepIndex = 0;
        let minX = Infinity, maxX = -Infinity, minY = Infinity, maxY = -Infinity;
        groundMap.tiles.forEach(t => {
            if (t.x < minX) minX = t.x;
            if (t.x > maxX) maxX = t.x;
            if (t.y < minY) minY = t.y;
            if (t.y > maxY) maxY = t.y;
        });
        const occupiedObj: { [key: string]: boolean } = {};
        buildingsMap.buildings.forEach(b => {
            for (let x = 0; x < b.building.baseWidth; x++) {
                for (let y = 0; y < b.building.baseHeight; y++) {
                    occupiedObj[`${b.bottomLeftX + x},${b.bottomLeftY - y}`] = true;
                }
            }
        });
        const allTileKeys = new Set<string>();
        groundMap.tiles.forEach(t => allTileKeys.add(`${t.x},${t.y}`));
        groundMap.tiles.forEach(tile => {
            if (tile.x <= minX + 1 || tile.x >= maxX - 1 || tile.y <= minY + 1 || tile.y >= maxY - 1) return;
            let safeY = true;
            for (let dy = -4; dy <= 4; dy++) {
                if (dy === 0) continue;
                if (!allTileKeys.has(`${tile.x},${tile.y + dy}`)) {
                    safeY = false;
                    break;
                }
            }
            if (!safeY) return;
            if (tile.tile.isPlaceable && !occupiedObj[`${tile.x},${tile.y}`]) {
                if (Math.random() < 0.0275) {
                    generatedSheep.push({
                        id: `sheep-${sheepIndex++}`,
                        tileX: tile.x,
                        tileY: tile.y,
                        pixelX: tile.x * tileSize - 37,
                        pixelY: tile.y * tileSize - 74,
                        sortY: (tile.y + 1) * tileSize,
                        opacity: 1,
                        targetOpacity: 1
                    });
                }
            }
        });
        setSheepList(generatedSheep);
        initialized.current = true;
    }, [groundMap, tileSize]);
    useEffect(() => {
        const interval = setInterval(() => {
            setSheepList(prev => prev.map(sheep => {
                if (inStarvation) {
                    if (sheep.targetOpacity === 0) return sheep;
                    if (Math.random() < 0.05) return { ...sheep, targetOpacity: 0 };
                    return sheep;
                } else {
                    if (sheep.targetOpacity === 1) return sheep;
                    if (Math.random() < 0.02) return { ...sheep, targetOpacity: 1 };
                    return sheep;
                }
            }));
        }, 500);
        return () => clearInterval(interval);
    }, [inStarvation]);
    useEffect(() => {
        let animationFrameId: number;
        const animate = () => {
            setSheepList(prev => {
                let hasChanges = false;
                const next = prev.map(sheep => {
                    if (Math.abs(sheep.opacity - sheep.targetOpacity) < 0.01) {
                        if (sheep.opacity !== sheep.targetOpacity) return { ...sheep, opacity: sheep.targetOpacity };
                        return sheep;
                    }
                    hasChanges = true;
                    const diff = sheep.targetOpacity - sheep.opacity;
                    const speed = 0.01;
                    return { ...sheep, opacity: sheep.opacity + (diff > 0 ? speed : -speed) };
                });
                return hasChanges ? next : prev;
            });
            animationFrameId = requestAnimationFrame(animate);
        };
        animate();
        return () => cancelAnimationFrame(animationFrameId);
    }, []);
    useEffect(() => {
        setSheepList(prev => {
            const occupiedSet = new Set<string>();
            buildingsMap.buildings.forEach(b => {
                for (let x = 0; x < b.building.baseWidth; x++) {
                    for (let y = 0; y < b.building.baseHeight; y++) {
                        occupiedSet.add(`${b.bottomLeftX + x},${b.bottomLeftY - y}`);
                    }
                }
            });
            return prev.map(sheep => {
                const key = `${sheep.tileX},${sheep.tileY}`;
                if (occupiedSet.has(key)) {
                    const neighbors = [
                        { x: 0, y: -1 }, { x: 1, y: 0 }, { x: 0, y: 1 }, { x: -1, y: 0 },
                        { x: 1, y: -1 }, { x: 1, y: 1 }, { x: -1, y: 1 }, { x: -1, y: -1 }
                    ];
                    for (const n of neighbors) {
                        const nx = sheep.tileX + n.x;
                        const ny = sheep.tileY + n.y;
                        const tileExists = groundMap.tiles.find(t => t.x === nx && t.y === ny && t.tile.isPlaceable);
                        const isOccupied = occupiedSet.has(`${nx},${ny}`);
                        if (tileExists && !isOccupied) {
                            return {
                                ...sheep,
                                tileX: nx,
                                tileY: ny,
                                pixelX: nx * tileSize - 37,
                                pixelY: ny * tileSize - 74,
                                sortY: (ny + 1) * tileSize
                            };
                        }
                    }
                    return sheep;
                }
                return sheep;
            });
        });
    }, [buildingsMap, groundMap, tileSize]);
    return { sheepList };
};