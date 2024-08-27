import React, { useState } from "react";
import "./Navbar.css";
import { Link } from "react-router-dom";
import HowtoPlay from "../../Modals/HowtoPlayModal/HowtoPlay";

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
        <h3 className="navbar-link lotr-font">High Score</h3>
      </div>
      {openModal === "howToPlay" && (
        <HowtoPlay handleCloseModal={handleCloseModal} />
      )}
    </div>
  );
}

export default Navbar;
