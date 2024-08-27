import "./PlayerModal.css";
import React from "react";
import ringText from "/ring-text.png";
import ringText2 from "/ring-text-2.png";
import ringText3 from "/ring-text-3.png";
import { useState } from "react";
function PlayerModal({ isOpen, closeModal, setPlayer }) {
  if (!isOpen) return null; // Modal visas bara när isOpen är true

  const [userName, setUserName] = useState("");
  const [avatar, setAvatar] = useState("");

  const avatars = [ringText, ringText2, ringText3];

  const handleSubmit = (e) => {
    e.preventDefault();
    setPlayer(userName, avatar);
    closeModal();
  };

  return (
    <div className="modal-overlay" onClick={closeModal}>
      <div className="modal-content" onClick={(e) => e.stopPropagation()}>
        <form onSubmit={handleSubmit}>
          <div>
            <h1>Choose your name:</h1>
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
            <h1>Choose your Avatar:</h1>
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
          <button type="submit">Save</button>
        </form>
        <button className="close-btn" onClick={closeModal}>
          Close
        </button>
      </div>
    </div>
  );
}

export default PlayerModal;
