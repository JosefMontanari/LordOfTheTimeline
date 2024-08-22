import React from "react";
import "./Home.css";
import ringText from "/ring-text.png";
import { Link } from "react-router-dom";

function Home() {
  return (
    <div className="home-page">
      <div className="background-image"></div>
      <h1 className="lotr-font main-title">Lord of The Timeline</h1>
      <div className="play-game-container">
        <img src={ringText} alt="" className="rotate play-ring" />

        <Link className="play-button">
          <p>PLAY GAME</p>
        </Link>
      </div>
    </div>
  );
}

export default Home;
