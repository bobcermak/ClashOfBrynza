import type { GameState } from "../types/gameModels";

//Promises
export const getPlayerId = async (): Promise<string> => {
  const storedId = localStorage.getItem("playerId");
  if (storedId) return storedId;
  const res = await fetch("/api/game/create");
  if (!res.ok) throw new Error("Failed to create player ID");
  const newId = await res.text();
  localStorage.setItem("playerId", newId);
  return newId;
};
export const createGamePromises = (overridePlayerId?: string | null) => {
  const playerIdPromise = (async () => {
    if (overridePlayerId) {
      localStorage.setItem("playerId", overridePlayerId);
      return overridePlayerId;
    }
    return await getPlayerId();
  })();
  const existingGameStatePromise: Promise<GameState | null> = playerIdPromise.then(async (playerId) => {
    const res = await fetch(`/api/game/state/${playerId}`);
    if (!res.ok) return null;
    return await res.json();
  });
  const ensureGameStatePromise: Promise<GameState> = playerIdPromise.then(async (playerId) => {
    let res = await fetch(`/api/game/state/${playerId}`);
    if (!res.ok) {
      await fetch(`/api/game/create/?playerId=${playerId}`);
      res = await fetch(`/api/game/state/${playerId}`);
    }
    return await res.json();
  });
  return { playerIdPromise, existingGameStatePromise, gameStatePromise: ensureGameStatePromise };
};
const defaultPromises = createGamePromises(localStorage.getItem("playerId"));
export const playerIdPromise = defaultPromises.playerIdPromise;
export const existingGameStatePromise = defaultPromises.existingGameStatePromise;
export const gameStatePromise = defaultPromises.gameStatePromise;
export const hasEnoughToUpgrade = (gameState: GameState): boolean => {
  const townHall = gameState.buildingMap.buildings.find((b) => b.building.isTownHall);
  if (!townHall) return false;

  const levelInfo = townHall.building?.levels.find((l) => l.level === townHall.level);
  const cost = levelInfo?.upgradeCost ?? 0;
  const populationRequirement = levelInfo?.populationCost ?? 0;

  return gameState.sheep >= cost && gameState.population >= populationRequirement;
};

export const addSheep = async (playerId: string, amount: number): Promise<GameState> => {
  const res = await fetch(`/api/game/sheep/${playerId}/${amount}`);
  if (!res.ok) throw new Error("Failed to add sheep");
  return await res.json();
};
