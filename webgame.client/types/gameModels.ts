import type { Map } from "./mapModels";

export type GameState = {
  playerId: string;
  sheep: number;
  maxSheep: number;
  population: number;
  freeSpace: number;
  maxPopulation: number;
  lastUpdated: string;
  buildingMapId: number;
  buildingMap: Map;
  level: number;
};