export type Tile = {
  tileId: number;
  isPlaceable: boolean;
  imageUrl: string;
  isEdgeNorth: boolean;
  isEdgeSouth: boolean;
  isEdgeEast: boolean;
  isEdgeWest: boolean;
};

export type Building = {
  buildingId: number;
  name: string;
  description: string;
  resourceId: number | null;
  resource: Resource | null;
  isTownHall: boolean;
  initialCost: number;
  height: number;
  baseHeight: number;
  width: number;
  baseWidth: number;
  levels: BuildingLevel[];
  imageUrl: string;
};

export type BuildingLevel = {
  buildingLevelId: number;
  buildingId: number;
  level: number;
  upgradeCost: number;
  capacity: number;
  populationCost: number;
};

export type Resource = {
  resourceId: number;
  name: string;
  description: string;
};

export type MapBuilding = {
  buildingId: number;
  building: Building;
  mapId: number;
  bottomLeftX: number;
  bottomLeftY: number;
  level: number;
};

export type MapBuildingDTO = {
  playerId: string;
  buildingId: number;
  bottomLeftX: number;
  bottomLeftY: number;
};

export type MapTile = {
  mapTileId: number;
  tileId: number;
  tile: Tile;
  mapId: number;
  zIndex: number;
  x: number;
  y: number;
};

export type Map = {
  mapId: number;
  title: string;
  buildings: MapBuilding[];
  tiles: MapTile[];
};
