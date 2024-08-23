import { useState } from "react";
import { Routes, Route, Link } from "react-router-dom";
import "./App.css";
import Navbar from "./components/Navbar/Navbar";
import Home from "./Pages/Home/Home";
import LotrGame from "./Pages/LotrGame/LotrGame";
import Footer from "./components/Footer/Footer";
function App() {
  const [allCards, setAllCards] = useState([]);

  return (
    <>
      <div className="app">
        <Navbar />
        <Routes>
          <Route path="/" element={<Home />} />
          <Route
            path="/game"
            element={<LotrGame allCards={allCards} setAllCards={setAllCards} />}
          />
        </Routes>
      </div>
    </>
  );
}

export default App;
