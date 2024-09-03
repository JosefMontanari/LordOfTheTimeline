import { useState, useEffect } from "react";

function useLotrGameSetup(
  allCards,
  setAllCards,
  setLocalStorage,
  handleOpenModal,
  difficulty
) {
  const [playerCards, setPlayerCards] = useState([]);
  const [currentCard, setCurrentCard] = useState([]);
  const [usedCards, setUsedCards] = useState([]);

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
    // Öppnar player modalen om det inte finns någon sparad i LocalStorage
    try {
      const player = JSON.parse(localStorage.getItem("player"));

      if (player.userName.length < 1) {
        handleOpenModal("playerModal");
      }
    } catch {
      handleOpenModal("playerModal");
    }
  }, []);

  useEffect(() => {
    // Shufflar om kortleken om alla kort har använts en gång.
    if (usedCards.length >= allCards.length) {
      const playerCardIds = playerCards.map((card) => card.id);
      setUsedCards(playerCardIds);
    }
  }, [usedCards]);

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
    // Lägger till kortet till "använt" så det inte ska användas igen.
    setUsedCards((prev) => [...prev, firstCard.id]);
  }

  return {
    playerCards,
    setPlayerCards,
    currentCard,
    setCurrentCard,
    usedCards,
    setUsedCards,
  };
}

export default useLotrGameSetup;
