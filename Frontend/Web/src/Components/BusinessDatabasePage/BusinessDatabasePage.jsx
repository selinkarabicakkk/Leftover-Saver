import Header from "../Header/Header";
import Footer from "../Footer/Footer";
import "./BusinessDatabasePage.css";
import $ from "jquery";
import { useState } from "react";
import { Link, useNavigate } from "react-router-dom";
import { useEffect } from "react";
// import Card from 'react-bootstrap/Card';
import ProductCard from "../ProductCard/ProductCard";

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
    // Add more products as needed
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

      <div className="business-container">
        <h1>Business Name</h1>
        <div className="product-cards">
          {products.map((product) => (
            <ProductCard key={product.id} product={product} />
          ))}
        </div>
      </div>

      <div className="underitemsbuttons">
        <button onClick={handleEditInventory}>Edit Inventory</button>
        <button>Delete Inventory</button>
        <button>Account Settings</button>
      </div>

      <Footer />
    </>
  );
};

export default BusinessDatabasePage;
