import { useState, useEffect } from "react";

function useMultiplayerGameSetup(
  allPlayers,
  setAllPlayers,
  currentPlayer,
  setCurrentPlayer,
  allCards,
  setAllCards,
  handleOpenModal
) {
  const [playerCards, setPlayerCards] = useState([]);
  const [currentCard, setCurrentCard] = useState([]);
  const [usedCards, setUsedCards] = useState([]);

  function StartSetup(difficulty) {
    if (difficulty === "easy") {
      fetch("http://localhost:5266/api/Lotr/lotr-hobbit")
        .then((res) => res.json())
        .then((data) => {
          SetUpMPGame(data);
        });
    } else {
      fetch("http://localhost:5266/api/Lotr/")
        .then((res) => res.json())
        .then((data) => {
          SetUpMPGame(data);
        });
    }
  }

  function SetUpMPGame(data) {
    // Hämta alla kort och lägg dem i "kortleken"
    setAllCards(data);

    if (allPlayers.length < 1) {
      handleOpenModal("multiplayerModal");
      return;
    }

    let allPlayersCopy = [...allPlayers];

    // Gå igenom alla players och lägg ett första kort på dom
    allPlayersCopy.forEach((p) => {
      const firstCard = GetFirstCardMP(data);
      // Skriver över listan istället för push för det renderas två gånger.
      p.thisPlayersCards = [firstCard];

      // Lägger till kortet till "använt" så det inte ska användas igen.
      setUsedCards((prev) => [...prev, firstCard.id]);
    });

    setAllPlayers(allPlayersCopy);
    setCurrentPlayer(allPlayersCopy[0]);
    setPlayerCards(allPlayersCopy[0].thisPlayersCards);
  }

  function GetFirstCardMP(cards) {
    //Förbereder första kortet
    let firstCard = cards[Math.floor(Math.random() * cards.length)];
    firstCard.isCorrect = true;
    firstCard.isConfirmed = true;
    firstCard.isCurrentlyPlaying = false;
    firstCard.isLockedIn = true;

    return firstCard;
  }

  useEffect(() => {
    // Shufflar om kortleken om alla kort har använts en gång.
    if (usedCards.length >= allCards.length) {
      let allPlayerCardIds = [];

      // Går igenom alla spelares kort och lägger de i listan
      allPlayers.forEach((p) => {
        const playerCardIds = p.thisPlayersCards.map((card) => card.id);
        allPlayerCardIds = [...allPlayerCardIds, playerCardIds];
      });
      // Flattenar listan av listor till en enda lista
      allPlayerCardIds = allPlayerCardIds.flat();
      setUsedCards(allPlayerCardIds);
    }
  }, [usedCards]);

  return {
    playerCards,
    setPlayerCards,
    currentCard,
    setCurrentCard,
    usedCards,
    setUsedCards,
    StartSetup,
  };
}

export default useMultiplayerGameSetup;
