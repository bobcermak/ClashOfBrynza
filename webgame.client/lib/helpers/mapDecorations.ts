import type { Map } from "../../types/mapModels";

export interface DecorationConfig {
    type: string;
    src: string;
    frameWidth: number;
    frameHeight: number;
    columns: number;
    rows: number;
    frameRate: number;
    probability: number;
    offsetX: number;
    offsetY: number;
}
export const DECORATIONS: DecorationConfig[] = [
    {
        type: 'sheep',
        src: '/images/sprite-animations/sheep.png',
        frameWidth: 128,
        frameHeight: 128,
        columns: 12,
        rows: 1,
        frameRate: 8,
        probability: 0.005,
        offsetX: -37,
        offsetY: -74,
    },
    {
        type: 'bush-1',
        src: '/images/sprite-animations/bush-1.png',
        frameWidth: 128,
        frameHeight: 128,
        columns: 8,
        rows: 1,
        frameRate: 8,
        probability: 0.02,
        offsetX: -37,
        offsetY: -74,
    },
    {
        type: 'bush-2',
        src: '/images/sprite-animations/bush-2.png',
        frameWidth: 128,
        frameHeight: 128,
        columns: 8,
        rows: 1,
        frameRate: 8,
        probability: 0.02,
        offsetX: -37,
        offsetY: -74,
    },
    {
        type: 'tree-1',
        src: '/images/sprite-animations/tree-1.png',
        frameWidth: 192,
        frameHeight: 256,
        columns: 8,
        rows: 1,
        frameRate: 8,
        probability: 0.01,
        offsetX: -69,
        offsetY: -202,
    },
    {
        type: 'tree-2',
        src: '/images/sprite-animations/tree-2.png',
        frameWidth: 192,
        frameHeight: 256,
        columns: 8,
        rows: 1,
        frameRate: 8,
        probability: 0.01,
        offsetX: -69,
        offsetY: -202,
    }
];
const hash = (x: number, y: number, seed: number = 0): number => {
    let h = 0x811c9dc5;
    h ^= x;
    h = Math.imul(h, 0x01000193);
    h ^= y;
    h = Math.imul(h, 0x01000193);
    h ^= seed;
    h = Math.imul(h, 0x01000193);
    return (h >>> 0) / 4294967296;
}
export type DecorationInstance = {
    id: string;
    config: DecorationConfig;
    x: number;
    y: number;
    pixelX: number;
    pixelY: number;
}
const getConfig = (type: string): DecorationConfig | undefined => {
    return DECORATIONS.find(d => d.type === type);
}
export const getDecorationsForMap = (groundMap: Map, buildingsMap: Map, tileSize: number): DecorationInstance[] => {
    const decorations: DecorationInstance[] = [];
    const occupiedTiles = new Set<string>();
    buildingsMap.buildings.forEach(b => {
        for (let dx = 0; dx < b.building.baseWidth; dx++) {
            for (let dy = 0; dy < b.building.baseHeight; dy++) {
                const tileX = b.bottomLeftX + dx;
                const tileY = b.bottomLeftY - b.building.baseHeight + 1 + dy;
                occupiedTiles.add(`${tileX},${tileY}`);
            }
        }
    });
    const validPlaceableTiles = new Set<string>();
    let minX = Infinity, maxX = -Infinity, minY = Infinity, maxY = -Infinity;
    groundMap.tiles.forEach(t => {
        if (t.x < minX) minX = t.x;
        if (t.x > maxX) maxX = t.x;
        if (t.y < minY) minY = t.y;
        if (t.y > maxY) maxY = t.y;
        if (t.tile.isPlaceable) {
            validPlaceableTiles.add(`${t.x},${t.y}`);
        }
    });
    if (minX === Infinity) return [];
    const mapWidth = maxX - minX + 1;
    const mapHeight = maxY - minY + 1;
    const GROUPS = [
        [
            { type: 'bush-1', dx: 0, dy: 0 },
            { type: 'tree-1', dx: 0, dy: 0 },
            { type: 'tree-2', dx: 1, dy: 1 },
        ],
        [
            { type: 'bush-2', dx: 0, dy: 0 },
            { type: 'tree-1', dx: 0, dy: 0 },
            { type: 'tree-2', dx: 1, dy: 1 },
        ],
        [
            { type: 'bush-1', dx: 0, dy: 0 },
            { type: 'tree-2', dx: 1, dy: 1 },
        ],
        [
            { type: 'bush-2', dx: 0, dy: 0 },
            { type: 'tree-1', dx: 1, dy: 1 },
        ]
    ];
    const SECTORS_X = 3;
    const SECTORS_Y = 3;
    const sectorW = Math.ceil(mapWidth / SECTORS_X);
    const sectorH = Math.ceil(mapHeight / SECTORS_Y);
    for (let sx = 0; sx < SECTORS_X; sx++) {
        for (let sy = 0; sy < SECTORS_Y; sy++) {
            const sMinX = minX + sx * sectorW;
            const sMinY = minY + sy * sectorH;
            let placed = false;
            for (let attempt = 0; attempt < 50; attempt++) {
                if (placed) break;
                const r1 = hash(sx, sy, attempt * 111);
                const r2 = hash(sx, sy, attempt * 222 + 7);
                const tx = sMinX + Math.floor(r1 * sectorW);
                const ty = sMinY + Math.floor(r2 * sectorH);
                if (tx > maxX || ty > maxY) continue;
                if (!validPlaceableTiles.has(`${tx},${ty}`)) continue;
                const grpIdx = Math.floor(hash(tx, ty, 333) * GROUPS.length);
                const group = GROUPS[grpIdx];
                let terrainValid = true;
                let buildingCollision = false;
                for (const item of group) {
                    for (let dx = -1; dx <= 1; dx++) {
                        for (let dy = -1; dy <= 1; dy++) {
                            const px = tx + item.dx + dx;
                            const py = ty + item.dy + dy;
                            const key = `${px},${py}`;
                            if (!validPlaceableTiles.has(key)) {
                                terrainValid = false;
                                break;
                            }
                        }
                        if (!terrainValid) break;
                    }
                    if (!terrainValid) break;
                }
                if (!terrainValid) {
                    continue;
                }
                for (const item of group) {
                    for (let dx = -1; dx <= 1; dx++) {
                        for (let dy = -1; dy <= 1; dy++) {
                            const px = tx + item.dx + dx;
                            const py = ty + item.dy + dy;
                            const key = `${px},${py}`;
                            if (occupiedTiles.has(key)) {
                                buildingCollision = true;
                                break;
                            }
                        }
                        if (buildingCollision) break;
                    }
                    if (buildingCollision) break;
                }
                if (buildingCollision) {
                    placed = true;
                    break;
                }
                if (true) {
                    for (const item of group) {
                        const config = getConfig(item.type);
                        if (!config) continue;
                        const finalX = tx + item.dx;
                        const finalY = ty + item.dy;
                        decorations.push({
                            id: `deco-grp-${sx}-${sy}-${finalX}-${finalY}`,
                            config,
                            x: finalX,
                            y: finalY,
                            pixelX: finalX * tileSize + config.offsetX,
                            pixelY: finalY * tileSize + config.offsetY
                        });
                        occupiedTiles.add(`${finalX},${finalY}`);
                    }
                    placed = true;
                }
            }
        }
    }
    return decorations;
}