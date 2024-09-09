import { useEffect, useState } from "react";
import useTimer from "./useTime";
import useLocalStorage from "./useLocalStorage";

// TODO: refaktorera allt som har med kortanimationer till en egen hook

function useCardActions(
  singlePlayer,
  allCards,
  playerCards,
  setPlayerCards,
  currentCard,
  setCurrentCard,
  currentPlayer,
  setPlayState,
  setCardPoints,
  setStreakPoints,
  setTotalPoints,
  setRemovingCardsId,
  setAddingCardId,
  handleOpenModal,
  usedCards,
  setUsedCards
) {
  const [points, setPoints] = useState(0);
  const [shouldAddNewCard, setShouldAddNewCard] = useState(false);
  const { updateHighScores } = useLocalStorage();
  // importera Josefs magiska timer
  const { time, startTimer, stopTimer, resetTimer } = useTimer();

  function NewCard() {
    // Starta Josefs magiska timer
    startTimer();

    // Lägg till nytt kort som spelas
    AddPlayerCard();

    // Ändra knapparna så vi är i lägg-läge
    setPlayState("placing card");
  }

  function AddPlayerCard() {
    // Skapa en helt ny lista som är en kopia av befintliga playercards
    let newPlayerList = [...playerCards];

    // Skapa ett kort och se om kortets id redan finns i existerande kort
    let newCard;
    do {
      newCard = allCards[Math.floor(Math.random() * allCards.length)];
    } while (usedCards.includes(newCard.id)); // Kolla om kortet redan använts så ID:t skulle ligga i usedCards

    newCard.isLockedIn = false;
    newCard.isCurrentlyPlaying = true;
    newCard.isConfirmed = false;
    newCard.isCorrect = false;

    newPlayerList.push(newCard);

    setAddingCardId(newCard.id);
    setCurrentCard(newCard);
    setPlayerCards(newPlayerList);
    setUsedCards((prev) => [...prev, newCard.id]);

    setTimeout(() => {
      setAddingCardId(null);
    }, 100);
  }

  function Confirm() {
    // Stoppa Josefs magiska timer och spara tiden
    stopTimer();
    const elapsedTime = time;

    // Kolla om listan ligger rätt utifrån timeValue
    const correct = EvaluateCards();

    if (correct) {
      if (playerCards.length >= 10) {
        //TODO: Fler saker som ska göras vid won game?

        // Lås alla kort
        LockInCards();

        updateHighScores();

        if (!singlePlayer) {
          //spara en users cards när de låses in i MP
          currentPlayer.thisPlayersCards = playerCards;
        }

        //Modal när stäte ändras till won game
        handleOpenModal("gameWonModal");

        setPlayState("won game");
      } else {
        setPlayState("new or lock");
      }
    } else {
      setPlayState("continue");
      localStorage.setItem("cardPoints", 0);
    }

    if (singlePlayer) setCardPoints(currentCard, time);
    if (singlePlayer) setStreakPoints(playerCards);

    // Nollställ Josefs magiska timer
    resetTimer();
    return correct;
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

  function LockInCards() {
    let newPlayerList = [...playerCards];

    newPlayerList.forEach((c) => {
      if (!c.isLockedIn) {
        c.isLockedIn = true;
      }
    });
    setPlayerCards(newPlayerList);

    if (singlePlayer) setPoints(setTotalPoints());

    localStorage.setItem("streakMultiplier", JSON.stringify(1));
    localStorage.setItem("cardPoints", 0);
  }

  async function Continue() {
    // Gör en lista med id på korten som ska tas bort (de som inte är locked in)
    const cardsToRemove = playerCards
      .filter((card) => !card.isLockedIn)
      .map((card) => card.id);

    setRemovingCardsId(cardsToRemove);

    setTimeout(() => {
      // Ta bort kort som inte är lockedIn
      let newPlayerList = playerCards.filter((c) => c.isLockedIn);
      setPlayerCards(newPlayerList);
      setPlayState("new or lock");
      setRemovingCardsId([]);

      // Det här är för att NewCard ska köras efter setPlayerCards har gjort som är asynkron
      // En if-check for att metoden bara ska köras i singleplayer.
      if (singlePlayer) {
        setShouldAddNewCard(true);
      }
    }, 500);
  }

  useEffect(() => {
    //Används i Continue()
    if (shouldAddNewCard) {
      NewCard();
    }
    setShouldAddNewCard(false);
  }, [shouldAddNewCard]);

  return { NewCard, Confirm, points, setPoints, LockInCards, Continue };
}

export default useCardActions;
