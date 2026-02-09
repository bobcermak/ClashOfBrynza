import { createContext, useContext, useState, type ReactNode } from "react";

type DebugContextType = {
  debugMode: boolean;
  setDebugMode: (value: boolean) => void;
  toggleDebugMode: () => void;
};

const DebugContext = createContext<DebugContextType | undefined>(undefined);

export const DebugProvider: React.FC<{ children: ReactNode }> = ({ children }) => {
  const [debugMode, setDebugMode] = useState(false);

  const toggleDebugMode = () => setDebugMode((prev) => !prev);

  return <DebugContext.Provider value={{ debugMode, setDebugMode, toggleDebugMode }}>{children}</DebugContext.Provider>;
};

export const useDebugMode = (): DebugContextType => {
  const context = useContext(DebugContext);
  if (context === undefined) {
    throw new Error("useDebugMode must be used within a DebugProvider");
  }
  return context;
};