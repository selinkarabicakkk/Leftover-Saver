import './App.css';
import BusinessRegisterPage from './Components/BusinessRegisterPage/BusinessRegisterPage';
import BusinessMainPage from './Components/BusinessMainPage/BusinessMainPage';
import ConsumerPage from './Components/ConsumerPage/ConsumerPage';
import SignIn from './Components/LoginPage/LoginPage';
import LandingPage from './Components/LandingPage/LandingPage';
import { BrowserRouter, Routes, Route } from "react-router-dom";
import BusinessDatabasePage from './Components/BusinessDatabasePage/BusinessDatabasePage';
// import 'bootstrap/dist/css/bootstrap.min.css';


function App() {
  return (
    <BrowserRouter>
      <Routes>
        <Route path='/' element={<LandingPage />} />
        <Route path='/sign-up' element={<BusinessRegisterPage />} />
        <Route path='/business' element={<BusinessMainPage />} />
        <Route path='/consumer' element={<ConsumerPage />} />
        <Route path='/sign-in' element={<SignIn />} />
        <Route path='/database' element={<BusinessDatabasePage/>} />
    
      </Routes>
    </BrowserRouter>
  );
}

export default App;
