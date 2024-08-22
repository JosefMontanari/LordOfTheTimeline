import React from "react";
import { useState, useEffect } from "react";
import ringText from "/ring-text.png";
import timeFrame from "/time-frame.png";

import "./LotrCardLocked.css";

function LotrCardLocked({ CardIsCorrect }) {
  const [card, setCard] = useState({});
  useEffect(() => {
    const newCard = {
      id: 1,
      category: "Lord of The Rings",
      question:
        "When did Frodo wear wigs? Will he wear wigs? Has he worn wigs? Does he like wigs?",
      trivia: "Trivia about the question",
      wikiUrl: "Wiki Url",
      age: "Third age",
      difficulty: "Normal",
      year: 3019,
      month: 9,
      day: 2,
      timeValue: 43019.085,
      isLotrOrTheHobbit: true,
      isGreatHappening: true,
    };
    setCard(newCard);
  }, []);

  return (
    <>
      {CardIsCorrect ? (
        <div className="card-container card-locked card-correct">
          <div className="date-container">
            <img src={timeFrame} alt="" className="time-frame" />
            <p className="date-text">
              {card.year}/{card.month}/{card.day}
            </p>
          </div>
          <div className="card-body ">
            <img src={ringText} alt="" className="card-image-locked" />
            <div className="card-text-locked">
              <p>{card.question}</p>
            </div>
          </div>
        </div>
      ) : (
        <div className="card-container card-locked card-incorrect">
          <div className="date-container">
            <img src={timeFrame} alt="" className="time-frame" />
            <p className="date-text">
              {card.year}/{card.month}/{card.day}
            </p>
          </div>
          <div className="card-body ">
            <img src={ringText} alt="" className="card-image-locked" />
            <div className="card-text-locked">
              <p>{card.question}</p>
            </div>
          </div>
        </div>
      )}
    </>
  );
}

export default LotrCardLocked;
