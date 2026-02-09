import { type FC, useState, useEffect, useRef } from "react";
import { Button } from "../../components";

type LevelUpGameProps = {
  currentLevel: number;
  villageToggle: (value: boolean) => void;
  onWin: () => void;
  onLoss: (cost: number) => void;
  upgradeCost: number;
};
const LevelUpGame: FC<LevelUpGameProps> = ({ currentLevel, villageToggle, onWin, onLoss, upgradeCost }) => {
  const maxLevels = 10;
  //Hooks
  const [isPlaying, setIsPlaying] = useState<boolean>(false);
  const [gameOver, setGameOver] = useState<boolean>(false);
  const [isWinner, setIsWinner] = useState<boolean>(false);
  const [enemies, setEnemies] = useState<{ id: number; src: string; x: number; y: number; angle: number }[]>([]);
  const [stuckSwords, setStuckSwords] = useState<number[]>([]);
  const [isReloading, setIsReloading] = useState<boolean>(false);
  //Refs
  const circleRef = useRef<HTMLElement>(null);
  const rotationRef = useRef(0);
  const speedRef = useRef(0);
  const isReloadingRef = useRef(false);

  const initializeGame = () => {
    const newEnemies = Array.from({ length: 8 }).map((_, index) => {
      const angleDeg = index * (360 / 8);
      const angleRad = angleDeg * (Math.PI / 180);
      const radius = 160;
      const x = Math.cos(angleRad) * radius;
      const y = Math.sin(angleRad) * radius;
      return {
        id: index,
        src: Math.random() > 0.5 ? "images/content/enemy-1.png" : "images/content/enemy-2.png",
        x,
        y,
        angle: angleDeg,
      };
    });
    setEnemies(newEnemies);
    setStuckSwords([]);
    setGameOver(false);
    setIsWinner(false);
    setIsPlaying(false);
    rotationRef.current = 0;
    if (circleRef.current) {
      circleRef.current.style.transform = `rotate(0deg)`;
    }
  };
  const handleShoot = () => {
    if (gameOver || isWinner) {
      initializeGame();
      return;
    }
    if (!isPlaying) {
      setIsPlaying(true);
      return;
    }
    if (isReloadingRef.current) return;
    setIsReloading(true);
    isReloadingRef.current = true;
    setTimeout(() => {
      setIsReloading(false);
      isReloadingRef.current = false;
    }, 300);
    const currentRotation = rotationRef.current % 360;
    let hitAngle = (90 - currentRotation) % 360;
    if (hitAngle < 0) hitAngle += 360;
    const hitSwordCollision = stuckSwords.some((swordAngle) => {
      const diff = Math.abs(swordAngle - hitAngle);
      const normalizedDiff = Math.min(diff, 360 - diff);
      return normalizedDiff < 15;
    });
    if (hitSwordCollision) {
      setGameOver(true);
      setIsPlaying(false);
      onLoss(upgradeCost);
      return;
    }
    setStuckSwords((prev) => [...prev, hitAngle]);
    const hitEnemyIndex = enemies.findIndex((enemy) => {
      const diff = Math.abs(enemy.angle - hitAngle);
      const normalizedDiff = Math.min(diff, 360 - diff);
      return normalizedDiff < 20;
    });
    if (hitEnemyIndex !== -1) {
      const nextEnemies = enemies.filter((_, i) => i !== hitEnemyIndex);
      setEnemies(nextEnemies);
      if (nextEnemies.length === 0) {
        setIsWinner(true);
        setIsPlaying(false);
        onWin();
        villageToggle(false);
      }
    }
  };
  useEffect(() => {
    initializeGame();
  }, []);
  useEffect(() => {
    let animationFrameId: number;
    if (!isPlaying || gameOver || isWinner) return;
    const animate = () => {
      const baseSpeed = 0.15 + currentLevel * 0.08;
      const randomChance = 0.002 + currentLevel * 0.002;
      if (Math.random() < randomChance) {
        speedRef.current += 1.5 + currentLevel * 0.3;
      }
      speedRef.current *= 0.95;
      rotationRef.current += baseSpeed + speedRef.current;
      if (circleRef.current) {
        circleRef.current.style.transform = `rotate(${rotationRef.current}deg)`;
      }
      animationFrameId = requestAnimationFrame(animate);
    };
    animate();
    return () => cancelAnimationFrame(animationFrameId);
  }, [currentLevel, isPlaying, gameOver, isWinner]);
  return (
    <div className="level-up-game">
      <div className="level-up-game__dots-map" style={{ opacity: isPlaying ? 0 : 100, transition: "opacity 0.25s ease-in-out" }}>
        {Array.from({ length: maxLevels }, (_, index) => (
          <span key={index} className={`level-up-game__dot ${index < currentLevel ? "level-up-game__dot--active" : ""}`} />
        ))}
      </div>
      <figure className="level-up-game__circle" ref={circleRef} style={{ position: "relative" }}>
        <img className="img-responsive" src="images/content/circle.webp" alt="Obrázek terče" loading="lazy" style={{ position: "relative", zIndex: 2 }} />
        {enemies.map((enemy) => (
          <img
            key={enemy.id}
            src={enemy.src}
            alt="Enemy"
            className="level-up-game__enemy"
            style={{
              left: `calc(50% + ${enemy.x}px)`,
              top: `calc(50% + ${enemy.y}px)`,
              zIndex: 3,
            }}
          />
        ))}
        {stuckSwords.map((angle, index) => {
          const angleRad = angle * (Math.PI / 180);
          const radius = 180;
          const x = Math.cos(angleRad) * radius;
          const y = Math.sin(angleRad) * radius;
          return (
            <img
              key={`sword-${index}`}
              src="images/content/sword.png"
              alt="Sword"
              style={{
                position: "absolute",
                width: "30px",
                left: `calc(50% + ${x}px)`,
                top: `calc(50% + ${y}px)`,
                transform: `translate(-50%, -50%) rotate(${angle - 90}deg)`,
                pointerEvents: "none",
                zIndex: 1,
              }}
            />
          );
        })}
      </figure>
      <div className="level-up-game__content">
        {!isWinner && !gameOver ? (
          <>
            <figure className="level-up-game__content-img" style={{ opacity: isReloading || gameOver || isWinner ? 0 : 1, transition: "opacity 0.1s" }}>
              <img className="img-responsive" src="images/content/sword.png" alt="Obrázek populace" loading="lazy" />
            </figure>
            <Button timeDelay={0} bgColor={gameOver ? "button--primary--red" : isWinner ? "button--primary--green" : "button--primary--blue"} onClick={handleShoot}>
              {isPlaying ? "Střílet" : "Hrát"}
            </Button>
          </>
        ) : null}
        {gameOver && (
          <div className="level-up-game-over__content">
            <div className="level-up-game-over__content-container">
              <p className="level-up-game-over__text">
                Prohrál jsi ztrácíš: <span>{upgradeCost}</span>
              </p>
              <figure className="level-up-game-over__img">
                <img className="img-responsive" src="images/content/sheep.png" alt="Obrázek ovce" loading="lazy" />
              </figure>
            </div>
            <Button onClick={() => initializeGame()} bgColor="button--primary--blue">
              Znovu
            </Button>
          </div>
        )}
      </div>
    </div>
  );
};
export default LevelUpGame;