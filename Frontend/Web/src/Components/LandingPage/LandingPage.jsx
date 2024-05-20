
import React, { useState } from 'react';
import './LandingPage.css'; 
import Header from '../Header/Header';
import Footer from '../Footer/Footer';
import Groceries from '../../Assets/images/Groceries.jpg';
import Delivery from '../../Assets/images/Delivery.jpg';
import Saveameal from '../../Assets/images/Saveameal.jpg';

const LandingPage = () => {
 
  return (
    <>
      <Header/>
      <div className='content'>
        <div className='first-row'>
          <img src={Delivery} alt='Delivery' />
          <div className='first-row-right'>
            <h1>What are we doing?</h1>
            <p>At Food Leftover Saver, our mission is to combat food waste by connecting people with surplus food from local businesses at reduced prices. We partner with restaurants, cafes, and grocery stores to offer you fresh, delicious meals and ingredients that would otherwise go to waste. Together, we can save food, save money, and make a positive impact on our planet.</p>
          </div>
        </div>
        <div className='second-row'>
          <img src={Groceries} alt='Groceries' />
          <div className='second-row-left'>
            <h1>Our Mission and Vision</h1>
            <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident,sunt in culpa qui officia deserunt mollit anim id est laborum."</p>
          </div>
        </div>
        <div className='third-row'>
          <img src={Saveameal} alt='Saveameal' />
          <div className='third-row-right'>
            <h1>How it works?</h1>
            <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident,sunt in culpa qui officia deserunt mollit anim id est laborum."</p>
          </div>
        </div>
      </div>

      


      <Footer />
    </>
  )
      
  ;
};

export default LandingPage;
