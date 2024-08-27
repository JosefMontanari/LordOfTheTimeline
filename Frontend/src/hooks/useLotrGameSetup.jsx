import { useState, useEffect } from "react";

function useLotrGameSetup(setAllCards, setLocalStorage, handleOpenModal) {
  const [playerCards, setPlayerCards] = useState([]);
  const [currentCard, setCurrentCard] = useState([]);

  useEffect(() => {
    fetch("http://localhost:5266/api/Lotr")
      .then((res) => res.json())
      .then((data) => SetUpGame(data));
  }, []);

  useEffect(() => {
    try {
      const player = JSON.parse(localStorage.getItem("player"));

      if (player.userName.length < 1) {
        handleOpenModal("playerModal");
      }
    } catch {
      handleOpenModal("playerModal");
    }
  }, []);

  function SetUpGame(cardsToUpdate) {
    setAllCards(cardsToUpdate);

    GetFirstCard(cardsToUpdate);

    setLocalStorage("cardPoints", 0);
  }

  function GetFirstCard(cards) {
    //Förbereder första kortet
    let newPlayerList = [];
    let firstCard = cards[Math.floor(Math.random() * cards.length)];
    firstCard.isCorrect = true;
    firstCard.isConfirmed = true;
    firstCard.isCurrentlyPlaying = false;
    firstCard.isLockedIn = true;
    newPlayerList.push(firstCard);

    setPlayerCards(newPlayerList);
  }

  return { playerCards, setPlayerCards, currentCard, setCurrentCard };
}

export default useLotrGameSetup;
