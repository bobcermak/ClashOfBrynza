import { useNavigate } from "react-router-dom";
import { type FC, use, useState, useEffect } from "react";
import type { GameState } from "./../../types/gameModels";
import { useRef } from "react";
import { useGSAP } from "@gsap/react";
import gsap from "gsap";
import { useAudio } from "../hooks/useAudio";
import { MusicButton, Leaderboard } from "../components";

type MenuProps = {
  gameStatePromise: Promise<GameState | null>;
  playerIdPromise: Promise<string>;
  onPlayerIdChange: (newId: string) => void;
};
const Menu: FC<MenuProps> = ({ gameStatePromise, playerIdPromise, onPlayerIdChange }) => {
  //Promises
  const initialGameState: GameState | null = use<GameState | null>(gameStatePromise);
  const playerId: string = use<string>(playerIdPromise);
  //Hooks
  const { playBackgroundMusic, playSFX, isPlaying } = useAudio();
  const navigate = useNavigate();
  const [showCredits, setShowCredits] = useState<boolean>(false);
  const [showEnterId, setShowEnterId] = useState<boolean>(false);
  const [showLeaderboard, setShowLeaderboard] = useState<boolean>(false);
  const [enteredId, setEnteredId] = useState<string>("");
  const [loadError, setLoadError] = useState<string | null>(null);
  const [hasPlayed, setHasPlayed] = useState<boolean>(() => {
    return false;
  });
  const containerRef = useRef<HTMLDivElement>(null);
  const titleRef = useRef<HTMLDivElement>(null);
  const idRef = useRef<HTMLDivElement>(null);
  const buttonsRef = useRef<HTMLMenuElement>(null);
  const creditsRef = useRef<HTMLDivElement>(null);
  const enterIdRef = useRef<HTMLDivElement>(null);
  const goalRef = useRef<HTMLDivElement>(null);

  const handleLoadGame = async (): Promise<void> => {
    if (!enteredId.trim()) {
      setLoadError("Zadejte ID.");
      return;
    }
    try {
      const res = await fetch(`/api/game/state/${enteredId}`);
      if (res.ok) {
        localStorage.setItem(`hasPlayed_${enteredId}`, "true");
        onPlayerIdChange(enteredId);
        navigate("/game");
      } else {
        setLoadError("Hra s tímto ID neexistuje.");
      }
    } catch (e) {
      setLoadError("Chyba při načítání hry.");
    }
  };
  const handleNewGame = async (): Promise<void> => {
    try {
      if ((!initialGameState || !hasPlayed) && playerId) {
        localStorage.setItem(`hasPlayed_${playerId}`, "true");
        setHasPlayed(true);
        onPlayerIdChange(playerId);
        navigate("/game");
      } else {
        const res = await fetch("/api/game/create");
        if (res.ok) {
          const newId = await res.text();
          localStorage.setItem(`hasPlayed_${newId}`, "true");
          localStorage.removeItem("tutorialCompleted");
          onPlayerIdChange(newId);
          navigate("/game");
        } else {
          console.error("Failed to create new game");
        }
      }
    } catch (e) {
      console.error("Error creating new game:", e);
    }
  };
  useEffect(() => {
    if (playerId) {
      const stored = localStorage.getItem(`hasPlayed_${playerId}`);
      setHasPlayed(stored === "true");
    }
  }, [playerId]);
  useGSAP(
    () => {
      const tl = gsap.timeline();
      tl.from(
        ".menu__cloud",
        {
          opacity: 0,
          duration: 1.75,
          ease: "power2.easeInOut",
        },
        0,
      );
      tl.from(
        titleRef.current,
        {
          scale: 0.5,
          opacity: 0,
          duration: 1.25,
          ease: "back.out(1.7)",
        },
        0.2,
      );
      tl.from(
        goalRef.current,
        {
          y: 20,
          opacity: 0,
          duration: 1,
          ease: "power2.out",
        },
        0.5,
      );
    },
    { scope: containerRef },
  );
  useGSAP(
    () => {
      if (!showCredits && !showEnterId && !showLeaderboard) {
        const tl = gsap.timeline();
        if (idRef.current) gsap.set(idRef.current, { opacity: 0, y: 50 });
        if (buttonsRef.current) gsap.set(buttonsRef.current.children, { opacity: 0, y: 30 });
        if (idRef.current) {
          tl.to(idRef.current, {
            y: 0,
            opacity: 1,
            duration: 0.75,
            ease: "power2.easeInOut",
          });
        }
        if (buttonsRef.current) {
          tl.to(
            buttonsRef.current.children,
            {
              y: 0,
              opacity: 1,
              duration: 0.65,
              stagger: 0.1,
              ease: "power2.easeInOut",
            },
            "-=0.3",
          );
        }
      }
    },
    { dependencies: [showCredits, showEnterId, showLeaderboard], scope: containerRef },
  );
  useEffect(() => {
    const musicSrc = "/audios/menu-soundtrack.mp3";
    const musicOptions = { loop: true };
    if (isPlaying) playBackgroundMusic(musicSrc, musicOptions);
    const handleInteraction = () => {
      if (isPlaying) playBackgroundMusic(musicSrc, musicOptions);
    };
    window.addEventListener("click", handleInteraction, { once: true });
    window.addEventListener("keydown", handleInteraction, { once: true });
    return () => {
      window.removeEventListener("click", handleInteraction);
      window.removeEventListener("keydown", handleInteraction);
    };
  }, [playBackgroundMusic, isPlaying]);
  return (
    <div className="menu" ref={containerRef}>
      <div className="music-position">
        <MusicButton />
      </div>
      <div className="menu__container">
        <div className="menu__container-title" ref={titleRef}>
          <figure className="menu__container-title-figure">
            <img className="img-responsive" src="images/content/sheep.png" alt="Obrázek ovce" loading="lazy" />
          </figure>
          <h1 className="menu__container-title-text">Clash Of Brynza</h1>
          <figure className="menu__container-title-figure">
            <img className="img-responsive" src="images/content/sheep.png" alt="Obrázek ovce" loading="lazy" />
          </figure>
        </div>
        <div className="menu__container-goal" ref={goalRef}>
          <p className="menu__container-goal-description">
            Cíl hry je dosáhnout 10. úrovně vesnice. Čím více stavíš, tím vyšší máš populaci a tím více potřebuješ ovcí. Jenže čím více plochy je zastavěno, tím méně mají ovce místa a nemůžeš jich mít
            tolik. Když budeš mít víc populace než ovcí, tak ti ovce začnou umírat.
          </p>
        </div>
        {!showCredits && !showEnterId && !showLeaderboard && (
          <>
            <div className="menu__container-id" ref={idRef}>
              <p className="menu__container-id-text">
                Tvoje id: <span className="menu__container-id-text-span">{playerId}</span>
              </p>
            </div>
            <nav className="menu__container-nav">
              <menu className="menu__container-nav-menu" ref={buttonsRef}>
                <li className="menu__container-nav-menu-item">
                  <button
                    className="menu__container-nav-menu-item-button"
                    onClick={() => {
                      playSFX("/audios/button-click.mp3");
                      setTimeout(() => navigate("/game"), 250);
                    }}
                    style={!initialGameState || !hasPlayed ? { opacity: 0.5, pointerEvents: "none" } : {}}
                  >
                    Pokračovat
                  </button>
                </li>
                <li className="menu__container-nav-menu-item">
                  <button
                    className="menu__container-nav-menu-item-button"
                    onClick={() => {
                      handleNewGame();
                      playSFX("/audios/button-click.mp3");
                    }}
                  >
                    Nová hra
                  </button>
                </li>
                <li className="menu__container-nav-menu-item">
                  <button
                    className="menu__container-nav-menu-item-button"
                    onClick={() => {
                      setShowEnterId(true);
                      playSFX("/audios/button-click.mp3");
                    }}
                  >
                    Načíst hru
                  </button>
                </li>
                <li className="menu__container-nav-menu-item">
                  <button
                    className="menu__container-nav-menu-item-button"
                    onClick={() => {
                      setShowLeaderboard(true);
                      playSFX("/audios/button-click.mp3");
                    }}
                  >
                    Žebříček
                  </button>
                </li>
                <li className="menu__container-nav-menu-item">
                  <button
                    className="menu__container-nav-menu-item-button"
                    onClick={() => {
                      setShowCredits(true);
                      playSFX("/audios/button-click.mp3");
                    }}
                  >
                    Titulky
                  </button>
                </li>
              </menu>
            </nav>
          </>
        )}
        {showEnterId && (
          <div ref={enterIdRef} style={{ display: "contents" }}>
            <div className="menu__container-enter-id">
              <input
                id="menu__container-enter-id-input"
                className="menu__container-enter-id-input"
                type="text"
                placeholder="Zadejte ID:"
                value={enteredId}
                onChange={(e) => {
                  setEnteredId(e.target.value.toLowerCase().trim());
                  setLoadError(null);
                }}
              />
              {loadError && <p className="menu__container-enter-id-error">{loadError}</p>}
            </div>
            <nav className="menu__container-nav">
              <menu className="menu__container-nav-menu">
                <li className="menu__container-nav-menu-item">
                  <button
                    className="menu__container-nav-menu-item-button"
                    onClick={() => {
                      playSFX("/audios/button-click.mp3");
                      handleLoadGame();
                    }}
                  >
                    Pokračovat
                  </button>
                </li>
                <li className="menu__container-nav-menu-item">
                  <button
                    className="menu__container-nav-menu-item-button"
                    onClick={() => {
                      setShowEnterId(false);
                      playSFX("/audios/button-click.mp3");
                    }}
                  >
                    Zpět
                  </button>
                </li>
              </menu>
            </nav>
          </div>
        )}
        {showCredits && (
          <div ref={creditsRef} style={{ display: "contents" }}>
            <div className="menu__container-credits">
              <h2 className="menu__container-credits-title">Vytvořili:</h2>
              <p className="menu__container-credits-text">Bob Čermák a Víťa Dobrovský</p>
              <h2 className="menu__container-credits-title menu__container-credits-title-sound">Hudba:</h2>
              <p className="menu__container-credits-text menu__container-credits-text-sound">alkakrab a Creator Assets</p>
            </div>
            <div className="menu__container-back-credits">
              <button
                className="menu__container-back-button"
                onClick={() => {
                  setShowCredits(false);
                  playSFX("/audios/button-click.mp3");
                }}
              >
                Zpět
              </button>
            </div>
          </div>
        )}
        {showLeaderboard && (
          <Leaderboard onClose={() => setShowLeaderboard(false)} playerId={playerId} />
        )}
      </div>
      <figure className="menu__cloud menu__cloud-1">
        <img className="img-responsive" src="images/content/cloud-t-l.png" alt="Obrázek oblak" loading="lazy" />
      </figure>
      <figure className="menu__cloud menu__cloud-2">
        <img className="img-responsive" src="images/content/cloud-t-r.png" alt="Obrázek oblak" loading="lazy" />
      </figure>
      <figure className="menu__cloud menu__cloud-3">
        <img className="img-responsive" src="images/content/cloud-b-l.png" alt="Obrázek oblak" loading="lazy" />
      </figure>
    </div>
  );
};
export default Menu;