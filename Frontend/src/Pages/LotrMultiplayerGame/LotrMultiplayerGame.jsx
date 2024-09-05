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

  const [playState, setPlayState] = useState("new or lock");
  const [allPlayers, setAllPlayers] = useState(players);
  const [currentPlayer, setCurrentPlayer] = useState(players[0]);
  const [removingCardsId, setRemovingCardsId] = useState([]);
  const [addingCardId, setAddingCardId] = useState(null);
  const setUpMPGame = useMultiPlayerGameSetup(
    allPlayers,
    setAllPlayers,
    currentPlayer,
    setCurrentPlayer,
    allCards,
    setAllCards
  );
  
  useEffect(() => {
    console.log(allPlayers);
  }, [allPlayers]);

  // const { HandleLeftArrowClick, HandleRightArrowClick } = useArrowActions(
  //   playState,
  //   playerCards,
  //   setPlayerCards,
  //   currentCard
  // );

  return (
    <div className="lotr-game-page">
      <LotrGameBackground />
      <div className="cards-container">
            {currentPlayer.thisPlayersCards.map((c) => {
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

export default LotrMultiplayerGame;
