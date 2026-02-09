import { type FC, useRef } from "react";
import { useNavigate } from "react-router-dom";
import { useGSAP } from "@gsap/react";
import gsap from "gsap";
import { useAudio } from "../hooks/useAudio";

const Intro: FC = () => {
    //Hooks
    const navigate = useNavigate();
    const { playBackgroundMusic, isPlaying } = useAudio();
    const containerRef = useRef<HTMLDivElement>(null);
    const titleRef = useRef<HTMLHeadingElement>(null);
    const sheepLeftRef = useRef<HTMLDivElement>(null);
    const sheepRightRef = useRef<HTMLDivElement>(null);
    const textRef = useRef<HTMLParagraphElement>(null);
    const { contextSafe } = useGSAP(() => {
        const tl = gsap.timeline();
        gsap.set(titleRef.current, { scale: 0.5, opacity: 0 });
        gsap.set(sheepLeftRef.current, { x: -100, opacity: 0, rotation: -45 });
        gsap.set(sheepRightRef.current, { x: 100, opacity: 0, rotation: 45 });
        gsap.set(textRef.current, { opacity: 0, y: 20 });
        tl.to(titleRef.current, {
            scale: 1,
            opacity: 1,
            duration: 1.2,
            ease: "back.out(1.7)"
        })
        .to(sheepLeftRef.current, {
            x: 0,
            opacity: 1,
            rotation: 0,
            duration: 0.8,
            ease: "power2.easeInOut"
        }, "-=0.8")
        .to(sheepRightRef.current, {
            x: 0,
            opacity: 1,
            rotation: 0,
            duration: 0.8,
            ease: "power2.easeInOut"
        }, "<")
        .to(textRef.current, {
            opacity: 1,
            y: 0,
            duration: 0.5,
            ease: "power2.easeInOut"
        }, "-=0.2");
        gsap.to(textRef.current, {
            scale: 1.05,
            duration: 0.8,
            repeat: -1,
            yoyo: true,
            ease: "power1.easeInOut"
        });

    }, { scope: containerRef });
    const handleContinue = contextSafe(() => {
        if (!containerRef.current) return;
        if (isPlaying) playBackgroundMusic("/audios/menu-soundtrack.mp3");
        gsap.to(containerRef.current, {
            opacity: 0,
            duration: 0.5,
            ease: "power2.easeInOut",
            onComplete: () => {
                navigate("/menu");
            }
        });
    });
    return (
        <div className="intro" ref={containerRef} onClick={handleContinue}>
            <div className="intro__container">
                <div className="intro__container-title">
                    <figure className="intro__container-title-figure" ref={sheepLeftRef}>
                        <img className="img-responsive" src="images/content/sheep.png" alt="Obrázek ovce"/>
                    </figure>
                    <h1 className="intro__container-title-text" ref={titleRef}>Clash Of Brynza</h1>
                    <figure className="intro__container-title-figure" ref={sheepRightRef}>
                        <img className="img-responsive" src="images/content/sheep.png" alt="Obrázek ovce"/>
                    </figure>
                </div>
                <p className="intro__container-text" ref={textRef}>Klikni pro pokračování</p>
            </div>
        </div>
    );
};
export default Intro;