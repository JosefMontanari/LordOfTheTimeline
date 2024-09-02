function useLocalStorage() {
  function setLocalStorage(key, value) {
    localStorage.setItem(key, JSON.stringify(value));
  }
  function getLocalStorage(key) {
    return JSON.parse(localStorage.getItem(key));
  }

  function setCardPoints(card, time) {
    let points = JSON.parse(localStorage.getItem("cardPoints"));
    if (points === null) {
      points = 0;
    }

    if (card.isCorrect) {
      points += 1000 * (1 + card.difficulty / 10);
      let timeBonus;
      if (time < 5000) {
        timeBonus = Math.floor((5000 - time) / 10);
      }
      points = points + timeBonus;
    }
    console.log("Your cardpoints are: " + points);
    setLocalStorage("cardPoints", points);
  }

  function setStreakPoints(listOfCards) {
    // Stoppa in detta i en egen hook som körs när man låser in sin streak
    let streakOfCards = 0;
    let streakMultiplier = 0;
    listOfCards.forEach((c) => {
      if (c.isConfirmed && c.isCorrect && !c.isLockedIn) {
        streakOfCards++;
      }
    });

    if (streakOfCards > 1) {
      streakMultiplier = Math.round((1 + streakOfCards * 0.15) * 100) / 100; // För att avrunda till 2 decimaler
    } else {
      streakMultiplier = 1;
    }
    setLocalStorage("streakMultiplier", streakMultiplier);
  }

  function setTotalPoints() {
    let currentPoints = JSON.parse(localStorage.getItem("totalPoints"));
    let points = JSON.parse(localStorage.getItem("cardPoints"));
    let streakMultiplier = JSON.parse(localStorage.getItem("streakMultiplier"));

    const totalPoints = Math.floor(currentPoints + points * streakMultiplier);

    setLocalStorage("totalPoints", totalPoints);

    let player = JSON.parse(localStorage.getItem("player"));
    if (player) {
      // Update the high score only if totalPoints is higher
      if (!player.highScore || totalPoints > player.highScore) {
        player.highScore = totalPoints;
      }

      setLocalStorage("player", player);
    }

    return totalPoints;
  }

  function setPlayer(userName, avatar) {
    // Hämta listan med alla existerande spelare för att se om spelaren redan finns
    let listOfPlayers = getLocalStorage("players") || [];
    let existingPlayer = listOfPlayers.find((p) => p.userName === userName);

    // Set highscore till 0 om det är en ny spelare eller till gamla värdet om det är en existerande
    let previousHighScore;

    if (existingPlayer) {
      previousHighScore = existingPlayer?.highScore || 0;
    }

    // Spara och sätt spelaren
    const player = { userName, avatar, highScore: previousHighScore };
    setLocalStorage("player", player);
  }
  function getHighScore() {
    let player = getLocalStorage("player");
    return player?.highScore || 0;
  }

  function updateHighScores() {
    let player = getLocalStorage("player");

    let playerName;
    player === null ? (playerName = "guest") : (playerName = player.userName);
    let score = getLocalStorage("totalPoints");

    // Hämta listan med spelare från localStorage
    let listOfPlayers = getLocalStorage("players") || [];

    // Hitta den existerande spelaren i listan
    let existingPlayer = listOfPlayers.find((p) => p.userName === playerName);

    if (existingPlayer) {
      // Om spelaren redan finns, uppdatera highscore om den nya poängen är högre
      if (score > existingPlayer.highScore) {
        existingPlayer.highScore = score;
      }
    } else {
      // Om spelaren inte finns, lägg till den i listan med den nya poängen
      listOfPlayers.push({ userName: playerName, highScore: score });
    }

    listOfPlayers.sort((a, b) => b.highScore - a.highScore);

    setLocalStorage("players", listOfPlayers);
  }

  return {
    setLocalStorage,
    setCardPoints,
    setTotalPoints,
    setStreakPoints,
    setPlayer,
    getLocalStorage,
    getHighScore,
    updateHighScores,
  };
}

export default useLocalStorage;
