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
  const [products, setProducts] = useState([]);

  const fetchProducts = () => {
    $.ajax({
      url: "https://foodleftoversaver.azurewebsites.net/api/v1/Item?restaurantId=35&pageNumber=1&pageSize=10",
      method: "GET",
      success: function (data) {
        if (data && data.items) {
          setProducts(data.items);
        } else {
          console.error("Invalid data format:", data);
        }
      },
      error: function (error) {
        console.error("Error fetching products:", error);
      },
    });
  };

  const handleEditInventory = (e) => {
    e.preventDefault();
    // Add authentication logic here

    navigate("/edit-inventory"); // Redirect to the /database page
  };

  useEffect(() => {
    document.title = "FoodLeftover | Business Database Page";
    fetchProducts();
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
          {products.length > 0 ? (
            products.map((product) => (
              <ProductCard key={product.id} product={product} />
            ))
          ) : (
            <p>No products available.</p>
          )}
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
