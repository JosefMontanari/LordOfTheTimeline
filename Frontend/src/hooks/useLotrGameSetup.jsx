import { useState, useEffect } from "react";

function useLotrGameSetup(
  setAllCards,
  setLocalStorage,
  handleOpenModal,
  difficulty
) {
  const [playerCards, setPlayerCards] = useState([]);
  const [currentCard, setCurrentCard] = useState([]);

  useEffect(() => {
    if (difficulty === "easy") {
      fetch("http://localhost:5266/api/Lotr/lotr-hobbit")
        .then((res) => res.json())
        .then((data) => SetUpGame(data));
    } else {
      fetch("http://localhost:5266/api/Lotr/")
        .then((res) => res.json())
        .then((data) => SetUpGame(data));
    }
  }, [difficulty]);

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

    // Nollställ allam points vid ett nytt game
    setLocalStorage("cardPoints", 0);
    setLocalStorage("totalPoints", 0);
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
