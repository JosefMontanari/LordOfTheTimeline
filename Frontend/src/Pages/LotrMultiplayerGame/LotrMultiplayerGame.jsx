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

// Struktur:

// // Modal där man först väljer antal spelare och sedan får varje spelare välja namn, avatar och färg

// // Spara alla spelare i ett state (allPlayers) på game pagen som object, med id, namn, avatar,  lista med spelarens kort, färg

// // usestate som sparar vald svårigetsgrad på multiplayerpagen

// // useState borderColour som är currenPlayer.colour

// // usestate som anger vilken spelares tur det är (currentPlayer) som sätts till 1 default

// // useEffect som körs när currentPlayer ändras som hämtar currentPlayers kort och lägger dem på timelinen

// // useEffect som körs när confirmCard körs som kollar hur många kort alla spelare har och uppdaterar en lista där den med flest kort är högst upp

// // Kör SetUpMPGame() för spelare 1 som hämtar kortleken och ger alla spelare sitt första kort på timelinen (GetFirstCard())

// // Spelare 1 tur börjar (kanske randomizer)

// // Gameplay loop:
// // Sedan kör player 1 den vanliga gameloopen fram tills att han antingen svarat fel eller låst in, vid LockIn() eller fel så går turen över

// // Spara playerCards till spelare 1 i staten allPlayers

// // uppdatera currentPlayer till nästa spelare

// // Timelinen uppdateras med currentPlayers kort (setPlayerCards(currentPlayer.cards))

// // Modal som säger att det är nästa spelares tur med en bekräfta knapp

// // Checka efter varje tur om en spelare har nått 10 kort

// // Gameplay loop tar slut.

// // Modal som visar vem som vunnit

function LotrMultiplayerGame({
  allCards,
  setAllCards,
  openModal,
  handleOpenModal,
  handleCloseModal,
}) {
  const [currentPlayerNumber, setCurrentPlayerNumber] = useState(0);
  const [playState, setPlayState] = useState("new or lock");
  const [allPlayers, setAllPlayers] = useState([]);
  const [currentPlayer, setCurrentPlayer] = useState({});
  const [removingCardsId, setRemovingCardsId] = useState([]);
  const [addingCardId, setAddingCardId] = useState(null);
  const [playersAreSet, setPlayersAreSet] = useState(false);
  const [allCardsAreLocked, setAllCardsAreLocked] = useState(true);

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
    allCards,
    playerCards,
    setPlayerCards,
    currentCard,
    setCurrentCard,
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
    let confirm = Confirm();

    if (confirm === true) {
      return;
    }

    setPlayState("continue");
    setAllCardsAreLocked(true);
  }

  function HandleContinue() {
    Continue();
    setTimeout(() => {
      setCurrentPlayerNumber((currentPlayerNumber + 1) % allPlayers.length);
    }, 500);
  }

  function HandleLockIn() {
    LockInCards();
    setAllCardsAreLocked(true);
    setPlayState("continue");
    // Kör all logik för att checka ställning och sätta ny spelare

    //spara en users cards när de låses in
    currentPlayer.thisPlayersCards = playerCards;
  }

  useEffect(() => {
    if (!playersAreSet) return;
    setCurrentPlayer(allPlayers[currentPlayerNumber]);
  }, [currentPlayerNumber]);

  useEffect(() => {
    if (!playersAreSet) return;
    setPlayerCards(currentPlayer.thisPlayersCards);
  }, [currentPlayer]);

  useEffect(() => {
    StartSetup();
  }, [playersAreSet]);

  return (
    <div className="lotr-game-page">
      <LotrGameBackground />
      {openModal === "multiplayerModal" && (
        <MultiplayerModal
          handleCloseModal={handleCloseModal}
          setAllPlayers={setAllPlayers}
          setPlayersAreSet={setPlayersAreSet}
        />
      )}
      <div className="cards-container button-card-wrapper">
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
                <GameWonModal
                  newGame={NewGame}
                  setPlayer={setPlayer}
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
