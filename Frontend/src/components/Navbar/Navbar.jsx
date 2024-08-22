import React from "react";
import "./Navbar.css";
import { Link } from "react-router-dom";

function Navbar() {
  return (
    <div className="navbar">
      <div>
        <Link className="" to={"/"}>
          <h3 className="navbar-link lotr-font">Home</h3>
        </Link>
      </div>
      <div>
        <h3 className="navbar-link lotr-font how-to-play">How to play</h3>
      </div>
      <div>
        <h3 className="navbar-link lotr-font">High Score</h3>
      </div>
    </div>
  );
}

export default Navbar;
