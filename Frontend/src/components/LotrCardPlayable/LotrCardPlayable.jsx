import React from "react";
import { useState, useEffect } from "react";
import "./LotrCardPlayable.css";
import ringText from "/ring-text.png";
import timeFrame from "/time-frame.png";

function LotrCardPlayable({ cardData, isAdding, addingCardId }) {
  const [card, setCard] = useState({});

  return (
    <div
      className={`card-container card-playable ${isAdding ? "adding" : ""} ${
        !isAdding && addingCardId ? "adding-added" : ""
      }`}
    >
      <div className="date-container">
        <img src={timeFrame} alt="" className="time-frame" />
      </div>

      <div className="card-body ">
        <img src={ringText} alt="" className="card-image" />
        <div className="card-text-playable">
          <p>{cardData.question}</p>
        </div>
      </div>
    </div>
  );
}

export default LotrCardPlayable;
