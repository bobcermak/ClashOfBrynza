import type { Building, Map, MapBuilding, MapBuildingDTO } from "./../types/mapModels";
import type { GameState } from "./../types/gameModels";

//Promises
export const groundMapPromise: Promise<Map> = fetch("/api/map/ground").then((res) => res.json());

export const buildingsPromise: Promise<Building[]> = fetch("/api/map/buildings").then((res) => res.json());

//Functions
export const addBuilding = async (buildingId: number, bottomLeftX: number, bottomLeftY: number, playerId: string, buildingAddCallback: (response: { error: boolean, message: string }) => void): Promise<GameState | null> => {
  const buildingToPlace: MapBuildingDTO = {
    playerId: playerId,
    buildingId: buildingId,
    bottomLeftX: bottomLeftX,
    bottomLeftY: bottomLeftY,
  };
  const response = await fetch("/api/map/building", {
    method: "POST",
    headers: {
      "Content-Type": "application/json",
    },
    body: JSON.stringify(buildingToPlace),
  });
  if (!response.ok) {
    const errorMessage = await response.text();
    buildingAddCallback({ error: true, message: errorMessage });
    return null;
  }
  const data: GameState = await response.json();
  return data;
};
export const deleteBuilding = async (mapBuilding: MapBuilding): Promise<GameState | null> => {
  const { mapId, bottomLeftX, bottomLeftY } = mapBuilding;
  const response = await fetch(`/api/map/building/${mapId}/${bottomLeftX}/${bottomLeftY}`, {
    method: "DELETE",
  });
  if (!response.ok) {
    return null;
  }
  const data: GameState = await response.json();
  return data;
};
export const upgradeBuilding = async (mapBuilding: MapBuilding, buildingUpgradeCallback: (response: { error: boolean, message: string }) => void): Promise<GameState | null> => {
  const { mapId, bottomLeftX, bottomLeftY } = mapBuilding;
  const response = await fetch(`/api/map/building/upgrade/${mapId}/${bottomLeftX}/${bottomLeftY}`, {
    method: "PUT",
  });
  if (!response.ok) {
    const errorMessage = await response.text();
    buildingUpgradeCallback({ error: true, message: errorMessage });
    return null;
  }
  const data: GameState = await response.json();
  return data;
};