import React from "react";
import LotrCardPlayable from "../../components/LotrCardPlayable/LotrCardPlayable";
import LotrCardLocked from "../../components/LotrCardLocked/LotrCardLocked";
import { useState, useEffect } from "react";
import "./LotrGame.css";
import LotrGameBackground from "../../components/LotrGameBackground/LotrGameBackground";
import LotrGameTimeline from "../../components/LotrGameTimeline/LotrGameTimeline";
import GameArrows from "../../components/GameArrows/GameArrows";
import LotrCardTrivia from "../../components/LotrCardTrivia/LotrCardTrivia";

function LotrGame({ allCards, setAllCards }) {
  // För att passa om korten är rätt eller fel när de ändrar state
  const [testList, setTestList] = useState([]);
  const [playerCards, setPlayerCards] = useState([]);

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
        cardIsCorrect: false,
      };
    });
    setAllCards(updatedCards);

    //Förbereder första kortet
    let newPlayerList = [];
    let firstCard = { ...updatedCards[0], IsLockedIn: true };
    newPlayerList.push(firstCard);
    console.log(newPlayerList);
    setPlayerCards(newPlayerList);
  }

  function handleLeftArrowClick() {
    console.log("left clicked");
  }

  function handleRightArrowClick() {
    console.log("Right clicked!");
  }
  return (
    <div className="lotr-game-page">
      <LotrGameBackground />
      {/* <div className="cards-container">
        {testList.map((t) => (
          <LotrCardPlayable cardData={t} />
        ))}
      </div> */}

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
      {/* Null check, kolla om vi kan refaktorera denna i en useEffect senare? */}
      {/* {allCards && allCards.length > 0 && (
        <LotrCardLocked cardData={allCards[2]} cardIsCorrect={true} />
      )} */}
      <LotrGameTimeline />
      <GameArrows
        clickLeft={() => handleLeftArrowClick()}
        clickRight={handleRightArrowClick}
      />
      <button>Confirm placement</button>
      <button>New card</button>
      <button>Lock in card</button>
    </div>
  );
}

export default LotrGame;
