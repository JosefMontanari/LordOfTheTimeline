import React from "react";
import "./NextPlayerModal.css";

function NextPlayerModal({ handleCloseModal, player }) {
  return (
    <div className="next-player-modal-overlay" onClick={handleCloseModal}>
      <div className="next-player-modal-content">
        <h3 className="next-player-username">{player.userName}</h3>
        <img src={player.avatar} alt="" className="next-player-avatar" />
        <div className="next-player-text-wrapper">
          <h3 className="next-player-text">You're Next!</h3>
          <p className="next-player-p">Click anywhere to continue</p>
        </div>
      </div>
    </div>
  );
}

export default NextPlayerModal;
