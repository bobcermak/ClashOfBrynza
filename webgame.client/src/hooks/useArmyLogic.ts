import { useState, useEffect } from "react";
import type { Map } from "../../types/mapModels";

type ArmyGroup = {
    src: string;
    frameWidth: number;
    frameHeight: number;
    columns: number;
    rows: number;
    frameRate: number;
    loop: boolean;
    autoplay: boolean;
    x: number;
    y: number;
    delay?: number;
};
export const useArmyLogic = (buildingsMap: Map, groundMap: Map, tileSize: number) => {
    const initialArmyGroups: ArmyGroup[][] = [
        [
            { src: "/images/sprite-animations/archer.png", frameWidth: 192, frameHeight: 256, columns: 6, rows: 1, frameRate: 8, loop: true, autoplay: true, x: 2150, y: 850, delay: 2000 },
            { src: "/images/sprite-animations/archer.png", frameWidth: 192, frameHeight: 256, columns: 6, rows: 1, frameRate: 8, loop: true, autoplay: true, x: 2200, y: 800, delay: 1000 },
        ],
        [
            { src: "/images/sprite-animations/archer-shoot.png", frameWidth: 192, frameHeight: 256, columns: 8, rows: 1, frameRate: 8, loop: true, autoplay: true, x: 2700, y: 100, delay: 3000 },
            { src: "/images/sprite-animations/archer-shoot.png", frameWidth: 192, frameHeight: 256, columns: 8, rows: 1, frameRate: 8, loop: true, autoplay: true, x: 2750, y: 150, delay: 500 },
        ],
        [{ src: "/images/sprite-animations/lancer.png", frameWidth: 320, frameHeight: 320, columns: 12, rows: 1, frameRate: 8, loop: true, autoplay: true, x: 1815, y: 1250, delay: 4000 }],
        [
            { src: "/images/sprite-animations/lancer.png", frameWidth: 320, frameHeight: 320, columns: 12, rows: 1, frameRate: 8, loop: true, autoplay: true, x: 2600, y: 1100, delay: 2000 },
            { src: "/images/sprite-animations/lancer.png", frameWidth: 320, frameHeight: 320, columns: 12, rows: 1, frameRate: 8, loop: true, autoplay: true, x: 2650, y: 1150, delay: 1000 },
        ],
        [
            { src: "/images/sprite-animations/lancer.png", frameWidth: 320, frameHeight: 320, columns: 12, rows: 1, frameRate: 8, loop: true, autoplay: true, x: 1800, y: 400, delay: 1000 },
            { src: "/images/sprite-animations/lancer.png", frameWidth: 320, frameHeight: 320, columns: 12, rows: 1, frameRate: 8, loop: true, autoplay: true, x: 1850, y: 350, delay: 2000 },
        ],
        [
            { src: "/images/sprite-animations/monk.png", frameWidth: 192, frameHeight: 256, columns: 6, rows: 1, frameRate: 8, loop: true, autoplay: true, x: 400, y: 1050, delay: 1000 },
            { src: "/images/sprite-animations/monk.png", frameWidth: 192, frameHeight: 256, columns: 6, rows: 1, frameRate: 8, loop: true, autoplay: true, x: 450, y: 1100, delay: 2000 },
            { src: "/images/sprite-animations/monk.png", frameWidth: 192, frameHeight: 256, columns: 6, rows: 1, frameRate: 8, loop: true, autoplay: true, x: 500, y: 1100, delay: 3000 },
        ],
        [{ src: "/images/sprite-animations/warrior.png", frameWidth: 192, frameHeight: 256, columns: 8, rows: 1, frameRate: 8, loop: true, autoplay: true, x: 1445, y: 1315, delay: 1000 }],
        [{ src: "/images/sprite-animations/warrior.png", frameWidth: 192, frameHeight: 256, columns: 8, rows: 1, frameRate: 8, loop: true, autoplay: true, x: 500, y: 700, delay: 2000 }],
    ];
    const [armyGroups, setArmyGroups] = useState(initialArmyGroups);
    useEffect(() => {
        let hasChanges = false;
        const contentArmyGroups = armyGroups.flat();
        const newArmyGroups = armyGroups.map(group => {
            const updatedGroup = group.map(unit => {
                const unitTileX = Math.floor((unit.x + unit.frameWidth / 2) / tileSize);
                const unitTileY = Math.floor((unit.y + unit.frameHeight / 2) / tileSize);
                const isBuildingColliding = buildingsMap.buildings.some(b => {
                    const bMinX = b.bottomLeftX;
                    const bMaxX = b.bottomLeftX + b.building.baseWidth - 1;
                    const bMinY = b.bottomLeftY - b.building.baseHeight + 1;
                    const bMaxY = b.bottomLeftY;
                    return unitTileX >= bMinX && unitTileX <= bMaxX &&
                        unitTileY >= bMinY && unitTileY <= bMaxY;
                });
                let isTerrainInvalid = false;
                const currentTile = groundMap.tiles.find(t => t.x === unitTileX && t.y === unitTileY);
                if (currentTile && !currentTile.tile.isPlaceable) {
                    isTerrainInvalid = true;
                }
                if (isBuildingColliding || isTerrainInvalid) {
                    hasChanges = true;
                    let foundX = unit.x;
                    let foundY = unit.y;
                    let found = false;
                    for (let radius = 1; radius <= 10; radius++) {
                        for (let dx = -radius; dx <= radius; dx++) {
                            for (let dy = -radius; dy <= radius; dy++) {
                                if (Math.abs(dx) !== radius && Math.abs(dy) !== radius) continue;
                                const tx = unitTileX + dx;
                                const ty = unitTileY + dy;
                                const potentialX = unit.x + (dx * tileSize);
                                const potentialY = unit.y + (dy * tileSize);
                                const tile = groundMap.tiles.find(t => t.x === tx && t.y === ty);
                                if (!tile || !tile.tile.isPlaceable) continue;
                                const isSpotCollidingWithBuilding = buildingsMap.buildings.some(b => {
                                    const bMinX = b.bottomLeftX;
                                    const bMaxX = b.bottomLeftX + b.building.baseWidth - 1;
                                    const bMinY = b.bottomLeftY - b.building.baseHeight + 1;
                                    const bMaxY = b.bottomLeftY;
                                    return tx >= bMinX && tx <= bMaxX && ty >= bMinY && ty <= bMaxY;
                                });
                                if (isSpotCollidingWithBuilding) continue;
                                const isSpotCollidingWithUnits = contentArmyGroups.some(otherUnit => {
                                    if (otherUnit === unit) return false;
                                    const dist = Math.sqrt(
                                        Math.pow(potentialX - otherUnit.x, 2) +
                                        Math.pow(potentialY - otherUnit.y, 2)
                                    );
                                    return dist < 100;
                                });
                                if (!isSpotCollidingWithUnits) {
                                    foundX = potentialX;
                                    foundY = potentialY;
                                    found = true;
                                    unit.x = foundX;
                                    unit.y = foundY;
                                    break;
                                }
                            }
                            if (found) break;
                        }
                        if (found) break;
                    }
                    if (found) {
                        return { ...unit, x: foundX, y: foundY };
                    } else {
                        return null;
                    }
                }
                return unit;
            }).filter((u): u is typeof group[number] => u !== null);
            if (updatedGroup.length !== group.length) {
                hasChanges = true;
            }
            return updatedGroup;
        }).filter(group => group.length > 0);
        if (hasChanges) {
            setArmyGroups(newArmyGroups);
        }
    }, [buildingsMap, tileSize, groundMap]);
    return { armyGroups };
};