import { useState, useRef } from "react";

// Josefs magiska timer för att ge en massa extra poäng!

function useTimer() {
  const [time, setTime] = useState(0);
  const [isRunning, setIsRunning] = useState(false);
  const timerRef = useRef(null);

  // Startar timern
  function startTimer() {
    if (!isRunning) {
      setIsRunning(true);
      timerRef.current = setInterval(() => {
        setTime((prevTime) => prevTime + 1);
      }, 1);
    }
  }

  // Stoppar timern
  function stopTimer() {
    if (isRunning) {
      setIsRunning(false);
      clearInterval(timerRef.current);
    }
  }

  // Nollställer timern
  function resetTimer() {
    setTime(0);
  }

  return { time, startTimer, stopTimer, resetTimer };
}

export default useTimer;
