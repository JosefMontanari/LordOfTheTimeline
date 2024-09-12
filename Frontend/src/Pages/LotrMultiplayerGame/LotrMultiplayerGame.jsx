import LotrGameBackground from "../../components/LotrGameBackground/LotrGameBackground";
import "./LotrMultiplayerGame.css";
import LotrGameTimeline from "../../components/LotrGameTimeline/LotrGameTimeline";
import GameArrows from "../../components/GameArrows/GameArrows";
import useArrowActions from "../../hooks/useArrowActions";
import React, { useEffect, useState } from "react";
import useMultiPlayerGameSetup from "../../hooks/useMultiplayerGameSetup";
import LotrCardLocked from "../../components/LotrCardLocked/LotrCardLocked";
import LotrCardPlayable from "../../components/LotrCardPlayable/LotrCardPlayable";
import LotrCardConfirmed from "../../components/LotrCardConfirmed/LotrCardConfirmed";
import useCardActions from "../../hooks/useCardActions";
import MultiplayerModal from "../../Modals/MultiplayerModal/MultiplayerModal";
import MultiplayerAvatar from "../../components/MultiplayerAvatar/MultiplayerAvatar";
import GameWonMPModal from "../../Modals/GameWonMPModal/GameWonMPModal";
import NextPlayerModal from "../../Modals/NextPlayerModal/NextPlayerModal";

function LotrMultiplayerGame({
  allCards,
  setAllCards,
  openModal,
  handleOpenModal,
  handleCloseModal,
}) {
  const [currentPlayerNumber, setCurrentPlayerNumber] = useState(0);
  const [playState, setPlayState] = useState("initial");
  const [allPlayers, setAllPlayers] = useState([]);
  const [currentPlayer, setCurrentPlayer] = useState({});
  const [removingCardsId, setRemovingCardsId] = useState([]);
  const [addingCardId, setAddingCardId] = useState(null);
  const [playersAreSet, setPlayersAreSet] = useState(false);
  const [allCardsAreLocked, setAllCardsAreLocked] = useState(true);
  const [difficultySelected, setDifficultySelected] = useState(false);

  const {
    playerCards,
    setPlayerCards,
    currentCard,
    setCurrentCard,
    usedCards,
    setUsedCards,
    StartSetup,
  } = useMultiPlayerGameSetup(
    allPlayers,
    setAllPlayers,
    currentPlayer,
    setCurrentPlayer,
    allCards,
    setAllCards,
    handleOpenModal
  );

  const { HandleLeftArrowClick, HandleRightArrowClick } = useArrowActions(
    playState,
    playerCards,
    setPlayerCards,
    currentCard
  );

  const { NewCard, Confirm, points, LockInCards, Continue } = useCardActions(
    false,
    allCards,
    playerCards,
    setPlayerCards,
    currentCard,
    setCurrentCard,
    currentPlayer,
    setPlayState,
    undefined,
    undefined,
    undefined,
    setRemovingCardsId,
    setAddingCardId,
    handleOpenModal,
    usedCards,
    setUsedCards
  );

  function HandleNewCard() {
    NewCard();
    setAllCardsAreLocked(false);
  }

  function HandleConfirm() {
    let correct = Confirm();

    if (correct === true) {
      return;
    }

    setPlayState("continue");
  }

  function HandleContinue() {
    Continue();

    // Kör endast en timeOut om man har svarat fel för att matcha animationen
    if (!allCardsAreLocked) {
      setTimeout(() => {
        setCurrentPlayerNumber((currentPlayerNumber + 1) % allPlayers.length);
        setAllCardsAreLocked(true);
      }, 500);
    } else {
      // Har man låst in är det ingen animation
      setCurrentPlayerNumber((currentPlayerNumber + 1) % allPlayers.length);
    }
  }

  function HandleLockIn() {
    LockInCards();
    setAllCardsAreLocked(true);
    setPlayState("continue");
    // Kör all logik för att checka ställning och sätta ny spelare

    //spara en users cards när de låses in
    currentPlayer.thisPlayersCards = playerCards;
  }

  function NewGame() {
    // Laddar om sidan för att starta om spelet
    window.location.reload();
  }

  useEffect(() => {
    if (!playersAreSet) return;
    setCurrentPlayer(allPlayers[currentPlayerNumber]);
    handleOpenModal("nextPlayerModal");
  }, [currentPlayerNumber]);

  useEffect(() => {
    if (!playersAreSet) return;
    setPlayerCards(currentPlayer.thisPlayersCards);
  }, [currentPlayer]);

  useEffect(() => {
    StartSetup();
  }, [playersAreSet]);

  function handleDifficultySelect(difficulty) {
    StartSetup(difficulty);
    setDifficultySelected(true);
    setPlayState("new or lock");
  }

  return (
    <div className="lotr-game-page">
      <LotrGameBackground title="lords of the timeline" />
      {openModal === "multiplayerModal" && (
        <MultiplayerModal
          handleCloseModal={handleCloseModal}
          setAllPlayers={setAllPlayers}
          setPlayersAreSet={setPlayersAreSet}
        />
      )}
      {openModal === "nextPlayerModal" && (
        <NextPlayerModal
          handleCloseModal={handleCloseModal}
          player={currentPlayer}
        />
      )}
      <div className="cards-container button-card-wrapper">
        {!difficultySelected ? (
          <>
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
          </>
        ) : (
          <>
            {playersAreSet && (
              <>
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
              </>
            )}
          </>
        )}
      </div>
      <LotrGameTimeline />
      <div className="bottom-row">
        <div className="score-player-container">
          <MultiplayerAvatar
            allPlayers={allPlayers}
            currentPlayerId={currentPlayer.id}
          />
        </div>
        <GameArrows
          clickLeft={() => HandleLeftArrowClick()}
          clickRight={() => HandleRightArrowClick()}
        />
        <div className="button-container">
          {playState === "placing card" ? (
            <button className="button" onClick={() => HandleConfirm()}>
              Confirm
            </button>
          ) : (
            <></>
          )}
          {playState === "new or lock" ? (
            <>
              <button className="button" onClick={() => HandleNewCard()}>
                New card
              </button>
              {!allCardsAreLocked && (
                <>
                  <button className="button" onClick={() => HandleLockIn()}>
                    Lock in cards
                  </button>
                </>
              )}
            </>
          ) : (
            <></>
          )}
          {playState === "won game" ? (
            <>
              {openModal === "gameWonModal" && (
                <GameWonMPModal
                  handleCloseModal={handleCloseModal}
                  NewGame={NewGame}
                  player={currentPlayer}
                  allPlayers={allPlayers}
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
            <button className="button" onClick={() => HandleContinue()}>
              Next player
            </button>
          ) : (
            <></>
          )}
        </div>
      </div>
    </div>
  );
}

export default LotrMultiplayerGame;
