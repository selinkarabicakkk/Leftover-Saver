package com.example.leftover

<<<<<<< Updated upstream
import com.example.leftover.Data.AllRestaurantData
import com.example.leftover.Data.RestaurantByIdData
=======
import org.json.JSONObject
import retrofit2.Retrofit
import retrofit2.http.Body
>>>>>>> Stashed changes
import retrofit2.http.GET
import retrofit2.http.POST
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
<<<<<<< HEAD
        @Path("id") id: Int? ,
    ): RestaurantByIdData
*/
    @GET("/api/v{version}/Restaurant/getby/{id}")
    suspend fun getRestaurantById(
        @Path("version") version: String = "1",
        @Path("id") id: Int,
=======
<<<<<<< Updated upstream
        @Path("id") id: Int? = 1,
>>>>>>> 215c57986ed044fe564da97de330a4b0e60d7051
    ): RestaurantByIdData
=======
        @Path("version") id: Int = 1,
    ): RestaurantById


    @POST("/api/Account/register")
    suspend fun registerUser(
        @Body registerRequest: SignUp
    ) : RegisterResponse


>>>>>>> Stashed changes
}


