import React, { useState } from "react";
import "./Navbar.css";
import { Link } from "react-router-dom";
import HowtoPlay from "../../Modals/HowtoPlayModal/HowtoPlay";

function Navbar() {
  const [isModalOpen, setIsModalOpen] = useState(false);

  const openModal = () => setIsModalOpen(true);
  const closeModal = () => setIsModalOpen(false);
  return (
    <div className="navbar">
      <div>
        <Link className="" to={"/"}>
          <h3 className="navbar-link lotr-font">Home</h3>
        </Link>
      </div>
      <div>
        <h3 className="navbar-link lotr-font how-to-play" onClick={openModal}>
          How to play
        </h3>
      </div>
      <div>
        <h3 className="navbar-link lotr-font">High Score</h3>
      </div>
      <HowtoPlay isOpen={isModalOpen} closeModal={closeModal} />
    </div>
  );
}

export default Navbar;
