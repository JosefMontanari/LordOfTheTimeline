import React from "react";
import { useState, useEffect } from "react";
import "./LotrCardPlayable.css";
import ringText from "/ring-text.png";

function LotrCardPlayable() {
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
    <div className="card-container card-playable">
      <div className="card-body ">
        <img
          src={ringText}
          alt=""
          className="card-image"
        />
        <div className="card-text-playable">
          <p>{card.question}</p>
        </div>
      </div>
    </div>
  );
}

export default LotrCardPlayable;
