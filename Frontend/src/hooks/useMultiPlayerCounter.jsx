function useMultiPlayerCounter(playerCards ) {
  
    function checkPlayersCards({ player }) {
    let listOfConfirmedCards = player.playersCards;

    let numberOfCorrectCards = 0;
    listOfConfirmedCards.forEach((c) => {
      if (c.isLockedIn) {
        numberOfCorrectCards++;
      }
    });

    return numberOfCorrectCards;
  }

  function checkIfPlayerHasWon({ player }) {
    if (checkPlayersCards({ player }) === 10) {
      return true;
    } else {
      return false;
    }
  }
  return checkPlayersCards, checkIfPlayerHasWon;
}

export default useMultiPlayerCounter;
