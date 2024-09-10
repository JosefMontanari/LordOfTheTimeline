import React, { useEffect, useState } from "react";
import "./GameWonMPModal.css";

function GameWonMPModal({ handleCloseModal, NewGame, player, allPlayers }) {
  const [sortedAllPlayers, setSortedAllPlayers] = useState([]);
  useEffect(() => {
    let filteredPlayers = [...allPlayers];
    console.log("Innan sort", filteredPlayers);

    filteredPlayers.sort(
      (a, b) => b.thisPlayersCards.length - a.thisPlayersCards.length
    );

    console.log("Efter sort", filteredPlayers);
    setSortedAllPlayers(filteredPlayers);
  }, []);

  return (
    <div className="mp-won-modal-overlay" onClick={handleCloseModal}>
      <div
        className="mp-won-modal-content"
        onClick={(e) => e.stopPropagation()}
      >
        <p className="mp-winner">{`Winner ${player.userName}`}</p>
        <div className="mp-placements-wrapper">
          {sortedAllPlayers.map((p, index) => (
            <>
              <div key={index} className="mp-placements">
                <div className="mp-placements-name">{p.userName}: </div>
                <div className="mp-placements-points">
                  {p.thisPlayersCards.length}{" "}
                  {p.thisPlayersCards.length > 1 ? "cards" : "card"}
                </div>
              </div>
            </>
          ))}
        </div>

        <button className="button" onClick={() => NewGame()}>
          New game
        </button>
      </div>
    </div>
  );
}

export default GameWonMPModal;
