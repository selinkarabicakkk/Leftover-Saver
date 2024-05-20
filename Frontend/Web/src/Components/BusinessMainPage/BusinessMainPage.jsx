
import React, { useState } from 'react';
import { Link } from 'react-router-dom';

import './BusinessMainPage.css'; 
import Header from '../Header/Header';
import Footer from '../Footer/Footer';
import PixelPhone from '../../Assets/images/pixel8.png';

const BusinessMainPage = () => {
 
  return (
    <>
      <Header/>
        <div className="own-a-business">
          <div className="own">
            <h1>Own a Business</h1>
            <p>Welcome to Leftover Saver! Sign up, list your products, manage inventory, monitor sales, and receive reservation notifications. Let's reduce food waste and grow your business together!</p>
            <Link to="/sign-up"><button>Register Your Business</button></Link>
          </div>
          <div className="phone">
            <img src={PixelPhone} alt="Pixel Phone" />
          </div>
        </div>
        <div className="guideline">
          <h2>Guide to Owning a Business on Leftover Saver</h2>
          <p>Welcome to the Leftover Saver community! This guide will walk you through the steps to successfully set up and manage your business on our platform, helping you reduce food waste and reach more customers with your leftover products.</p>
          <ul>
            <li>
              <h3>Step 1: Sign Up and Profile Setup</h3>
              <p>Start by registering your business on the Leftover Saver website. Provide essential details such as your business name, address, contact information, and type of business. After registration, complete your profile with additional information to help customers learn more about your business.</p>
            </li>
            <li>
              <h3>Step 2: Add Leftover Products</h3>
              <p>Once your profile is set up, you can start listing your leftover products. For each product, enter details such as the name, description, original price, discounted price, available quantity, and pick-up times. This information helps customers make informed decisions and increases the likelihood of reservations.</p>
            </li>
            <li>
              <h3>Step 3: Manage Your Inventory</h3>
              <p>Easily update your product listings through our user-friendly interface. You can edit details, adjust quantities, or remove products that are no longer available. Keeping your inventory up-to-date ensures a smooth experience for your customers and maximizes your sales opportunities.</p>
            </li>
            <li>
              <h3>Step 4: Monitor Sales and Engagement</h3>
              <p>Access your business dashboard to track sales, customer interactions, and discounts offered. The dashboard provides valuable insights into your performance on the platform, helping you make informed decisions to optimize your offerings and improve customer satisfaction.</p>
            </li>
            <li>
              <h3>Step 5: Receive and Manage Reservations</h3>
              <p>Stay informed with notifications for new reservations and upcoming pick-up times. This allows you to prepare the reserved products in advance and ensure a seamless handover to the customers. Timely preparation and communication are key to maintaining a positive reputation.</p>
            </li>
          </ul>
        </div>

        <div className="faq">
          <h2>Frequently Asked Questions</h2>
          {/* <div className="faq-item">
            <h3>How do I register my business on Leftover Saver?</h3>
            <p>Visit the registration page on our website and fill out the required information to create your business account. Once registered, you can set up your profile and start listing your leftover products.</p>
          </div>
          <div className="faq-item">
            <h3>What types of products can I list on Leftover Saver?</h3>
            <p>You can list a variety of leftover products on our platform, including food items, beverages, packaged goods, and more. Make sure to provide accurate descriptions and pricing details to attract customers.</p>
          </div>
          <div className="faq-item">
            <h3>How can I manage my inventory on Leftover Saver?</h3>
            <p>Use the inventory management tools on your dashboard to update product listings, adjust quantities, or remove products that are no longer available. Regularly updating your inventory helps you maintain an accurate and up-to-date product catalog.</p>
          </div>
          <div className="faq-item">
            <h3>Can I offer discounts on my leftover products?</h3>
            <p>Yes, you can create discount offers for your products to attract more customers and increase sales. Set up promotional discounts through your dashboard and monitor their impact on customer engagement and sales performance.</p>
          </div>
          <div className="faq-item">
            <h3>How do I receive notifications for reservations?</h3>
            <p>Enable notifications on your account settings to receive alerts for new reservations and upcoming pick-up times. Stay informed and prepare your products in advance to ensure a smooth and efficient handover to the customers.</p>
          </div> */}
        </div>
      <Footer />
    </>
  )
      
  ;
};

export default BusinessMainPage;

/* 

<h3>Step 5: Receive and Manage Reservations</h3>
          <p>Stay informed with notifications for new reservations and upcoming pick-up times. This allows you to prepare the reserved products in advance and ensure a seamless handover to the customers. Timely preparation and communication are key to maintaining a positive reputation.</p>

*/
