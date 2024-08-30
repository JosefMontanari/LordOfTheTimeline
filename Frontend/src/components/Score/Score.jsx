import React from "react";
import "./Score.css";
import { useState, useEffect } from "react";
import useLocalStorage from "../../hooks/useLocalStorage";

function Score({ points }) {
  // Behövs bara om vi vill visa highScore
  // const { getHighScore } = useLocalStorage();
  // const [highScore, setHighScore] = useState(0);

  // useEffect(() => {
  //   setHighScore(getHighScore());
  // }, [getHighScore]);
  return (
    <>
      <div className="score-container lotr-font">
        <p>
          points: <span>{points}</span>
        </p>
        {/* <p>
          highscore: <span>{highScore}</span>
        </p> */}
      </div>
    </>
  );
}

export default Score;
