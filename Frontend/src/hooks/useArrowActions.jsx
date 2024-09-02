function useArrowActions(playState, playerCards, setPlayerCards, currentCard) {
  function HandleLeftArrowClick() {
    if (playState !== "placing card") {
      return;
    }

    // Skapa en kopia vi kan jobba med
    let newPlayerList = [...playerCards];

    // Hitta kortet som är isCurrentlyPlaying och dess index
    let index = newPlayerList.indexOf(currentCard);

    // Om det inte har index 0
    if (index === 0) {
      // Hittar kortelementet i spel, sätter en vibrate-klass på den
      const cardElement = document.getElementById(`card-${currentCard.id}`);
      if (cardElement) {
        cardElement.classList.add("vibrate");
        setTimeout(() => {
          cardElement.classList.remove("vibrate"); // Tar bort vibrate-klass på kortet
        }, 200);
      }
      return;
    }

    // Flytta index -1
    // Ta bort kortet vi använder från listan
    let filteredPlayerList = newPlayerList.filter((c) => !c.isCurrentlyPlaying);

    // Lägg in kortet på index - 1
    let newFilteredPlayerList = [
      ...filteredPlayerList.slice(0, index - 1), // Kopiera originallistan fram till index - 1
      currentCard, // Lägg tillbaka kortet
      ...filteredPlayerList.slice(index - 1), // Kopiera listan från och med index - 1
    ];

    setPlayerCards(newFilteredPlayerList);
  }

  function HandleRightArrowClick() {
    if (playState !== "placing card") {
      return;
    }
    // Skapa en kopia vi kan jobba med
    let newPlayerList = [...playerCards];

    // Hitta kortet som är isCurrentlyPlaying och dess index
    let index = newPlayerList.indexOf(currentCard);

    // Om det inte är längst till höger
    if (index === newPlayerList.length - 1) {
      const cardElement = document.getElementById(`card-${currentCard.id}`);
      if (cardElement) {
        cardElement.classList.add("vibrate");
        setTimeout(() => {
          cardElement.classList.remove("vibrate");
        }, 200); // Ta bort klassen efter animationen
      }
      // TODO: Gör någon visuell feedback på att man redan är längst till höger
      return;
    }

    // Flytta index +1
    // Ta bort kortet vi använder från listan
    let filteredPlayerList = newPlayerList.filter((c) => !c.isCurrentlyPlaying);

    // Lägg in kortet på index - 1
    let newFilteredPlayerList = [
      ...filteredPlayerList.slice(0, index + 1), // Kopiera originallistan fram till index - 1
      currentCard, // Lägg tillbaka kortet
      ...filteredPlayerList.slice(index + 1), // Kopiera listan från och med index - 1
    ];

    setPlayerCards(newFilteredPlayerList);
  }

  return { HandleLeftArrowClick, HandleRightArrowClick };
}

export default useArrowActions;
