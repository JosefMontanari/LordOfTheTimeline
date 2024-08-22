import React from "react";
import LotrCardPlayable from "../../components/LotrCardPlayable/LotrCardPlayable";
import LotrCardLocked from "../../components/LotrCardLocked/LotrCardLocked";
import { useState } from "react";
import "./LotrGame.css";

function LotrGame() {
  // För att passa om korten är rätt eller fel när de ändrar state
  const [cardIsCorrect, setCardIsCorrect] = useState();
  return (
    <div>
    </div>
  );
}

export default LotrGame;
