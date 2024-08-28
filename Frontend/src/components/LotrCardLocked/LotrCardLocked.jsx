import React from "react";
import { useState, useEffect } from "react";
import ringText from "/ring-text.png";
import timeFrame from "/time-frame.png";
import "./LotrCardLocked.css";

function LotrCardLocked({ cardData }) {
  const [showTrivia, setShowTrivia] = useState(false);
  const [age, setAge] = useState("");
  const [dateString, setDateString] = useState(
    `${cardData.year}/${cardData.month}/${cardData.day}`
  );

  const flipStyle = {
    transform: `rotateY(180deg)`,
  };

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
  }, []);
  return (
    <>
      {!showTrivia ? (
        <div
          className="card-container card-locked card-front"
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
              <p>{cardData.question}</p>
            </div>
          </div>
        </div>
      ) : (
        <div
          className="card-container card-locked card-back"
          onClick={() => setShowTrivia(!showTrivia)}
        >
          <div className="date-container" style={flipStyle}>
            <img src={timeFrame} alt="" className="time-frame" />
            <p className="date-text">
              {age}: {dateString}
            </p>
          </div>
          <div className="card-body" style={flipStyle}>
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
      )}
    </>
  );
}

export default LotrCardLocked;
