import './App.css';
import BusinessRegisterPage from './Components/BusinessRegisterPage/BusinessRegisterPage';
import BusinessMainPage from './Components/BusinessMainPage/BusinessMainPage';
import ConsumerPage from './Components/ConsumerPage/ConsumerPage';
import SignIn from './Components/LoginPage/LoginPage';
import LandingPage from './Components/LandingPage/LandingPage';
import { BrowserRouter, Routes, Route } from "react-router-dom";
import BusinessDatabasePage from './Components/BusinessDatabasePage/BusinessDatabasePage';
import BusinessEditInventoryPage from './Components/BusinessEditInventoryPage/BusinessEditInventoryPage';
import ReservationsPage from './Components/ReservationsPage/ReservationsPage';
import BusinessDeleteAccPage from './Components/BusinessDeleteAccPage/BusinessDeleteAccPage';
import { AuthProvider } from './AuthContext';
import PrivateRoute from './PrivateRoute';
import PublicRoute from './PublicRoute';


function App() {
  return (
    <AuthProvider>
      <BrowserRouter>
        <Routes>
          <Route path='/' element={<LandingPage />} />
          <Route path='/sign-up' element={<BusinessRegisterPage />} />
          <Route path='/business' element={<BusinessMainPage />} />
          <Route path='/consumer' element={<ConsumerPage />} />
          <Route path='/sign-in' element={<PublicRoute element={SignIn} />} />
          <Route path='/database' element={<PrivateRoute element={<BusinessDatabasePage />} />} />
          <Route path='/edit-inventory' element={<PrivateRoute element={<BusinessEditInventoryPage />} />} />
          <Route path='/reservations' element={<PrivateRoute element={<ReservationsPage />} />} />
          <Route path='/delete-account' element={<PrivateRoute element={<BusinessDeleteAccPage />} />} />
        </Routes>
      </BrowserRouter>
    </AuthProvider>
  );
}

export default App;
