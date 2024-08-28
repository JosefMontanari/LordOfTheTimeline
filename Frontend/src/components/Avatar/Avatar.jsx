import React from "react";
import "./Avatar.css";
import useLocalStorage from "../../hooks/useLocalStorage";

function Avatar({ handleOpenModal }) {
  const { getLocalStorage } = useLocalStorage();
  const player = getLocalStorage("player");

  return (
    <div
      className="Avatar-container"
      onClick={() => handleOpenModal("playerModal")}
    >
      <p>
        <span>{player?.userName || "Guest"}</span>
      </p>
      <img
        className="Avatar-img"
        src={player?.avatar || "default-avatar.png"}
        alt="Player Avatar"
      />
    </div>
  );
}

export default Avatar;
