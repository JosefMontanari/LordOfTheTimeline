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
  const players = [
    {
      id: 1,
      name: "Josef",
      avatar: "./Frontend/public/Frodo-avatar.png",
      colour: "#ffa800",
      thisPlayersCards: [],
    },
    {
      id: 2,
      name: "Gustav",
      avatar: "./Frontend/public/Gandalf-avatar.png",
      colour: "#eea700",
      thisPlayersCards: [],
    },
    {
      id: 3,
      name: "ks-Calle",
      avatar: "./Frontend/public/Orc-avatar.png",
      colour: "#bba400",
      thisPlayersCards: [],
    },
  ];

  const [currentPlayerNumber, setCurrentPlayerNumber] = useState(0);
  const [playState, setPlayState] = useState("new or lock");
  const [allPlayers, setAllPlayers] = useState(players);
  const [currentPlayer, setCurrentPlayer] = useState(
    players[currentPlayerNumber]
  );
  const [removingCardsId, setRemovingCardsId] = useState([]);
  const [addingCardId, setAddingCardId] = useState(null);

  const {
    playerCards,
    setPlayerCards,
    currentCard,
    setCurrentCard,
    usedCards,
    setUsedCards,
  } = useMultiPlayerGameSetup(
    allPlayers,
    setAllPlayers,
    currentPlayer,
    setCurrentPlayer,
    allCards,
    setAllCards
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

  function HandleConfirm() {
    let confirm = Confirm();

    if (confirm === true) {
      return;
    }

    setPlayState("continue");
  }

  function HandleContinue() {
    Continue();
    setTimeout(() => {
      setCurrentPlayerNumber((currentPlayerNumber + 1) % allPlayers.length);
    }, 500);
  }

  useEffect(() => {
    console.log(playState);
  }, [playState]);

  function HandleLockIn() {
    LockInCards();

    // Kör all logik för att checka ställning och sätta ny spelare

    //spara en users cards när de låses in
    currentPlayer.thisPlayersCards = playerCards;

    setCurrentPlayerNumber((currentPlayerNumber + 1) % allPlayers.length);
  }

  useEffect(() => {
    setCurrentPlayer(allPlayers[currentPlayerNumber]);
  }, [currentPlayerNumber]);

  useEffect(() => {
    setPlayerCards(currentPlayer.thisPlayersCards);
    console.log(currentPlayer.name);
  }, [currentPlayer]);

  return (
    <div className="lotr-game-page">
      <LotrGameBackground />
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
      <LotrGameTimeline />
      <div className="bottom-row">
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
              <button className="button" onClick={() => NewCard()}>
                New card
              </button>
              <button className="button" onClick={() => HandleLockIn()}>
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
