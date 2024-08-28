import React from "react";
import { useState, useEffect } from "react";
import ringText from "/ring-text.png";
import timeFrame from "/time-frame.png";

import "./LotrCardConfirmed.css";

function LotrCardConfirmed({ cardData, isRemoving }) {
  const [showTrivia, setShowTrivia] = useState(false);
  const [age, setAge] = useState("");
  const [dateString, setDateString] = useState(
    `${cardData.year}/${cardData.month}/${cardData.day}`
  );

  useEffect(() => {
    if (cardData.month === null) {
      setDateString(cardData.year);
    }
    switch (cardData.age) {
      case 0:
        return setAge("B.D");
      case 10000:
        return setAge("Y.T");
      case 20000:
        return setAge("F.A");
      case 30000:
        return setAge("S.A");
      case 40000:
        return setAge("T.A");
      case 50000:
        return setAge("Fo.A");
    }

    console.log("Sätter switch");
  }, []);
  return (
    <>
      <div
        className={`card-container ${
          cardData.isCorrect ? "card-correct" : "card-incorrect"
        } ${isRemoving ? "removing" : ""}`}
        onClick={() => setShowTrivia(!showTrivia)}
      >
        <div className="date-container">
          <img src={timeFrame} alt="" className="time-frame" />
          <p className="date-text">
            {age}: {dateString}
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
