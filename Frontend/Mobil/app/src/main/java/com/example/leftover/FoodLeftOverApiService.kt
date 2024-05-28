package com.example.leftover

import com.example.leftover.Data.AllRestaurantData
import com.example.leftover.Data.RestaurantByIdData
import retrofit2.http.GET
import retrofit2.http.Path
import retrofit2.http.Query

interface FoodLeftOverApiService {
    @GET("/api/v{version}/Restaurant")
    suspend fun getAllRestaurants(
        @Path("version") version: String? = "1",
        @Query("PageNumber") pageNumber: Int? = 1,
        @Query("PageSize") pageSize: Int? = 5
    ): AllRestaurantData
/*
    @GET("/api/v{version}/Restaurant/getby/{id}")
    suspend fun getRestaurantById(
        @Path("version") version: String = "1",
        @Path("id") id: Int? ,
    ): RestaurantByIdData
*/
    @GET("/api/v{version}/Restaurant/getby/{id}")
    suspend fun getRestaurantById(
        @Path("version") version: String = "1",
        @Path("id") id: Int,
    ): RestaurantByIdData
}


