import React from "react";
import "./MultiplayerAvatar.css";

function MultiplayerAvatars({ allPlayers, currentPlayerId }) {
  return (
    <div className="multiplayer-avatars-container">
      {allPlayers.map((player) => (
        <div key={player.id} className="Avatar-container">
          <p>
            <span>{player.name || "Guest"}</span>
          </p>
          <img
            className="Avatar-img"
            src={player.avatar || "default-avatar.png"}
            alt={player.name}
            style={{
              border:
                player.id === currentPlayerId
                  ? `3px solid ${player.colour}`
                  : "#ffa800",
            }}
          />
          <p>{player.thisPlayersCards.length}</p>
        </div>
      ))}
    </div>
  );
}

export default MultiplayerAvatars;
