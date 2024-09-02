import React, { useState } from "react";
import "./Navbar.css";
import { Link } from "react-router-dom";
import HowtoPlay from "../../Modals/HowtoPlayModal/HowtoPlay";
import HighScore from "../../Modals/HighScoreModal/HighScore";

function Navbar({ openModal, handleOpenModal, handleCloseModal }) {
  return (
    <div className="navbar">
      <div>
        <Link className="" to={"/"}>
          <h3 className="navbar-link lotr-font">Home</h3>
        </Link>
      </div>
      <div>
        <h3
          className="navbar-link lotr-font how-to-play"
          onClick={() => handleOpenModal("howToPlay")}
        >
          How to play
        </h3>
      </div>
      <div>
        <h3
          className="navbar-link lotr-font high-score"
          onClick={() => handleOpenModal("highScore")}
        >
          High Score
        </h3>
      </div>
      {openModal === "howToPlay" && (
        <HowtoPlay handleCloseModal={handleCloseModal} />
      )}
      {openModal === "highScore" && (
        <HighScore handleCloseModal={handleCloseModal} />
      )}
    </div>
  );
}

export default Navbar;
