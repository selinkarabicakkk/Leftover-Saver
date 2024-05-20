import './App.css';
import BusinessRegisterPage from './Components/BusinessRegisterPage/BusinessRegisterPage';
import BusinessMainPage from './Components/BusinessMainPage/BusinessMainPage';
import ConsumerPage from './Components/ConsumerPage/ConsumerPage';
import LandingPage from './Components/LandingPage/LandingPage';
import { BrowserRouter, Routes, Route } from "react-router-dom";

function App() {
  return (
    <BrowserRouter>
      <Routes>
        <Route path='/' element={<LandingPage />} />
        <Route path='/business-register' element={<BusinessRegisterPage />} />
        <Route path='/business' element={<BusinessMainPage />} />
        <Route path='/consumer' element={<ConsumerPage />} />
      </Routes>
    </BrowserRouter>
  );
}

export default App;
