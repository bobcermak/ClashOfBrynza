import { type FC, useEffect, useState } from "react";
import type { LeaderboardEntry } from "../../../types/gameModels";

type LeaderboardProps = {
    onClose: () => void;
    playerId: string;
};
const Leaderboard: FC<LeaderboardProps> = ({ onClose, playerId }) => {
    //Hooks
    const [entries, setEntries] = useState<LeaderboardEntry[]>([]);
    const [loading, setLoading] = useState<boolean>(true);

    const formatTime = (seconds: number): string => {
        const h = Math.floor(seconds / 3600);
        const m = Math.floor((seconds % 3600) / 60).toString().padStart(2, "0");
        const s = (seconds % 60).toString().padStart(2, "0");
        return h > 0 ? `${h}:${m}:${s}` : `${m}:${s}`;
    };
    useEffect(() => {
        const fetchLeaderboard = async () => {
            try {
                const res = await fetch("/api/game/leaderboard");
                if (res.ok) {
                    const data = await res.json();
                    setEntries(data);
                }
            } catch {
                console.error("Failed to fetch leaderboard");
            } finally {
                setLoading(false);
            }
        };
        fetchLeaderboard();
    }, []);
    return (
        <div className="leaderboard">
            <div className="leaderboard__content">
                {loading ? (
                    <p className="leaderboard__loading">Načítání...</p>
                ) : entries.length === 0 ? (
                    <p className="leaderboard__empty" style={{marginTop: "12rem"}}>Zatím žádné záznamy.</p>
                ) : (
                    <div className={entries.length > 8 ? "leaderboard__scroll" : ""}>
                        <table className="leaderboard__table">
                            <thead>
                                <tr>
                                    <th>#</th>
                                    <th>Přezdívka</th>
                                    <th>Čas</th>
                                </tr>
                            </thead>
                            <tbody>
                                {entries.map((entry, index) => {
                                    const isPlayer = entry.playerId === playerId;
                                    const topClass = index < 3 ? `leaderboard__top-${index + 1}` : "";
                                    const playerClass = isPlayer ? "leaderboard__player" : "";
                                    return (
                                        <tr key={index} className={`${topClass} ${playerClass}`.trim()}>
                                            <td>{index + 1}.</td>
                                            <td>{entry.nickname}</td>
                                            <td>{formatTime(entry.timeInSeconds)}</td>
                                        </tr>
                                    );
                                })}
                            </tbody>
                        </table>
                    </div>
                )}
                <button className="menu__container-nav-menu-item-button leaderboard__back-button" onClick={onClose}>Zpět</button>
            </div>
        </div>
    );
};
export default Leaderboard;