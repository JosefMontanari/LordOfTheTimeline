import React from "react";
import LotrCardPlayable from "../../components/LotrCardPlayable/LotrCardPlayable";
import LotrCardConfirmed from "../../components/LotrCardConfirmed/LotrCardConfirmed";
import { useState, useEffect } from "react";
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

function LotrGame({ allCards, setAllCards }) {
  const [isModalOpen, setIsModalOpen] = useState(true); // Börja med modalen öppen

  // Fyra olika states, placing card, new or lock, game over och won game
  const [playState, setPlayState] = useState("new or lock");
  const {
    setLocalStorage,
    setTotalPoints,
    setCardPoints,
    setStreakPoints,
    setPlayer,
  } = useLocalStorage();

  const { playerCards, setPlayerCards, currentCard, setCurrentCard } =
    useLotrGameSetup(setAllCards, setLocalStorage);

  const { NewCard, Confirm, points } = useCardActions(
    allCards,
    playerCards,
    setPlayerCards,
    currentCard,
    setCurrentCard,
    setPlayState,
    setCardPoints,
    setStreakPoints,
    setTotalPoints
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

  return (
    <div className="lotr-game-page">
      {/* Lägg till modalen och kontrollera om den ska vara öppen */}
      <PlayerModal
        isOpen={isModalOpen}
        setPlayer={setPlayer}
        setIsModalOpen={setIsModalOpen}
      />

      <LotrGameBackground />
      <div className="cards-container">
        {playerCards.map((c) => {
          if (c.isCurrentlyPlaying === false) {
            if (c.isLockedIn === false) {
              return <LotrCardConfirmed cardData={c} key={c.id} />;
            } else {
              return <LotrCardLocked cardData={c} key={c.id} />;
            }
          } else {
            return <LotrCardPlayable cardData={c} key={c.id} />;
          }
        })}
      </div>
      <LotrGameTimeline />
      <div className="bottom-row">
        <Score points={points} highScore={12000} />

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
              {playerCards.length < 10 ? (
                <button className="button" onClick={() => NewCard()}>
                  New card
                </button>
              ) : (
                <></>
              )}
              <button className="button">Lock in cards</button>
            </>
          ) : (
            <></>
          )}
          {playState === "game over" ? (
            <button className="button" onClick={() => NewGame()}>
              New game
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
