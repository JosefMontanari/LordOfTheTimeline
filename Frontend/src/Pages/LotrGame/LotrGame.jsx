import React from "react";
import "./LotrGame.css";

function LotrGame() {
  return (
    <div className="lotr-game-page">
      <div className="background-image-game">
        <div className="background-image-ring"></div>
      </div>
      <h1 className="lotr-font game-title">Lord of The Timeline</h1>
      <div className="lotr-timeline">
        <img src="public\lotr-text-line.png" alt="" />
      </div>
      <div className="arrows">
        <div>
          <img src="public\arrow.png" className="arrow-left" alt="" />
        </div>
        <div>
          <img src="public\arrow-dot.png" className="arrow-dot" alt="" />
        </div>
        <div>
          <img src="public\arrow.png" className="arrow-right" alt="" />
        </div>
      </div>
    </div>
  );
}

export default LotrGame;
