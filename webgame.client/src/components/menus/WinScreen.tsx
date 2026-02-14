import { type FC, useRef, useState } from "react";
import { useGSAP } from "@gsap/react";
import gsap from "gsap";
import Button from "../buttons/Button";
import { containsBadWord } from "../../../lib/helpers/badWords";

type WinScreenProps = {
  onRestart: () => void;
  onHome: () => void;
  playerId: string;
};

const WinScreen: FC<WinScreenProps> = ({ onRestart, onHome, playerId }) => {
  //Hooks
  const containerRef = useRef<HTMLDivElement>(null);
  const contentRef = useRef<HTMLDivElement>(null);
  const [nickname, setNickname] = useState<string>("");
  const [submitted, setSubmitted] = useState<boolean>(false);
  const [error, setError] = useState<string | null>(null);
  const [submitting, setSubmitting] = useState<boolean>(false);

  useGSAP(
    () => {
      const tl = gsap.timeline();
      tl.to(containerRef.current, { opacity: 1, duration: 2, ease: "power2.easeInOut" }).from(contentRef.current, { scale: 0.8, opacity: 0, duration: 1, ease: "back.out(1.7)" }, "-=1");
    },
    { scope: containerRef },
  );
  const handleSubmit = async () => {
    setError(null);
    const trimmed = nickname.trim();
    if (trimmed.length < 2 || trimmed.length > 16) {
      setError("Přezdívka musí mít 2–16 znaků.");
      return;
    }
    if (containsBadWord(trimmed)) {
      setError("Přezdívka obsahuje nevhodné slovo.");
      return;
    }
    setSubmitting(true);
    try {
      const res = await fetch("/api/game/leaderboard", {
        method: "POST",
        headers: { "Content-Type": "application/json" },
        body: JSON.stringify({ nickname: trimmed, playerId }),
      });
      if (res.ok) {
        setSubmitted(true);
      } else {
        const text = await res.text();
        setError(text || "Nepodařilo se uložit skóre.");
      }
    } catch {
      setError("Chyba při odesílání.");
    } finally {
      setSubmitting(false);
    }
  };
  return (
    <div className="win-screen" ref={containerRef}>
      <div className="win-screen__content" ref={contentRef}>
        <h1 className="win-screen__title">Vítězství!</h1>
        <h2 className="win-screen__subtitle">Tvoje vesnice dosáhla úrovně 10!</h2>
        {!submitted ? (
          <div className="win-screen__nickname">
            <p className="win-screen__nickname-label">Zadej přezdívku pro žebříček:</p>
            <p className="win-screen__nickname-label--small">(Nepovinné - můžeš kliknout na tlačítko <b>"Domů"</b> a vrátit se na hlavní stránku)</p>
            <input
              id="nickname"
              name="nickname"
              className="win-screen__nickname-input"
              type="text"
              maxLength={16}
              placeholder="Tvoje přezdívka:"
              value={nickname}
              onChange={(e) => {
                setNickname(e.target.value);
                setError(null);
              }}
            />
            {error && <p className="win-screen__nickname-error">{error}</p>}
          </div>
        ) : (
          <p className="win-screen__nickname-success">✅ Skóre uloženo!</p>
        )}
        <div className="win-screen__buttons">
          <Button bgColor="button--primary--red" onClick={onHome}>
            Domů
          </Button>
          {!submitted ? (
            <Button bgColor="button--primary--blue" onClick={handleSubmit} className="win-screen__nickname-submit">
              {submitting ? "Ukládám..." : "Uložit"}
            </Button>
          ) : (
            <Button bgColor="button--primary--blue" onClick={onRestart}>
              Nová hra
            </Button>
          )}
        </div>
      </div>
    </div>
  );
};
export default WinScreen;