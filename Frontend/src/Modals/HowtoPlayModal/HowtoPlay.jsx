import React, { useEffect } from "react";
import "./HowtoPlay.css";

function HowtoPlay({ handleCloseModal }) {
  return (
    <div className="modal-overlay" onClick={() => handleCloseModal()}>
      <div className="modal-content" onClick={(e) => e.stopPropagation()}>
        <h2>How to Play</h2>
        <div className="instructions">
          <p>
            Du får ett kort till en början som startkort. Där står det vilket
            årtal du börjar med. Härnäst får du ett nytt kort som du ska placera
            ut på tidslinjen framför dig och gissa om det hände innan eller
            efter det kortet som du hade från början.
          </p>
          <p>
            Gissar du rätt så får du välja mellan att fortsätta med ett nytt
            kort eller stanna och då säkra de kort som du gissat rätt på.
          </p>
          <p>
            Nästa gång du gissar har du då två kort att förhålla dig till, så
            den nya händelsen kan vara innan, mellan eller efter. Ju fler kort
            du har desto svårare blir det och risken ökar att förlora de kort du
            inte säkrat hem.
          </p>
          <p>
            Om du gissar fel förlorar du de kort du eventuellt gissat rätt på
            och inte säkrat.
          </p>
          <p>
            Du vinner när du lyckats med att säkra hem 10 kort på din tidslinje.
          </p>
        </div>
        <button className="close-btn" onClick={() => handleCloseModal()}>
          Close
        </button>
      </div>
    </div>
  );
}

export default HowtoPlay;
