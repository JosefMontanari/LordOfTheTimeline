import React from "react";
import { useState, useEffect } from "react";
import ringText from "/ring-text.png";
import timeFrame from "/time-frame.png";

import "./LotrCardConfirmed.css";

function LotrCardConfirmed({ cardData }) {
  const [showTrivia, setShowTrivia] = useState(false);
  return (
    <>
      <div
        className={`card-container card-locked ${
          cardData.isCorrect ? "card-correct" : "card-incorrect"
        }`}
        onClick={() => setShowTrivia(!showTrivia)}
      >
        <div className="date-container">
          <img src={timeFrame} alt="" className="time-frame" />
          <p className="date-text">
            {cardData.year}/{cardData.month}/{cardData.day}
          </p>
        </div>
        <div className="card-body ">
          <img src={ringText} alt="" className="card-image-locked" />
          <div className="card-text-locked">
            {!showTrivia ? (
              <p>{cardData.question}</p>
            ) : (
              <div className="trivia-text-container">
                <p className="trivia-text">Did you know?</p>
                <p className="trivia-text">{cardData.trivia}</p>
              </div>
            )}
          </div>
        </div>
      </div>
    </>
  );
}

export default LotrCardConfirmed;
