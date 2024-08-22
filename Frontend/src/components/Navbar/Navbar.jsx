import React from "react";
import "./Navbar.css";

function Navbar() {
  return (
    <div className="navbar">
      <div>
        <h3 className="navbar-link lotr-font">Home</h3>
      </div>
      <div>
        <h3 className="navbar-link lotr-font">How to play</h3>
      </div>
      <div>
        <h3 className="navbar-link lotr-font">High Score</h3>
      </div>
    </div>
  );
}

export default Navbar;
