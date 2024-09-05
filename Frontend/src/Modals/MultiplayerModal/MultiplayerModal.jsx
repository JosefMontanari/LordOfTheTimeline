import React, { useState } from "react";
import "./MultiplayerModal.css";
import gandalf from "/Gandalf-avatar.png";
import frodo from "/Frodo-avatar.png";
import galadriel from "/Galadriel-avatar.png";
import gollum from "/Gollum-avatar.png";
import legolas from "/Legolas-avatar.png";
import orc from "/Orc-avatar.png";

const MultiplayerModal = ({ handleCloseModal }) => {
  const [numberOfPlayers, setNumberOfPlayers] = useState(2);
  const [players, setPlayers] = useState([]);
  const [numberOfPlayersChosen, setNumberOfPlayersChosen] = useState(false);
  const [playerNumber, setPlayerNumber] = useState(1);

  //   const [userName, setUserName] = useState(() => {
  //     if (player != null) {
  //       return player.userName;
  //     }
  //     return "";
  //   });
  const [avatar, setAvatar] = useState("");

  const avatars = [gandalf, frodo, galadriel, gollum, legolas, orc];

  const handleSubmit = (e) => {
    e.preventDefault();

    console.log("playerNumber", playerNumber);
    console.log("numberOfPlayers", numberOfPlayers);

    if (playerNumber >= numberOfPlayers) {
      console.log("Nu är de samma!");
      handleCloseModal();
    }

    setPlayerNumber(playerNumber + 1);
  };

  function handleSaveNumberOfPlayers() {
    setNumberOfPlayersChosen(true);
    console.log(numberOfPlayers);
  }

  return (
    <div className="multiplayer-modal">
      <div className="player-modal-overlay">
        <div
          className="player-modal-content"
          onClick={(e) => e.stopPropagation()}
        >
          {!numberOfPlayersChosen ? (
            <>
              <h2>Choose Number of players</h2>
              <select
                value={numberOfPlayers}
                className="player-count-dropdown"
                onChange={(e) => setNumberOfPlayers(e.target.value)}
              >
                <option value={2}>2 Players</option>
                <option value={3}>3 Players</option>
                <option value={4}>4 Players</option>
              </select>
              <button
                className="save-btn"
                onClick={() => handleSaveNumberOfPlayers()}
              >
                Save
              </button>
            </>
          ) : (
            <>
              <form onSubmit={handleSubmit}>
                <div>
                  <h1>{`Player ${playerNumber}`}</h1>
                  <h1 className="player-modal-title">Choose your name:</h1>
                  <label>
                    <input
                      type="text"
                      //   value={userName}
                      //onChange={(e) => setUserName(e.target.value)}
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
            </>
          )}
        </div>
      </div>
    </div>
  );
};

export default MultiplayerModal;
