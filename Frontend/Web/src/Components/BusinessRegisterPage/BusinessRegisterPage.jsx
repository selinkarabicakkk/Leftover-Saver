
import React, { useState } from 'react';
import './BusinessRegisterPage.css'; 
import Header from '../Header/Header';
import Footer from '../Footer/Footer';
import Menu from '../../Assets/images/menu.jpg';

const BusinessRegisterPage = () => {
  const [storeName, setStoreName] = useState('');
  const [storeType, setStoreType] = useState('');
  const [phoneNumber, setPhoneNumber] = useState('');
  const [email, setEmail] = useState('');
  const [password, setPassword] = useState('');
  const [confirmPassword, setConfirmPassword] = useState('');
  const [address, setAddress] = useState('');
  const [postalCode, setPostalCode] = useState('');
  const [city, setCity] = useState('');
  const [country, setCountry] = useState('');

  const handleSubmit = (e) => {
    e.preventDefault();
  }

  return (
    <>
      <Header/>
      <div className='main-header'><h1>Register Your Business</h1></div>
      <img className="menu "src={Menu} alt="Menu" />
      <form className='form' onSubmit={handleSubmit}>
        <div className="informations">
          <div className="store-name">
            <input type="text" placeholder='Store Name' value={storeName} onChange={(e) => setStoreName(e.target.value)} required/>
          </div>
          <div className="store-type">
            <input type="text" placeholder='Store Type' value={storeType} onChange={(e) => setStoreType(e.target.value)} required/>
          </div>
          <div className="phone-number">
            <input type="text" placeholder='Phone Number' value={phoneNumber} onChange={(e) => setPhoneNumber(e.target.value)} required/>
          </div>
          <div className="email">
            <input type="text" placeholder='Email' value={email} onChange={(e) => setEmail(e.target.value)} required/>
          </div>
          <div className="password">
            <input type="password" placeholder='Password' value={password} onChange={(e) => setPassword(e.target.value)} required/>
          </div>
          <div className="confirm-password">
            <input type="password" placeholder='Confirm Password' value={confirmPassword} onChange={(e) => setConfirmPassword(e.target.value)} required/>
          </div>
        </div>
        <div className="address-info">
          <div className="address">
            <input type="text" placeholder='Address' value={address} onChange={(e) => setAddress(e.target.value)} required/>
          </div>
          <div className="except-address">
            <div className="postal-code">
              <input type="text" placeholder='Postal Code' value={postalCode} onChange={(e) => setPostalCode(e.target.value)} required/>
            </div>
            <div className="city">
              <input type="text" placeholder='City' value={city} onChange={(e) => setCity(e.target.value)} required/>
            </div>
            <div className="country">
              <input type="text" placeholder='Country' value={country} onChange={(e) => setCountry(e.target.value)} required/>
            </div>
          </div>
        </div>
        <div className="submit-button">
          <button type='submit'>Register</button>
        </div>
      </form>
      {/* <Footer /> */}
    </>
  )
      
  ;
};

export default BusinessRegisterPage;
