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
    val city: String,
    val country: String,
    val created: String,
    val createdBy: Any,
    val email: String,
    val id: Int,
    val items: List<Any>,
    val lastModified: Any,
    val lastModifiedBy: Any,
    val name: String,
    val password: String,
    val phoneNumber: String,
    val picture: String,
    val postalCode: String,
    val reservations: Any,
    val storeType: String,
    val streetInformation: String
)


