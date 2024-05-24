// src/components/ProductCard.js
import React from 'react';
import './ProductCard.css';

const ProductCard = ({ product }) => {
  return (
    <div className="card">
      <img src={product.imageUrl} alt={product.name} />
      <div className="card-content">
        <h3>{product.name}</h3>
        <p>{product.description}</p>
        <p className="price">${product.discountedPrice}</p>
      </div>
    </div>
  );
};

export default ProductCard;
