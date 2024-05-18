
import React, { useState } from 'react';
import './LandingPage.css'; 
import Header from '../Header/Header';
import Groceries from '../../Assets/images/Groceries.jpg';
import Delivery from '../../Assets/images/Delivery.jpg';
import Saveameal from '../../Assets/images/Saveameal.jpg';

const LandingPage = () => {
 
  return (
    <>
      <Header/>
      <div>
        <div className='first-row'>
          <img src={Delivery} alt='Delivery' />
          <div className='first-row-right'>
            <h3>What are we doing ?</h3>
            <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident,sunt in culpa qui officia deserunt mollit anim id est laborum."</p>
          </div>
        </div>
        <div className='second-row'>
          <img src={Groceries} alt='Groceries' />
          <div className='second-row-left'>
            <h3>Our Mission and Vision</h3>
            <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident,sunt in culpa qui officia deserunt mollit anim id est laborum."</p>
          </div>
        </div>
      </div>

      <div>
        <div>

        </div>
        <div>

        </div>
      </div>

      <div>

       <div>

       </div>
       <div>

       </div>

      </div>
    </>
  )
      
  ;
};

export default LandingPage;
