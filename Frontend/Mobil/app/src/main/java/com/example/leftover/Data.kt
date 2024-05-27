package com.example.leftover

data class AllRestaurant(
    val succeeded: Boolean,
    val message: String ?= null,
    val errors: List<String> ?= null,
    val data: List<Restaurant>,
    val pageNumber: Int,
    val pageSize: Int
)
data class RestaurantById(
    val succeeded: Boolean,
    val message: String ?= null,
    val errors: List<String> ?= null,
    val restaurant: Restaurant,
    val pageNumber: Int,
    val pageSize: Int
)
