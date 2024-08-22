import React from "react";

function GameArrows({ clickLeft, clickRight }) {
  return (
    <div className="arrows">
      <div>
        <img
          src="arrow.png"
          className="arrow-left"
          alt=""
          onClick={() => clickLeft()}
        />
      </div>
      <div>
        <img src="arrow-dot.png" className="arrow-dot" alt="" />
      </div>
      <div>
        <img
          src="arrow.png"
          className="arrow-right"
          alt=""
          onClick={() => clickRight()}
        />
      </div>
    </div>
  );
}

export default GameArrows;
