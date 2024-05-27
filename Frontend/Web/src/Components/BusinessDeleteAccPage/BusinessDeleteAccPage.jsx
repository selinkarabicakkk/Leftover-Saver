import React, { useState } from "react";
import "./BusinessDeleteAccPage.css";
import $ from "jquery";
import Header from "../Header/Header";
import Footer from "../Footer/Footer";
import { useEffect } from "react";

const BusinessDeleteAccPage = () => {
  const [email, setEmail] = useState("");
  const [showPopup, setShowPopup] = useState(false);
  const [confirmationCode, setConfirmationCode] = useState("");
  const [errorMessage, setErrorMessage] = useState("");

  const handleEmailChange = (e) => {
    setEmail(e.target.value);
  };

  const handleSendCode = () => {
    $.ajax({
      url: "https://localhost:9001/api/sendConfirmationCode",
      method: "POST",
      data: { email },
      success: () => {
        setShowPopup(true);
        setErrorMessage("");
      },
      error: (xhr, status, error) => {
        console.error("Error sending confirmation code:", error);
        setErrorMessage("Error sending confirmation code. Please try again.");
      },
    });
  };

  const handleCodeChange = (e) => {
    setConfirmationCode(e.target.value);
  };

  const handleDeleteAccount = () => {
    $.ajax({
      url: "https://localhost:9001/api/deleteAccount",
      method: "DELETE",
      data: { email, confirmationCode },
      success: () => {
        alert("Account deleted successfully.");
        setShowPopup(false);
        setEmail("");
        setConfirmationCode("");
        setErrorMessage("");
      },
      error: (xhr, status, error) => {
        console.error("Error deleting account:", error);
        setErrorMessage(
          "Invalid confirmation code or error deleting account. Please try again."
        );
      },
    });
  };
  useEffect(() => {
    document.title = "FoodLeftover | Business Delete Account Page";
  }, []);

  return (
    <>
      <Header />

      <div className="delete-account-page">
        <h1>Are you sure you want to delete your account?</h1>
        <div className="form-group">
          <label htmlFor="email">Enter your email</label>
          <input
            type="email"
            id="email"
            value={email}
            onChange={handleEmailChange}
          />
        </div>
        <p>
          We will send you a confirmation code to delete your account. Check
          your email account.
        </p>
        <button onClick={handleSendCode}>Send Confirmation Code</button>
        {errorMessage && <p className="error-message">{errorMessage}</p>}

        {showPopup && (
          <div className="popup">
            <div className="popup-content">
              <h2>Enter Confirmation Code</h2>
              <input
                type="text"
                value={confirmationCode}
                onChange={handleCodeChange}
              />
              <button onClick={handleDeleteAccount}>Delete Account</button>
              {errorMessage && <p className="error-message">{errorMessage}</p>}
            </div>
          </div>
        )}
      </div>

      <Footer />
    </>
  );
};

export default BusinessDeleteAccPage;
