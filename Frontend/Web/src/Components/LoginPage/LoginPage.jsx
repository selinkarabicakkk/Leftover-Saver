
import React, { useState } from 'react';
import { Link } from 'react-router-dom';

import './LoginPage.css'; 
import Header from '../Header/Header';
import Footer from '../Footer/Footer';
import Login from '../../Assets/images/Login.jpg';

const LoginPage = () => {
  const [email, setEmail] = useState('');
  const [password, setPassword] = useState('');

  const handleSubmit = (e) => {
    e.preventDefault();
    // Add authentication logic here
  };

  return (
    <>
      <Header />
      <div className="login-page">

        <div className="login-container">

          <div className="left-column">
            <h2 className="caption" >Sign In To Your Account</h2>
            <div className="input-container">
              <input className='email-input'
                type="text"
                value={email}
                onChange={(e) => setEmail(e.target.value)}
                placeholder="Email"
                required
              />
              <input className='password-input'
                type="password"
                value={password}
                onChange={(e) => setPassword(e.target.value)}
                placeholder="Password"
                required
              />
            </div>
            <div className="forgot-password">
              <a href="#">Forgot Password?</a>
            </div>
            <div className='buttons'>
              <button className="login-button" onClick={handleSubmit}>Sign In</button>
              <Link to="/sign-up"><button>Sign Up</button></Link>
            </div>
          </div>

          <div className="right-column">
            <img src={Login} alt="Login" />
          </div>

        </div>

      </div>
      <Footer />
    </>
  );
};

export default LoginPage;
