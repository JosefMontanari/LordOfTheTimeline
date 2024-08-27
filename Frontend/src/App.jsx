import { useState } from "react";
import { Routes, Route, Link } from "react-router-dom";
import "./App.css";
import Navbar from "./components/Navbar/Navbar";
import Home from "./Pages/Home/Home";
import LotrGame from "./Pages/LotrGame/LotrGame";
function App() {
  const [allCards, setAllCards] = useState([]);
  const [openModal, setOpenModal] = useState(null);

  const handleOpenModal = (modalName) => {
    setOpenModal(modalName);
  };

  const handleCloseModal = () => {
    setOpenModal(null);
  };

  return (
    <>
      <div className="app">
        <Navbar
          openModal={openModal}
          handleOpenModal={handleOpenModal}
          handleCloseModal={handleCloseModal}
        />
        <Routes>
          <Route path="/" element={<Home />} />
          <Route
            path="/game"
            element={
              <LotrGame
                allCards={allCards}
                setAllCards={setAllCards}
                openModal={openModal}
                handleOpenModal={handleOpenModal}
                handleCloseModal={handleCloseModal}
              />
            }
          />
        </Routes>
      </div>
    </>
  );
}

export default App;
