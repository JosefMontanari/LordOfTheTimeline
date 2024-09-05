import React from "react";
import "./LotrGameBackground.css";
import { useLocation } from "react-router-dom";

function LotrGameBackground({ title }) {
  return (
    <>
      <div className="background-image-game">
        <div className="background-image-ring"></div>
      </div>
      <h1 className="lotr-font game-title">{title}</h1>
    </>
  );
}

export default LotrGameBackground;
