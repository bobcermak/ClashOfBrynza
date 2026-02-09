import { useContext } from "react";
import { AudioContext } from "../context/AudioContext";

export const useAudio = () => {
  const context = useContext(AudioContext);
  if (!context) {
    throw new Error('useAudio has to be used within AudioProvider');
  }
  return context;
};