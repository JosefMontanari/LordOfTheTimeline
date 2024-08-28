import React from "react";
import "./HighScore.css";
import timeFrame from "/time-frame.png";

function HighScore({ handleCloseModal }) {
  return (
    <div className="highscore-modal-overlay" onClick={handleCloseModal}>
      <div
        className="highscore-modal-content"
        onClick={(e) => e.stopPropagation()}
      >
        <h1 className="title">High Score</h1>
        <img src={timeFrame} alt="" className="frame" />
        <div className="high-score">
          <h2 className="h2-title">YOUR HIGHSCORE IS</h2>
          <p className="p-highscore">Number</p>
          <p className="p-highscore">Points</p>
        </div>
        <button className="close-btn" onClick={handleCloseModal}>
          Close
        </button>
      </div>
    </div>
  );
}

export default HighScore;
