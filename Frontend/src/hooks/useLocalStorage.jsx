function useLocalStorage() {
  function setLocalStorage(key, value) {
    localStorage.setItem(key, JSON.stringify(value));
  }

  function setCardPoints(card) {
    let points = JSON.parse(localStorage.getItem("cardPoints"));
    if (points === null) {
      points = 0;
    }

    if (card.isCorrect) {
      points += 1000 * (1 + card.difficulty / 10);
    }

    setLocalStorage("cardPoints", points);
  }

  function setStreakPoints(listOfCards) {
    // Stoppa in detta i en egen hook som körs när man låser in sin streak
    let streakOfCards = 0;
    let streakMultiplier = 0;
    listOfCards.forEach((c) => {
      if (c.isConfirmed && c.isCorrect) {
        streakOfCards++;
      }
    });

    if (streakOfCards > 1) {
      streakMultiplier = 1 + streakOfCards * 0.15;
    } else {
      streakMultiplier = 1;
    }

    setLocalStorage("streakMultiplier", streakMultiplier);
  }

  function setTotalPoints() {
    let points = JSON.parse(localStorage.getItem("cardPoints"));
    let streakMultiplier = JSON.parse(localStorage.getItem("streakMultiplier"));

    const totalPoints = points * streakMultiplier;

    setLocalStorage("totalPoints", totalPoints);
  }

  return {
    setLocalStorage,
    setCardPoints,
    setTotalPoints,
    setStreakPoints,
  };
}

export default useLocalStorage;
