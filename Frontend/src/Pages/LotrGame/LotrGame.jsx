import React from "react";
import LotrCardPlayable from "../../components/LotrCardPlayable/LotrCardPlayable";
import LotrCardLocked from "../../components/LotrCardLocked/LotrCardLocked";
import { useState, useEffect } from "react";
import "./LotrGame.css";
import LotrGameBackground from "../../components/LotrGameBackground/LotrGameBackground";
import LotrGameTimeline from "../../components/LotrGameTimeline/LotrGameTimeline";
import GameArrows from "../../components/GameArrows/GameArrows";
import LotrCardLockedIn from "../../components/LotrCardLockedIn/lotrCardLockedIn";

function LotrGame({ allCards, setAllCards }) {
  // För att passa om korten är rätt eller fel när de ändrar state

  const [playerCards, setPlayerCards] = useState([]);
  // Tre olika states, placing card, picking new/locking in, game over och won game
  const [playState, setPlayState] = useState("new or lock");

  useEffect(() => {
    fetch("http://localhost:5266/api/Lotr")
      .then((res) => res.json())
      .then((data) => SetUpGame(data));
  }, []);

  function SetUpGame(cardsToUpdate) {
    // Här lägger jag in properties jag vill att min viewModel ska ha
    let updatedCards = cardsToUpdate.map((c) => {
      return {
        ...c,
        isLockedIn: false,
        isCurrentlyPlaying: true,
        isConfirmed: false,
        isCorrect: false,
      };
    });
    setAllCards(updatedCards);

    GetFirstCard(updatedCards);
  }

  function GetFirstCard(cards) {
    //Förbereder första kortet
    let newPlayerList = [];
    let firstCard = cards[Math.floor(Math.random() * cards.length)];
    firstCard.isCorrect = true;
    firstCard.isCurrentlyPlaying = false;
    firstCard.isLockedIn = true;
    newPlayerList.push(firstCard);

    setPlayerCards(newPlayerList);
  }

  function NewCard() {
    // Lägg till nytt kort som spelas
    AddPlayerCard();

    // Ändra knapparna så vi är i lägg-läge
    setPlayState("placing card");
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
  }

  function Confirm() {
    const correct = EvaluateCards();

    if (correct) {
      setPlayState("new or lock");
    } else {
      setPlayState("game over");
    }
  }

  function EvaluateCards() {
    let cardsIsCorrect;

    // Skapa en kopia vi jobbar med
    let newPlayerList = [...playerCards];

    // Skapa en kopia av listan som sorteras efter timeValue
    let correctlySortedList = [...newPlayerList].sort(
      (a, b) => a.timeValue - b.timeValue
    );

    // Kolla om listorna är lika
    const correctAnswer = EvaluateLists(newPlayerList, correctlySortedList);

    if (correctAnswer) {
      // Spelet går vidare

      // Ändra properties på det nya kortet till grönt
      newPlayerList.forEach((c) => {
        if (c.isCurrentlyPlaying) {
          c.isConfirmed = true;
          c.isCorrect = true;
          c.isCurrentlyPlaying = false;
        }
      });

      cardsIsCorrect = true;
    } else {
      // Game Over

      // Ändra properties på det nya kortet till rött
      newPlayerList.forEach((c) => {
        if (c.isCurrentlyPlaying) {
          c.isConfirmed = true;
          c.isCorrect = false;
          c.isCurrentlyPlaying = false;
        }
      });

      cardsIsCorrect = false;
    }

    setPlayerCards(newPlayerList);
    return cardsIsCorrect;
  }

  function EvaluateLists(arr1, arr2) {
    // Inspirerat av chat gpt...
    for (let i = 0; i < arr1.length; i++) {
      // Kontrollera att varje element är lika
      if (arr1[i].id !== arr2[i].id) {
        return false; // Om något element är olika, returnera false
      }
    }
    return true; // Arrayerna är lika
  }

  function NewGame() {
    // Laddar om sidan för att starta om spelet
    window.location.reload();
  }

  function HandleLeftArrowClick() {
    console.log("left clicked");

    // Hitta kortet som är isCurrentlyPlaying

    // Om det inte har index 0

    // Flytta index -1
  }

  function HandleRightArrowClick() {
    console.log("Right clicked!");

    // Hitta kortet som är isCurrentlyPlaying

    // Om det inte har index playerCards.length

    // Flytta index +1
  }
  return (
    <div className="lotr-game-page">
      <LotrGameBackground />
      <div className="cards-container">
        {playerCards.map((c) => {
          if (c.isCurrentlyPlaying === false) {
            if (c.isLockedIn === false) {
              return <LotrCardLocked cardData={c} key={c.id} />;
            } else {
              return <LotrCardLockedIn cardData={c} key={c.id} />;
            }
          } else {
            return <LotrCardPlayable cardData={c} key={c.id} />;
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
