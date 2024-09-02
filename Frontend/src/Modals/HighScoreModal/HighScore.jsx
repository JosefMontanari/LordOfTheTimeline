import React, { useState, useEffect } from "react";
import "./HighScore.css";
import timeFrame from "/time-frame.png";
import useLocalStorage from "../../hooks/useLocalStorage";

function HighScore({ handleCloseModal }) {
  const { getLocalStorage } = useLocalStorage();
  const [highScores, setHighScores] = useState([]);

  useEffect(() => {
    let players = getLocalStorage("players");
    if (players !== null) {
      setHighScores(players);
    }
  }, []);

  return (
    <div className="highscore-modal-overlay" onClick={handleCloseModal}>
      <div
        className="highscore-modal-content"
        onClick={(e) => e.stopPropagation()}
      >
        <h1 className="title">High Score</h1>
        <img src={timeFrame} alt="" className="frame" />
        <div className="high-score">
          {highScores.length < 1 ? (
            <>
              <p className="p-highscore">Complete 10 cards to set highscore</p>
            </>
          ) : (
            <>
              {highScores.map((h, index) => (
                <>
                  <p className="p-highscore" key={index}>
                    {index + 1}. {h.userName}: {h.highScore}
                  </p>
                </>
              ))}
            </>
          )}
        </div>
        <button className="close-btn" onClick={handleCloseModal}>
          Close
        </button>
      </div>
    </div>
  );
}

export default HighScore;
