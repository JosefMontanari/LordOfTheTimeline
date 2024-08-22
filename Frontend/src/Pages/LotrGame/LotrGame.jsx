import React from "react";
import "./LotrGame.css";
import LotrGameBackground from "../../components/LotrGameBackground/LotrGameBackground";
import LotrGameTimeline from "../../components/LotrGameTimeline/LotrGameTimeline";
import GameArrows from "../../components/GameArrows/GameArrows";

function LotrGame() {
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
