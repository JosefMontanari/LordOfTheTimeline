import React from "react";
import LotrCardPlayable from "../../components/LotrCardPlayable/LotrCardPlayable";
import LotrCardLocked from "../../components/LotrCardLocked/LotrCardLocked";
import { useState, useEffect } from "react";
import "./LotrGame.css";
import LotrGameBackground from "../../components/LotrGameBackground/LotrGameBackground";
import LotrGameTimeline from "../../components/LotrGameTimeline/LotrGameTimeline";
import GameArrows from "../../components/GameArrows/GameArrows";

function LotrGame({ allCards, setAllCards }) {
  // För att passa om korten är rätt eller fel när de ändrar state
  const [testList, setTestList] = useState([]);
  const [playerCards, setPlayerCards] = useState([]);
  // Tre olika states, placing card, picking new/locking in, game over och won game
  const [playState, setPlayState] = useState("new or lock");

  useEffect(() => {
    fetch("http://localhost:5266/api/Lotr")
      .then((res) => res.json())
      .then((data) => ChangeToViewModels(data));
  }, []);

  //Enbart för test. Ta bort sen
  useEffect(() => {
    const filteredList = allCards.slice(0, 4);
    setTestList(filteredList);
  }, [allCards]);

  // Lägg till första kortet i playerCards och ändra så det är lockedIn
  // useEffect(() => {
  //   if (allCards.length > 0) {
  //     let newPlayerList = [];

  //     let firstCard = { ...allCards[0], IsLockedIn: true };

  //     newPlayerList.push(firstCard);
  //     console.log(newPlayerList);
  //     setPlayerCards(newPlayerList);
  //   }
  // }, [allCards]);

  function ChangeToViewModels(cardsToUpdate) {
    // Här lägger jag in properties jag vill att min viewModel ska ha
    let updatedCards = cardsToUpdate.map((c) => {
      return {
        ...c,
        isLockedIn: false,
        currentlyPlaying: true,
        isConfirmed: false,
        cardIsCorrect: false,
      };
    });
    setAllCards(updatedCards);

    //Förbereder första kortet
    let newPlayerList = [];
    let firstCard = { ...updatedCards[0] };
    firstCard.isLockedIn = true;
    newPlayerList.push(firstCard);
    console.log(newPlayerList);
    setPlayerCards(newPlayerList);
  }

  function AddPlayerCard() {
    // Skapa en helt ny lista som är en kopia av befintliga playercards
    let newPlayerList = [...playerCards];

    // Skapa en lista med alla existerande korts id
    const existingCardIds = newPlayerList.map((card) => card.id);

    // Skapa ett kort och se om kortets id redan finns i existerande kort
    let newCard;
    do {
      newCard = allCards[Math.floor(Math.random() * allCards.length)];
    } while (existingCardIds.includes(newCard.id)); // Kolla om kortet redan finns i listan (via ID)

    newPlayerList.push(newCard);

    setPlayerCards(newPlayerList);

    setPlayState("placing card");
  }

  function Confirm() {
    setPlayState("new or lock");
  }

  function HandleLeftArrowClick() {
    console.log("left clicked");
  }

  function HandleRightArrowClick() {
    console.log("Right clicked!");
  }
  return (
    <div className="lotr-game-page">
      <LotrGameBackground />
      <div className="cards-container">
        {playerCards.map((c) => {
          if (c.isLockedIn === true) {
            return (
              <LotrCardLocked
                cardData={c}
                cardIsCorrect={c.cardIsCorrect}
                key={c.id}
              />
            );
          } else {
            return <LotrCardPlayable cardData={c} key={c.id} />;
          }
        })}
      </div>
      {/* Null check, kolla om vi kan refaktorera denna i en useEffect senare? */}
      {/* {allCards && allCards.length > 0 && (
        <LotrCardLocked cardData={allCards[2]} cardIsCorrect={true} />
      )} */}
      <LotrGameTimeline />
      <GameArrows
        clickLeft={() => HandleLeftArrowClick()}
        clickRight={() => HandleRightArrowClick()}
      />
      {playState === "placing card" ? (
        <button onClick={() => Confirm()}>Confirm placement</button>
      ) : (
        <></>
      )}
      {playState === "new or lock" ? (
        <>
          {playerCards.length < 10 ? (
            <button onClick={() => AddPlayerCard()}>New card</button>
          ) : (
            <></>
          )}
          <button>Lock in cards</button>
        </>
      ) : (
        <></>
      )}
      {playState === "game over" ? <button>New card</button> : <></>}
    </div>
  );
}

export default LotrGame;
