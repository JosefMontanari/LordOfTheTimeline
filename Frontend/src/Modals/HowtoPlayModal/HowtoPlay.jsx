import React, { useEffect, useState } from "react";
import "./HowtoPlay.css";

function HowtoPlay({ handleCloseModal }) {
  const [mode, setMode] = useState("singleplayer");
  return (
    <div className="modal-overlay" onClick={() => handleCloseModal()}>
      <div className="modal-content" onClick={(e) => e.stopPropagation()}>
        {/* Toggle buttons to switch between Singleplayer and Multiplayer */}
        <div className="mode-buttons">
          <button
            className={mode === "singleplayer" ? "active" : ""}
            onClick={() => setMode("singleplayer")}
          >
            <h2>Singleplayer</h2>
          </button>
          <button
            className={mode === "multiplayer" ? "active" : ""}
            onClick={() => setMode("multiplayer")}
          >
            <h2>Multiplayer</h2>
          </button>
        </div>
        {/* Conditionally render content based on the current mode */}
        {mode === "singleplayer" ? (
          <>
            <div className="instructions">
              <p>
                <span className="instructions-header">Difficulty: </span>
                <br />
                Before you play the game you get to choose difficulty setting:
                <br />
                <em> Normal - </em> The events take place in either The Lord of
                the Rings or The Hobbit. <br />
                <em> Hard - </em> Events from The Silmarillion and other works
                are included.
              </p>
              <p>
                <span className="instructions-header">The Game: </span>
                <br />
                You will receive a starting card with a date and an event.
                Whenever you draw a new card, you can move it left or right on
                the timeline, with the earliest event to the left. When you're
                happy with the card's placement on the timeline, press{" "}
                <em>Confirm</em> to see if it is correct.
              </p>
              <p>
                <span className="instructions-header">Locked cards: </span>
                <br />
                After you've answered you can choose to pick a new card or lock
                your timeline. If you draw a new card, you will get a streak
                bonus to your score but you risk losing all your cards that are
                not locked in. A wrong answer will
                <strong>
                  {" "}
                  drop all your cards that are currently not locked-in.
                </strong>
              </p>
              <p>
                <span className="instructions-header">Score: </span>
                <br />
                Your score will be calculated with: Event difficulty, Streak
                Bonus and Time Bonus. The faster you place your card, the more
                Time Bonus you'll get!
              </p>
              <p>
                <span className="instructions-header">Win: </span>
                <br />
                You win the game by correctly placing 10 cards on your timeline.
              </p>

              <p>
                <span className="instructions-header">Hints: </span>
                <br />
                After you've placed a card you can click on it to see trivia
                about the event.
              </p>
              <p>
                <span className="instructions-header">Special cases: </span>
                <br />
                - If an event spans over more than one day it is always the
                starting date that will be correct.
                <br />- Cards who share the same date will always give points
                when placed next to eachother relative to the timeline
              </p>
              <p>
                <span className="instructions-header">Age definitions: </span>
                <br />
              </p>
              <p>F.A - First Age</p>
              <p>S.A - Second Age</p>
              <p>T.A - Third Age</p>
              <p>Fo.A - Fourth Age</p>
            </div>
          </>
        ) : (
          <div className="instructions">
            <p>
              <span className="instructions-header">Setup: </span>
              <br />
              Before you play the game you set the number of players, each
              player inputs their name and gets to chose an avatar.
              <br />
            </p>
            <p>
              <span className="instructions-header">Difficulty: </span>
              <br />
              In multiplayer there is no choice of difficulty, all events will
              be added to the pool of cards.
              <br />
            </p>
            <p>
              <span className="instructions-header">Turn Mechanics: </span>
              <br />
              On your turn, you draw and place a card on your timeline, similar
              to singleplayer mode. However, in multiplayer, after you lock in a
              card or place it incorrectly, your turn ends, and it's the next
              player's turn to draw a card. You won't get to draw again until
              your next turn.
            </p>
            <p>
              <span className="instructions-header">Win Condition: </span>
              <br />
              The game ends when a player is first in placing 10 cards correctly
              on the timline
            </p>
          </div>
        )}
        <button className="close-btn" onClick={() => handleCloseModal()}>
          Close
        </button>
      </div>
    </div>
  );
}

export default HowtoPlay;
