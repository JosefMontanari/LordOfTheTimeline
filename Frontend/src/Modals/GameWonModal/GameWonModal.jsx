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
            <p>
              Your points this round:{" "}
              <s>{localStorage.getItem("totalPoints")}</s>
            </p>
            <br />
            <p>
              Your highscore: <s>{player.highScore}</s>
            </p>
            <br />
            {parseInt(localStorage.getItem("totalPoints")) >=
            parseInt(player.highScore) ? (
              <p>You beat your highscore!</p>
            ) : (
              <></>
            )}
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
