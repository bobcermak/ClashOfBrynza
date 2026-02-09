import { Suspense, useState } from 'react';
import { BrowserRouter, Routes, Route } from 'react-router-dom';
import { ErrorBoundary } from 'react-error-boundary';
import Menu from './pages/Menu';
import Game from './pages/Game';
import Intro from './pages/Intro';
import "./styles/global.css";
import { Button } from './components';
import { groundMapPromise, buildingsPromise } from "../lib/mapUtils";
import { createGamePromises, playerIdPromise, existingGameStatePromise, gameStatePromise } from "../lib/gameUtils";
import AudioProvider from './context/AudioContext';

const App = () => {
  //Hooks
  const [gamePromises, setGamePromises] = useState({ playerIdPromise, existingGameStatePromise, gameStatePromise });

  const handlePlayerIdChange = (newId: string): void => {
    setGamePromises(createGamePromises(newId));
  };
  return (
    <BrowserRouter>
      <ErrorBoundary fallback={<div className="error-fallback"><p className="error-fallback__banner">❌ Hra se nenačetla. ❌</p><div className="error-fallback__buttons"><Button bgColor="button--primary--blue" onClick={() => window.location.href = "/menu"} className="error-fallback__button">Domů</Button><Button bgColor="button--primary--red" onClick={() => window.location.reload()} className="error-fallback__button">Znovu</Button></div></div>}>
        <AudioProvider>
          <Suspense fallback={<p className="loading">Načítání...</p>}>
            <Routes>
              <Route path="/" element={<Intro/>} />
              <Route path="/menu" element={<Menu gameStatePromise={gamePromises.existingGameStatePromise} playerIdPromise={gamePromises.playerIdPromise} onPlayerIdChange={handlePlayerIdChange}/>}/>
              <Route path="/game" element={<Game groundMapPromise={groundMapPromise} buildingsPromise={buildingsPromise} gameStatePromise={gamePromises.gameStatePromise}/>}/>
            </Routes>
          </Suspense>
        </AudioProvider>
      </ErrorBoundary>
    </BrowserRouter>
  );
};
export default App;