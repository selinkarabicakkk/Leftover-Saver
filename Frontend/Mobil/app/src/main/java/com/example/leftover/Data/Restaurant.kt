package com.example.leftover.Data

data class AllRestaurant(
    var id: Int,
    var name: String,
    var email: String,
    var password: String,
    var phoneNumber: String,
    var streetInformation: String,
    var city: String,
    var postalCode: String,
    var country: String,
    var storeType: String
)

data class RestaurantById(
    val name: String,
    val email: String,
    val password: String,
    val phoneNumber: String,
    val streetInformation: String,
    val city: String,
    val postalCode: String,
    val country: String,
    val storeType: String,
    val picture: String,
    val items: List<Item>,
    val reservations: String,
    val id: Int,
    val createdBy: String,
    val created: String,
    val lastModified: String,
    val lastModifiedBy: String,
)

data class Item(
    val itemName: String,
    val price: Int,
    val picture: String,
    val explanation: String,
    val restaurantId: Int,
    val restaurant: String,
    val reservationItems: String,
    val cartItems: String,
    val id: Int,
    val createdBy: String,
    val created: String,
    val lastModifiedBy: String,
    val lastModified: String,
)

