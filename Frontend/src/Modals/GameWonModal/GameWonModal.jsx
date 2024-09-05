import React, { useEffect } from "react";
import "./GameWonModal.css";
import useLocalStorage from "../../hooks/useLocalStorage";

function GameWonModal({ newGame, handleCloseModal }) {
  const { getLocalStorage } = useLocalStorage();
  const player = getLocalStorage("player");

  return (
    <>
      <div className="won-modal-overlay" onClick={handleCloseModal}>
        <div className="won-modal-content" onClick={(e) => e.stopPropagation()}>
          <div>
            <br />
            <p className="p-highscore-name-big">
              YOUR HIGHSCORE: <s>{player.highScore}</s>
            </p>
            <br />
            {parseInt(localStorage.getItem("totalPoints")) >=
            parseInt(player.highScore) ? (
              <p className="p-highscore-beat ">You beat your highscore!</p>
            ) : (
              <></>
            )}
            <p className="p-won-game-points">
              Your points this round:{" "}
              <s className="s-won-game-points">
                {localStorage.getItem("totalPoints")}
              </s>
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
