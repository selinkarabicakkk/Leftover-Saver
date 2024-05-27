import Header from "../Header/Header";
import Footer from "../Footer/Footer";
import "./BusinessDatabasePage.css";
import $ from "jquery";
import { useState } from "react";
import { Link, useNavigate } from "react-router-dom";
import { useEffect } from "react";
// import Card from 'react-bootstrap/Card';
import ProductCard from "../ProductCard/ProductCard";
import Delete_Account from "../../Assets/images/delete_account.png";
import Reservations_Button from "../../Assets/images/reserve.png";

const BusinessDatabasePage = () => {
  const navigate = useNavigate();
  const products = [
    {
      id: 1,
      name: "Product 1",
      discountedPrice: 5.99,
      imageUrl: "https://via.placeholder.com/150",
      description: "This is a description for product 1.",
    },
    {
      id: 2,
      name: "Product 2",
      discountedPrice: 3.99,
      imageUrl: "https://via.placeholder.com/150",
      description: "This is a description for product 2.",
    },
    {
      id: 3,
      name: "Product 3",
      discountedPrice: 7.99,
      imageUrl: "https://via.placeholder.com/150",
      description: "This is a description for product 3.",
    },
  ];

  const handleEditInventory = (e) => {
    e.preventDefault();
    // Add authentication logic here

    navigate("/edit-inventory"); // Redirect to the /database page
  };

  useEffect(() => {
    document.title = "FoodLeftover | Business Database Page";
  }, []);

  return (
    <>
      <Header />
      {/* Reservations button (reservations sayfasina yönlendir) */}
      {/* Delete account button (delete account sayfasina yönlendir) */}

      <div>
        <h1 className="main-header">Business Name</h1>
        <div className="accounts">
          <div className="delaccdiv">
            <Link to="/delete-account">
              <img
                className="deleteaccimg"
                src={Delete_Account}
                alt="Deleteacc"
              />
            </Link>
            <p>Delete your account</p>
          </div>

          <div className="reservationsbutton">
            <Link to="/reservations">
              <img
                className="reservationsimg"
                src={Reservations_Button}
                alt="Resbutton"
              />
            </Link>
            <p>Reservations</p>
          </div>
        </div>
      </div>
      <div className="business-container">
        <div className="product-cards">
          {products.map((product) => (
            <ProductCard key={product.id} product={product} />
          ))}
        </div>
      </div>
      <div className="underitemsbuttons">
        <button onClick={handleEditInventory}>Edit Inventory</button>
        <button>Delete Inventory</button>
      </div>
      <Footer />
    </>
  );
};

export default BusinessDatabasePage;
