import { useState } from "react";

function useCardActions(
  allCards,
  playerCards,
  setPlayerCards,
  currentCard,
  setCurrentCard,
  setPlayState,
  setCardPoints,
  setStreakPoints,
  setTotalPoints
) {
  const [points, setPoints] = useState(0);

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

    newCard.isLockedIn = false;
    newCard.isCurrentlyPlaying = true;
    newCard.isConfirmed = false;
    newCard.isCorrect = false;

    newPlayerList.push(newCard);

    setCurrentCard(newCard);
    setPlayerCards(newPlayerList);
  }

  function Confirm() {
    // Kolla om listan ligger rätt utifrån timeValue
    const correct = EvaluateCards();

    if (correct) {
      setPlayState("new or lock");
    } else {
      setPlayState("game over");
    }

    setCardPoints(currentCard);
    setStreakPoints(playerCards);
    setTotalPoints();
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

  return { NewCard, Confirm, points, setPoints };
}

export default useCardActions;
