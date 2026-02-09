import { useState, useEffect } from "react";
import "./TutorialMonk.css";

interface TutorialStep {
  text: string;
}

// tohle by mělo být v db ale není čas :/
const steps: TutorialStep[] = [
  { text: "Vítej ve hře ClashOfBrynza, cizinče! Provedu tě základy." },
  { text: "Cílem hry je vybudovat mocnou vesnici a dosáhnout 10. úrovně radnice. Ale pozor, není to tak jednoduché!" },
  { text: "Vše se točí kolem ovcí. Jsou to peníze i jídlo. Bez ovcí nic nepostavíš a tví lidé zemřou hlady." },
  { text: "Každý dům zabírá místo. Méně místa = méně trávy = méně ovcí. Musíš balancovat mezi počtem lidí a prostorem pro ovce." },
  { text: "Když nastane hladomor, musíš jednat rychle! Zbourej několik domů, abys snížil populaci a uvolnil místo pro pastvu. To zachrání zbytek vesnice." },
  { text: "Tip mistra: Někdy je nutné zariskovat. Postav více domů, než uživíš, abys odemkl vylepšení radnice. Pak rychle bourej, než dojde jídlo!" },
];

interface TutorialMonkProps {
  onComplete?: () => void;
}

const TutorialMonk = ({ onComplete }: TutorialMonkProps) => {
  const [currentStep, setCurrentStep] = useState(0);
  const [isVisible, setIsVisible] = useState(false);

  useEffect(() => {
    const hasSeenTutorial = localStorage.getItem("tutorialCompleted");
    if (!hasSeenTutorial) {
      setIsVisible(true);
    }
  }, []);

  const handleNext = () => {
    if (currentStep < steps.length - 1) {
      setCurrentStep((prev) => prev + 1);
    } else {
      finishTutorial();
    }
  };

  const finishTutorial = () => {
    setIsVisible(false);
    localStorage.setItem("tutorialCompleted", "true");
    if (onComplete) onComplete();
  };

  if (!isVisible) return null;

  return (
    <div className="tutorial-monk">
      <img src="images/content/monk.png" alt="Tutorial Monk" className="tutorial-monk__image" />
      <div className="tutorial-monk__bubble">
        <p className="tutorial-monk__text">{steps[currentStep].text}</p>
        <div className="tutorial-monk__controls">
          <button className="tutorial-monk__btn tutorial-monk__btn--skip" onClick={finishTutorial}>
            Přeskočit
          </button>
          <button className="tutorial-monk__btn" onClick={handleNext}>
            {currentStep < steps.length - 1 ? "Další" : "Rozumím"}
          </button>
        </div>
      </div>
    </div>
  );
};

export default TutorialMonk;
