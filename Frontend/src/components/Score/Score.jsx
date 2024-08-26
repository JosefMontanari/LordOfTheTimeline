import React from "react";
import "./Score.css";
import useLocalStorage from "../../hooks/useLocalStorage";

function Score({ points, highScore }) {
  return (
    <>
      <div className="score-container lotr-font">
        <p>
          points: <span>{points}</span>
        </p>
        <p>
          highscore: <span>{highScore}</span>
        </p>
      </div>
    </>
  );
}

export default Score;
