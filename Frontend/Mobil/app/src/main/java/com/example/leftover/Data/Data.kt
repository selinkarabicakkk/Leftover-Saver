package com.example.leftover.Data

data class AllRestaurantData(
    val succeeded: Boolean,
    val message: String ?= null,
    val errors: List<String> ?= null,
    val data: List<AllRestaurant>,
    val pageNumber: Int,
    val pageSize: Int
)
data class RestaurantByIdData(
    val succeeded: Boolean,
    val message: String ?= null,
    val errors: List<String> ?= null,
    val data: RestaurantById,
)

data class RegisterResponse(
    val succeeded: Boolean,
    val message: String,
    val errors: List<String>?,
    val data: String?
)


