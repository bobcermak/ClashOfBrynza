import { type FC, useRef } from "react";
import { useGSAP } from "@gsap/react";
import gsap from "gsap";
import Button from "../buttons/Button";

type GameOverProps = {
    onRestart: () => void;
    onHome: () => void;
};
const GameOver: FC<GameOverProps> = ({ onRestart, onHome }) => {
    //Hooks
    const containerRef = useRef<HTMLDivElement>(null);
    const contentRef = useRef<HTMLDivElement>(null);

    useGSAP(() => {
        const tl = gsap.timeline();
        tl.to(containerRef.current, { opacity: 1, duration: 2, ease: "power2.easeInOut" })
            .from(contentRef.current, { scale: 0.8, opacity: 0, duration: 1, ease: "back.out(1.7)" }, "-=1");
    }, { scope: containerRef });
    return (
        <div className="game-over" ref={containerRef}>
            <div className="game-over__content" ref={contentRef}>
                <h1 className="game-over__title">Konec hry</h1>
                <h2 className="game-over__subtitle">Tvoje vesnice zemřela hlady</h2>
                <div className="game-over__buttons">
                    <Button bgColor="button--primary--red" onClick={onHome}>Domů</Button>
                    <Button bgColor="button--primary--blue" onClick={onRestart}>Nová hra</Button>
                </div>
            </div>
        </div>
    );
};
export default GameOver;