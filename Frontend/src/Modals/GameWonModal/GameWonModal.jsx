import React from "react";
import "./GameWonModal.css";
import useLocalStorage from "../../hooks/useLocalStorage";

function GameWonModal({ newGame, handleCloseModal }) {
  const { getLocalStorage } = useLocalStorage();
  const player = getLocalStorage("player") || {}; // Default till tomt object om null

  const highScore = player.highScore || 0;

  const totalPoints = parseInt(localStorage.getItem("totalPoints")) || 0;

  return (
    <>
      <div className="won-modal-overlay" onClick={handleCloseModal}>
        <div className="won-modal-content" onClick={(e) => e.stopPropagation()}>
          <div>
            <br />
            <p className="p-highscore-name-big">
              YOUR HIGHSCORE: <s>{highScore}</s>
            </p>
            <br />
            {totalPoints >= highScore ? (
              <p className="p-highscore-beat">You beat your highscore!</p>
            ) : null}
            <p className="p-won-game-points">
              Your points this round:{" "}
              <s className="s-won-game-points">{totalPoints}</s>
            </p>
            <br />
            <button className="button" onClick={() => newGame()}>
              New game
            </button>
          </div>
        </div>
      </div>
    </>
  );
}

export default GameWonModal;
