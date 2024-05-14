
import React, { useState } from 'react';
import './LoginPage.css'; 
import Login from '../../Assets/images/Login.jpg';

const LoginPage = () => {
  const [email, setEmail] = useState('');
  const [password, setPassword] = useState('');

  const handleEmailChange = (e) => {
    setEmail(e.target.value);
  };

  const handlePasswordChange = (e) => {
    setPassword(e.target.value);
  };

  const handleSubmit = (e) => {
    e.preventDefault();
    // Add authentication logic here
  };

  const handleSignUpClick = () => {
    // Handle sign up button click
  };

  return (
    <div className="login-page">

      <div className="login-container">

        <div className="left-column">
          <h2 className="header" >Login To Your Account</h2>
          <div className="input-container">
            <input className='email-input'
              type="text"
              value={email}
              onChange={handleEmailChange}
              placeholder="Email"
            />
            <input className='password-input'
              type="password"
              value={password}
              onChange={handlePasswordChange}
              placeholder="Password"
            />
          </div>
          <div className="forgot-password">
            <a href="#">Forgot Password?</a>
          </div>
          <div className='buttons'>
            <button className="login-button" onClick={handleSubmit}>Login</button>
            <button className="sign-up-button" onClick={handleSignUpClick}>Sign Up</button>
          </div>
        </div>

        <div className="right-column">
         <img  src={Login} alt="Login" />
        </div>

      </div>

    </div>
  );
};

export default LoginPage;
