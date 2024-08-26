import React from "react";
import { useState, useEffect } from "react";
import ringText from "/ring-text.png";
import timeFrame from "/time-frame.png";
import "./LotrCardLocked.css";

function LotrCardLocked({ cardData }) {
  const [showTrivia, setShowTrivia] = useState(false);
  return (
    <>
      <div
        className="card-container card-locked"
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
              <p className="trivia-text">{`Did you know? ${cardData.trivia}`}</p>
            )}
          </div>
        </div>
      </div>
    </>
  );
}

export default LotrCardLocked;
