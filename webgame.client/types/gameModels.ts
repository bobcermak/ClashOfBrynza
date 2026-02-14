import type { Map } from "./mapModels";

export type GameState = {
  playerId: string;
  sheep: number;
  maxSheep: number;
  population: number;
  freeSpace: number;
  maxPopulation: number;
  lastUpdated: string;
  createdAt: string;
  playTimeSeconds: number;
  buildingMapId: number;
  buildingMap: Map;
  level: number;
};
export type LeaderboardEntry = {
  nickname: string;
  timeInSeconds: number;
  completedAt: string;
  playerId: string;
};