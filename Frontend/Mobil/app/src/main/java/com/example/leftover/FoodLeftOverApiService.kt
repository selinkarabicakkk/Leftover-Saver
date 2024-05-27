package com.example.leftover

import org.json.JSONObject
import retrofit2.Retrofit
import retrofit2.http.GET
import retrofit2.http.Path
import retrofit2.http.Query
import kotlin.reflect.jvm.internal.impl.load.kotlin.JvmType
import kotlin.reflect.jvm.internal.impl.metadata.ProtoBuf

interface FoodLeftOverApiService {
    @GET("/api/v{version}/Restaurant")
    suspend fun getAllRestaurants(
        @Path("version") version: String ?= "1",
        @Query("PageNumber") pageNumber: Int ?= 1,
        @Query("PageSize") pageSize: Int ?= 5
    ): AllRestaurant

    @GET("/api/v{version}/Restaurant/getby/{id}")
    suspend fun getRestaurantById(
        @Path("version") version: String = "1",
        @Path("version") id: Int = 1,
    ): RestaurantById
}


