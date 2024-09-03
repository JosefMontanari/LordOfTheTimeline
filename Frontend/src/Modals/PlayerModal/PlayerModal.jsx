import "./PlayerModal.css";
import React from "react";
import gandalf from "/Gandalf-avatar.png";
import frodo from "/Frodo-avatar.png";
import galadriel from "/Galadriel-avatar.png";
import gollum from "/Gollum-avatar.png";
import legolas from "/Legolas-avatar.png";
import orc from "/Orc-avatar.png";
import useLocalStorage from "../../hooks/useLocalStorage";

import { useState } from "react";
function PlayerModal({ handleCloseModal, setPlayer }) {
  const { getLocalStorage } = useLocalStorage();
  const player = getLocalStorage("player");

  const [userName, setUserName] = useState(() => {
    if (player != null) {
      return player.userName;
    }
    return "";
  });
  const [avatar, setAvatar] = useState(() => {
    if (player != null) {
      return player.avatar;
    }
    return "";
  });

  const avatars = [gandalf, frodo, galadriel, gollum, legolas, orc];

  const handleSubmit = (e) => {
    e.preventDefault();
    setPlayer(userName, avatar);
    handleCloseModal();
  };

  // Fixa så att korten inte överlappar med player-modalen
  // Avatar-komponent så att vi kan slänga in den på hemsidan så att den syns någonstans, username också kanske?
  // Styla Player-modalen

  return (
    <div className="player-modal-overlay" onClick={() => handleCloseModal()}>
      <div
        className="player-modal-content"
        onClick={(e) => e.stopPropagation()}
      >
        <form onSubmit={handleSubmit}>
          <div>
            <h1 className="player-modal-title">Choose your name:</h1>
            <label>
              Username:
              <input
                type="text"
                value={userName}
                onChange={(e) => setUserName(e.target.value)}
                required
              />
            </label>
          </div>
          <div>
            <h1 className="player-modal-title">Choose your Avatar:</h1>
            <div className="avatar-selection">
              {avatars.map((avatarOption, index) => (
                <img
                  key={index}
                  src={avatarOption}
                  alt={`Avatar ${index + 1}`}
                  //If the current avatar (avatarOption) matches the selected avatar, the selected class is added to highlight the selected avatar.
                  className={`avatar-option ${
                    avatar === avatarOption ? "selected" : ""
                  }`}
                  onClick={() => setAvatar(avatarOption)}
                />
              ))}
            </div>
          </div>
          <button className="save-btn" type="submit">
            Save
          </button>
        </form>
        <button className="close-btn" onClick={() => handleCloseModal()}>
          Close
        </button>
      </div>
    </div>
  );
}

export default PlayerModal;
