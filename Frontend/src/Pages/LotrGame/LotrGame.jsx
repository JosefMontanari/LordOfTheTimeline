import React, { useState, useEffect } from "react";
import LotrCardPlayable from "../../components/LotrCardPlayable/LotrCardPlayable";
import LotrCardConfirmed from "../../components/LotrCardConfirmed/LotrCardConfirmed";
import "./LotrGame.css";
import LotrGameBackground from "../../components/LotrGameBackground/LotrGameBackground";
import LotrGameTimeline from "../../components/LotrGameTimeline/LotrGameTimeline";
import GameArrows from "../../components/GameArrows/GameArrows";
import useLocalStorage from "../../hooks/useLocalStorage";
import LotrCardLocked from "../../components/LotrCardLocked/LotrCardLocked";
import useLotrGameSetup from "../../hooks/useLotrGameSetup";
import useCardActions from "../../hooks/useCardActions";
import useArrowActions from "../../hooks/useArrowActions";
import PlayerModal from "../../Modals/PlayerModal/PlayerModal";
import Score from "../../components/Score/Score";
import Avatar from "../../components/Avatar/Avatar";
import GameWonModal from "../../Modals/GameWonModal/GameWonModal";

function LotrGame({
  allCards,
  setAllCards,
  openModal,
  handleOpenModal,
  handleCloseModal,
}) {
  // Fyra olika states, placing card, new or lock, continue och won game
  const [playState, setPlayState] = useState("initial");
  const [removingCardsId, setRemovingCardsId] = useState([]);
  const [addingCardId, setAddingCardId] = useState(null);

  const [difficultySelected, setDifficultySelected] = useState(false);
  const [difficulty, setDifficulty] = useState("");

  const {
    setLocalStorage,
    setTotalPoints,
    setCardPoints,
    setStreakPoints,
    setPlayer,
  } = useLocalStorage();

  const {
    playerCards,
    setPlayerCards,
    currentCard,
    setCurrentCard,
    usedCards,
    setUsedCards,
  } = useLotrGameSetup(
    allCards,
    setAllCards,
    setLocalStorage,
    handleOpenModal,
    difficulty
  );

  const { NewCard, Confirm, points, LockInCards, Continue } = useCardActions(
    true,
    allCards,
    playerCards,
    setPlayerCards,
    currentCard,
    setCurrentCard,
    undefined,
    setPlayState,
    setCardPoints,
    setStreakPoints,
    setTotalPoints,
    setRemovingCardsId,
    setAddingCardId,
    handleOpenModal,
    usedCards,
    setUsedCards
  );

  const { HandleLeftArrowClick, HandleRightArrowClick } = useArrowActions(
    playState,
    playerCards,
    setPlayerCards,
    currentCard
  );

  function NewGame() {
    // Laddar om sidan för att starta om spelet
    window.location.reload();
  }

  const handleDifficultySelect = (difficulty) => {
    setDifficulty(difficulty);
    setDifficultySelected(true);
    setPlayState("new or lock");
  };

  return (
    <div className="lotr-game-page">
      {/* Lägg till modalen och kontrollera om den ska vara öppen */}
      {openModal === "playerModal" && (
        <PlayerModal
          setPlayer={setPlayer}
          handleCloseModal={handleCloseModal}
        />
      )}

      <LotrGameBackground title="lord of the timeline" />

      <div className="button-card-wrapper">
        {!difficultySelected ? (
          <div className="difficulty-container">
            <h1 className="choose-difficulty-text lotr-font">
              Choose Difficulty
            </h1>
            <div className="difficulty-buttons-container">
              <button
                className="button difficulty-button"
                onClick={() => handleDifficultySelect("easy")}
              >
                Normal
              </button>
              <button
                className="button difficulty-button"
                onClick={() => handleDifficultySelect("hard")}
              >
                Hard
              </button>
            </div>
          </div>
        ) : (
          <div className="cards-container">
            {playerCards.map((c) => {
              const isRemoving = removingCardsId.includes(c.id); // Kontrollera om kortet ska tas bort
              const isAdding = c.id === addingCardId;
              if (c.isCurrentlyPlaying === false) {
                if (c.isLockedIn === false) {
                  return (
                    <LotrCardConfirmed
                      cardData={c}
                      key={c.id}
                      isRemoving={isRemoving}
                    />
                  );
                } else {
                  return <LotrCardLocked cardData={c} key={c.id} />;
                }
              } else {
                return (
                  <LotrCardPlayable
                    cardData={c}
                    key={c.id}
                    isAdding={isAdding}
                    addingCardId={addingCardId}
                  />
                );
              }
            })}
          </div>
        )}
      </div>

      <LotrGameTimeline />
      <div className="bottom-row">
        <div className="score-player-container">
          <Score points={points} highScore={12000} />
          <Avatar handleOpenModal={handleOpenModal} />
        </div>
        <GameArrows
          clickLeft={() => HandleLeftArrowClick()}
          clickRight={() => HandleRightArrowClick()}
        />
        <div className="button-container">
          {playState === "placing card" ? (
            <button className="button" onClick={() => Confirm()}>
              Confirm
            </button>
          ) : (
            <></>
          )}
          {playState === "new or lock" ? (
            <>
              <button className="button" onClick={() => NewCard()}>
                New card
              </button>
              <button className="button" onClick={() => LockInCards()}>
                Lock in cards
              </button>
            </>
          ) : (
            <></>
          )}
          {playState === "won game" ? (
            <>
              {openModal === "gameWonModal" && (
                <GameWonModal
                  newGame={NewGame}
                  // setPlayer={setPlayer}
                  handleCloseModal={handleCloseModal}
                />
              )}
              <button className="button" onClick={() => NewGame()}>
                New game
              </button>
            </>
          ) : (
            <></>
          )}
          {playState === "continue" ? (
            <button className="button" onClick={() => Continue()}>
              New Card
            </button>
          ) : (
            <></>
          )}
        </div>
      </div>
    </div>
  );
}

export default LotrGame;
