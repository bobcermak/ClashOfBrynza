import { type FC, use, useState, useRef, useEffect } from "react";
import type { GameState } from "./../../types/gameModels";
import type { Building, Map, MapBuilding } from "./../../types/mapModels";
import MapCanvas from "./../map/MapCanvas";
import { addSheep } from "../../lib/gameUtils";
import { Button, Resource, TownHallLevel, Shop, BuildingMenu, GameOver, MusicButton, LevelUpGame, TutorialMonk, WinScreen } from "./../components";

import { useAudio } from "../hooks/useAudio";
import { addBuilding, deleteBuilding, upgradeBuilding } from "../../lib/mapUtils";
import { hasEnoughToUpgrade } from "../../lib/gameUtils";
import { Link, useNavigate } from "react-router-dom";

type GameProps = {
  groundMapPromise: Promise<Map>;
  buildingsPromise: Promise<Building[]>;
  gameStatePromise: Promise<GameState>;
};
const Game: FC<GameProps> = ({ groundMapPromise, buildingsPromise, gameStatePromise }) => {
  //Hooks
  const navigate = useNavigate();
  const groundMap: Map = use<Map>(groundMapPromise);
  const initialGameState: GameState = use<GameState>(gameStatePromise);
  const [gameState, setGameState] = useState<GameState>(initialGameState);
  const buildings: Building[] = use<Building[]>(buildingsPromise);
  const [isOpenShop, setIsOpenShop] = useState<boolean>(false);
  const [placingBuilding, setPlacingBuilding] = useState<Building | null>(null);
  const [currentBuilding, setCurrentBuilding] = useState<MapBuilding | null>(null);
  const shopButtonRef = useRef<HTMLLIElement>(null);
  const [inStarvation, setInStarvation] = useState<boolean>(false);
  const [displayError, setDisplayError] = useState<string | null>(null);
  const [isLevelUpGame, setIsLevelUpGame] = useState<boolean>(false);
  const [isAddBuildingError, setIsAddBuildingError] = useState<{ error: boolean; message: string }>({
    error: false,
    message: "",
  });
  const [isUpgradeBuildingError, setIsUpgradeBuildingError] = useState<{ error: boolean; message: string }>({
    error: false,
    message: "",
  });
  const { playBackgroundMusic } = useAudio();

  useEffect(() => {
    const musicSrc = "/audios/game-soundtrack.mp3";
    playBackgroundMusic(musicSrc);
    const handleInteraction = () => {
      playBackgroundMusic(musicSrc);
    };
    window.addEventListener("click", handleInteraction, { once: true });
    window.addEventListener("keydown", handleInteraction, { once: true });
    return () => {
      window.removeEventListener("click", handleInteraction);
      window.removeEventListener("keydown", handleInteraction);
    };
  }, [playBackgroundMusic]);
  useEffect(() => {
    if (isAddBuildingError.error) setDisplayError(isAddBuildingError.message);
  }, [isAddBuildingError]);
  useEffect(() => {
    if (isUpgradeBuildingError.error) setDisplayError(isUpgradeBuildingError.message);
  }, [isUpgradeBuildingError]);
  useEffect(() => {
    if (!isAddBuildingError.error && !isUpgradeBuildingError.error) {
      setDisplayError(null);
    }
  }, [isAddBuildingError, isUpgradeBuildingError]);
  const activeError = displayError ? { message: displayError } : null;
  useEffect(() => {
    if (isAddBuildingError.error || isUpgradeBuildingError.error) {
      const timer = setTimeout(() => {
        setIsAddBuildingError((prev) => ({ ...prev, error: false }));
        setIsUpgradeBuildingError((prev) => ({ ...prev, error: false }));
      }, 2600);
      return () => clearTimeout(timer);
    }
  }, [isAddBuildingError, isUpgradeBuildingError]);
  //Advance game every 5 seconds
  useEffect(() => {
    if (gameState.level >= 10) return;
    const interval = setInterval(async () => {
      if (gameState?.playerId) {
        const response = await fetch(`/api/game/advance/${gameState.playerId}`);
        if (response.ok) {
          const updatedState = await response.json();
          setGameState(updatedState);
        }
      }
    }, inStarvation ? 1500 : 2500);
    return () => clearInterval(interval);
  }, [gameState?.playerId, gameState.level, inStarvation]);
  useEffect(() => {
    if (gameState.sheep < gameState.population) {
      setInStarvation(true);
    } else {
      setInStarvation(false);
    }
  }, [gameState.sheep, gameState.population]);
  const handleUpgradeBuilding = async (mapBuilding: MapBuilding) => {
    const data = await upgradeBuilding(mapBuilding, setIsUpgradeBuildingError);
    if (data) {
      setGameState(data);
      const updatedBuilding = data.buildingMap.buildings.find((b) => b.mapId === mapBuilding.mapId && b.bottomLeftX === mapBuilding.bottomLeftX && b.bottomLeftY === mapBuilding.bottomLeftY);
      if (updatedBuilding) setCurrentBuilding(updatedBuilding);
    } else setCurrentBuilding(null);
  };
  const handleAddBuilding = async (buildingId: number, bottomLeftX: number, bottomLeftY: number): Promise<boolean> => {
    const data = await addBuilding(buildingId, bottomLeftX, bottomLeftY, gameState.playerId, setIsAddBuildingError);
    if (data) {
      setGameState(data);
      return true;
    }
    return false;
  };
  const handleDeleteBuilding = async (mapBuilding: MapBuilding) => {
    const buildingToDelete = { ...mapBuilding };
    if ((!buildingToDelete.mapId || buildingToDelete.mapId <= 0) && gameState?.buildingMap?.mapId) {
      buildingToDelete.mapId = gameState.buildingMap.mapId;
    }
    const data = await deleteBuilding(buildingToDelete);
    if (data) setGameState(data);
    setCurrentBuilding(null);
  };
  const handleRestart = async () => {
    try {
      const res = await fetch("/api/game/create");
      if (res.ok) {
        const newId = await res.text();
        localStorage.setItem("playerId", newId);
        localStorage.setItem(`hasPlayed_${newId}`, "true");
        window.location.reload();
      }
    } catch (e) {
      console.error("Restart failed", e);
    }
  };
  const handleLevelUpWin = () => {
    const townHall = gameState.buildingMap.buildings.find((b) => b.building.isTownHall);
    if (townHall) {
      handleUpgradeBuilding(townHall);
    }
  };
  const handleLevelUpLoss = async (cost: number) => {
    const data = await addSheep(gameState.playerId, -cost);
    if (data) setGameState((prev) => ({ ...prev, sheep: data.sheep }));
  };
  const upgradeCost = gameState.buildingMap.buildings.find((b) => b.building.isTownHall)?.building?.levels.find((l) => l.level === gameState.level)?.upgradeCost ?? 0;
  return (
    <div className="game">
      <TutorialMonk />
      {gameState.sheep <= 0 && <GameOver onRestart={handleRestart} onHome={() => navigate("/menu")} />}
      {gameState.level >= 10 && <WinScreen onRestart={handleRestart} onHome={() => navigate("/menu")} />}

      <div className="page">
        {inStarvation && gameState.sheep > 0 && (
          <div className="starvation-alert">
            <div className="starvation-alert__border" />
            <p className="starvation-alert__banner">
              ⚠️ Kritický nedostatek ovcí! Populace požírá chovné stádo. Zbourej budovy a zmenší populaci, než snědí i <strong>poslední ovci</strong>!
            </p>
          </div>
        )}
        {activeError && (
          <div className="error-alert">
            <p className="error-alert__banner">❌ {activeError.message} ❌</p>
          </div>
        )}
        <div className="page__townhall-level">
          <TownHallLevel currentLevel={gameState.level} />
          <p className="user-id">
            id: <span>{gameState.playerId}</span>
          </p>
        </div>
        <div className="music-position">
          <MusicButton />
        </div>
        <Shop
          isOpen={isOpenShop}
          buildings={buildings}
          onClose={() => setIsOpenShop(false)}
          onBuildingBuy={(building) => {
            setPlacingBuilding(building);
            setIsOpenShop(false);
          }}
        />
        <BuildingMenu
          onBuildingUpgrade={(building) => {
            if (building.building.isTownHall) {
              if (hasEnoughToUpgrade(gameState)) {
                setIsLevelUpGame(true);
              } else {
                setIsUpgradeBuildingError({ error: true, message: "Nemáš dostatek ovcí ani populace na vylepšení!" });
              }
              setCurrentBuilding(null);
            } else {
              handleUpgradeBuilding(building);
            }
          }}
          onDeleteBuilding={handleDeleteBuilding}
          isOpen={currentBuilding !== null}
          building={currentBuilding ?? undefined}
          onClose={() => setCurrentBuilding(null)}
        />
        <ul className="page__resources-area">
          <li>
            <Resource maxWidth="300px" imgSrc="images/content/sheep.png" color="#9B7260" maxAmount={gameState.maxSheep} currentAmount={gameState.sheep} />
          </li>
          <li>
            <Resource maxWidth="250px" imgSrc="images/content/monk.png" color="#4795A7" maxAmount={gameState.maxPopulation} currentAmount={gameState.population} />
          </li>
          <li>
            <Resource maxWidth="200px" imgSrc="images/content/grass.png" color="#455A4B" maxAmount={100} currentAmount={Math.floor((gameState.freeSpace / 1513) * 100)} />
          </li>
        </ul>
        <ul className="page__buttons-area">
          {placingBuilding ? (
            <li>
              <Button
                onClick={() => {
                  setPlacingBuilding(null);
                }}
                variant="secondary"
                imgSrc="images/content/house.png"
              >
                Zrušit
              </Button>
            </li>
          ) : isLevelUpGame ? (
            <li ref={shopButtonRef}>
              <Button onClick={() => setIsLevelUpGame(false)} variant="secondary" bgColor="button--secondary--brown" imgSrc="images/content/house.png">
                Vesnice
              </Button>
            </li>
          ) : (
            <li ref={shopButtonRef}>
              <Button onClick={() => setIsOpenShop(true)} variant="secondary" bgColor="button--secondary--blue" imgSrc="images/content/house.png">
                Stavět
              </Button>
            </li>
          )}
        </ul>
        <div className="page__home-button">
          <Link to="/menu">
            <Button variant="secondary" bgColor="button--secondary--blue" smallerImg={true} imgSrc="images/content/arrow.png">
              Domů
            </Button>
          </Link>
        </div>
        {gameState && !isLevelUpGame && (
          <MapCanvas
            groundMap={groundMap}
            buildingsMap={gameState.buildingMap}
            tileSize={54}
            placingBuilding={placingBuilding}
            onMapClick={async (x, y) => {
              if (placingBuilding !== null) {
                const success = await handleAddBuilding(placingBuilding.buildingId, x, y);
                if (success) {
                  setPlacingBuilding(null);
                }
              }
            }}
            onBuildingClick={(building) => {
              if (placingBuilding === null) setCurrentBuilding(building);
            }}
            inStarvation={inStarvation}
          />
        )}
        {isLevelUpGame && <LevelUpGame villageToggle={setIsLevelUpGame} currentLevel={gameState.level} onWin={handleLevelUpWin} onLoss={handleLevelUpLoss} upgradeCost={upgradeCost} />}
      </div>
    </div>
  );
};
export default Game;