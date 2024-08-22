import React from "react";
import LotrCardPlayable from "../../components/LotrCardPlayable/LotrCardPlayable";
import LotrCardLocked from "../../components/LotrCardLocked/LotrCardLocked";
import { useState } from "react";
import "./LotrGame.css";
import LotrGameBackground from "../../components/LotrGameBackground/LotrGameBackground";
import LotrGameTimeline from "../../components/LotrGameTimeline/LotrGameTimeline";
import GameArrows from "../../components/GameArrows/GameArrows";

function LotrGame() {
  // För att passa om korten är rätt eller fel när de ändrar state
  const [cardIsCorrect, setCardIsCorrect] = useState();
  function handleLeftArrowClick() {
    console.log("left clicked");
  }

  function handleRightArrowClick() {
    console.log("Right clicked!");
  }
  return (
    <div className="lotr-game-page">
      <LotrGameBackground />
      <LotrGameTimeline />
      <GameArrows
        clickLeft={() => handleLeftArrowClick()}
        clickRight={handleRightArrowClick}
      />
    </div>
  );
}

export default LotrGame;
