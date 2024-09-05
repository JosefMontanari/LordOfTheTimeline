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

  function StartSetup() {
    fetch("http://localhost:5266/api/Lotr/")
      .then((res) => res.json())
      .then((data) => {
        SetUpMPGame(data);
      });
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

  //Nästa tur
  //Uppdatera allPlayers
  //setCurrentPlayer till nästa
  //setPlayerCards(currentPlayer.thisPlayersCards)

  function GetFirstCardMP(cards) {
    //Förbereder första kortet
    let firstCard = cards[Math.floor(Math.random() * cards.length)];
    firstCard.isCorrect = true;
    firstCard.isConfirmed = true;
    firstCard.isCurrentlyPlaying = false;
    firstCard.isLockedIn = true;

    return firstCard;
  }

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
