import Header from "../Header/Header";
import Footer from "../Footer/Footer";
import "./BusinessEditInventoryPage.css";
import $ from "jquery";
import { useState } from "react";
import { Link } from "react-router-dom";
import { useEffect } from "react";
import ProductCard from "../ProductCard/ProductCard";

//DİNAMİKLİĞİ ÇÖZMEM LAZIM

function fetchData() {
  $.ajax({
    url: "https://jsonplaceholder.typicode.com", // URL to send the request to
    type: "GET", // HTTP method
    dataType: "json", // Expected data type of the response
    success: function (response) {
      displayData(response); // Call a function to display the data
    },
    error: function (xhr, status, error) {
      console.error("Error:", status, error); // Handle errors
    },
  });
}

function displayData(data) {
  var output = "<ul>";
  data.forEach(function (post) {
    output += "<li>" + post.title + "</li>";
  });
  output += "</ul>";
  $("#data-container").html(output); // Display the data in a container
}

const BusinessEditInventoryPage = ({ products, updateProductList }) => {
  const [productName, setProductName] = useState("");
  const [productDetails, setProductDetails] = useState({
    name: "",
    discountedPrice: "",
    imageUrl: "",
    description: "",
  });
  const [errorMessage, setErrorMessage] = useState("");
  const [isEditing, setIsEditing] = useState(false);

  const handleProductNameChange = (e) => {
    setProductName(e.target.value);
    findProduct(e.target.value);
  };

  const findProduct = (name) => {
    $.ajax({
      url: `https://jsonplaceholder.typicode.com`, // Adjust URL according to your API
      method: "GET",
      data: { name },
      success: (existingProduct) => {
        if (existingProduct) {
          setProductDetails(existingProduct);
          setIsEditing(true);
          setErrorMessage("");
        } else {
          setIsEditing(false);
          setErrorMessage(
            "There is no matching product. You can create your new product by entering the details."
          );
          setProductDetails({
            name: "",
            discountedPrice: "",
            imageUrl: "",
            description: "",
          });
        }
      },
      error: (xhr, status, error) => {
        console.error("Error finding product:", error);
      },
    });
  };

  const handleInputChange = (e) => {
    const { name, value } = e.target;
    setProductDetails((prevDetails) => ({
      ...prevDetails,
      [name]: value,
    }));
  };

  const handleSave = () => {
    if (isEditing) {
      // Update existing product using AJAX
      $.ajax({
        url: `https://jsonplaceholder.typicode.com${productDetails.id}`, // Adjust URL according to your API
        method: "PUT",
        data: productDetails,
        success: (updatedProduct) => {
          updateProductList((prevProducts) =>
            prevProducts.map((product) =>
              product.id === updatedProduct.id ? updatedProduct : product
            )
          );
        },
        error: (xhr, status, error) => {
          console.error("Error updating product:", error);
        },
      });
    } else {
      // Add new product using AJAX
      $.ajax({
        url: "https://jsonplaceholder.typicode.com", // Adjust URL according to your API
        method: "POST",
        data: productDetails,
        success: (newProduct) => {
          updateProductList((prevProducts) => [...prevProducts, newProduct]);
        },
        error: (xhr, status, error) => {
          console.error("Error adding product:", error);
        },
      });
    }
    setProductName("");
    setProductDetails({
      name: "",
      discountedPrice: "",
      imageUrl: "",
      description: "",
    });
    setIsEditing(false);
    setErrorMessage("");
  };

  useEffect(() => {
    document.title = "FoodLeftover | Business Edit Inventory Page";
  }, []);

  return (
    <>
      <Header />

      <div className="edit-inventory-page">
        <h1>Edit Inventory</h1>
        <div className="form-group">
          <label htmlFor="productName">Product Name</label>
          <input
            type="text"
            id="productName"
            value={productName}
            onChange={handleProductNameChange}
          />
          {errorMessage && <p className="error-message">{errorMessage}</p>}
        </div>
        {/* <div className="form-group">
          <label htmlFor="name">Name</label>
          <input
            type="text"
            id="name"
            name="name"
            value={productDetails.name}
            onChange={handleInputChange}
          />
        </div> */}
        <div className="form-group">
          <label htmlFor="discountedPrice">Discounted Price</label>
          <input
            type="text"
            id="discountedPrice"
            name="discountedPrice"
            value={productDetails.discountedPrice}
            onChange={handleInputChange}
          />
        </div>
        <div className="form-group">
          <label htmlFor="imageUrl">Image URL</label>
          <input
            type="text"
            id="imageUrl"
            name="imageUrl"
            value={productDetails.imageUrl}
            onChange={handleInputChange}
          />
        </div>
        <div className="form-group">
          <label htmlFor="description">Description</label>
          <textarea
            id="description"
            name="description"
            value={productDetails.description}
            onChange={handleInputChange}
          />
        </div>
        <button className="addbutton" onClick={handleSave}>
          {isEditing ? "Edit" : "Add"}
        </button>
      </div>

      <Footer />
    </>
  );
};

export default BusinessEditInventoryPage;
