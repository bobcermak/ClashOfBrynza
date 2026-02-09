import { useAudio } from "../../hooks/useAudio";
import { useGSAP } from "@gsap/react";
import gsap from "gsap";
import { useRef } from "react";

const MusicButton = () => {
    //Hooks
    const { isPlaying, toggleMusic, playSFX } = useAudio();
    const buttonRef = useRef<HTMLButtonElement>(null);

    const handleClick = () => {
        playSFX("/audios/button-click.mp3");
        gsap.to(buttonRef.current, {
            scale: 0.8,
            duration: 0.1,
            yoyo: true,
            repeat: 1,
            ease: "power1.inOut",
            onComplete: () => {
                setTimeout(() => {
                    toggleMusic();
                }, 100);
            }
        });
    };
    useGSAP(() => {
        if (isPlaying) {
            gsap.to(buttonRef.current, {
                opacity: 1,
                duration: 0.5,
                ease: "power2.easeInOut"
            });
        } else {
            gsap.to(buttonRef.current, {
                opacity: 0.5,
                duration: 0.5,
                ease: "power2.easeInOut"
            });
        }
    }, [isPlaying]);
    return (
        <button className={isPlaying ? "music-button" : "music-button-muted"} onClick={handleClick}>
            <img className="img-responsive" src="/images/content/music.png" alt="Hudba" loading="lazy"/>
        </button>
    );
};
export default MusicButton;