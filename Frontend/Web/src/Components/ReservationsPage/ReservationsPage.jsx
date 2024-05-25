import React, { useState } from "react";
import { Link } from "react-router-dom";
import "./ReservationsPage.css";
import Header from "../Header/Header";
import Footer from "../Footer/Footer";
import { useEffect } from "react";
import $ from "jquery";

const ReservationsPage = () => {
  const [reservations, setReservations] = useState([]);
  const [loading, setLoading] = useState(true);
  const [error, setError] = useState(null);

  useEffect(() => {
    fetchReservations();
  }, []);

  const fetchReservations = () => {
    $.ajax({
      url: "https://catfact.ninja/fact",
      method: "GET",
      success: (data) => {
        setReservations([data]); // wrap data in an array
        setLoading(false);
      },
      error: (xhr, status, error) => {
        console.error("Error fetching reservations:", error);
        setError("Error fetching reservations");
        setLoading(false);
      },
    });
  };

  if (loading) {
    return <div>Loading...</div>;
  }

  if (error) {
    return <div>{error}</div>;
  }

  return (
    <>
      <Header />

      <div className="reservations-page">
        <h1>Incoming Reservations</h1>
        <div className="reservations-list">
          {reservations.map((reservation) => (
            <div key={reservation.id} className="reservation-card">
              <h2>{reservation.customerName}</h2>
              <p>
                <strong>Product:</strong> {reservation.productName}
              </p>
              <p>
                <strong>Quantity:</strong> {reservation.quantity}
              </p>
              <p>
                <strong>Pick-up Time:</strong> {reservation.pickUpTime}
              </p>
            </div>
          ))}
        </div>
      </div>

      <Footer />
    </>
  );
};

export default ReservationsPage;
