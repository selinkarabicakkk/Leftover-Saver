package com.example.leftover



import androidx.lifecycle.LiveData
import androidx.lifecycle.MutableLiveData
import androidx.lifecycle.ViewModel
import androidx.lifecycle.viewModelScope
import com.example.leftover.Data.AllRestaurant
import com.example.leftover.Data.RestaurantById
import kotlinx.coroutines.launch

class FoodLeftOverViewModel: ViewModel() {

<<<<<<< Updated upstream
    private val _restaurantList = MutableLiveData<List<AllRestaurant>>()
    val restaurantList: LiveData<List<AllRestaurant>> get() = _restaurantList

    private val _restaurant = MutableLiveData<RestaurantById>()
    val restaurant: LiveData<RestaurantById> get() = _restaurant
=======
    var registrationStatus by mutableStateOf<List<String>?>(null)
        private set

    lateinit var restaurant: Restaurant
>>>>>>> Stashed changes


    init {
        viewModelScope.launch {
            getAllRestaurant()
            getRestaurantById(1)
        }
    }

    private suspend fun getAllRestaurant(){
        try {
            val response = RetrofitClient.foodLeftOverApiService.getAllRestaurants()
            if (response.succeeded) {
                _restaurantList.postValue(response.data)
            } else {
                // Handle the error case
                _restaurantList.postValue(emptyList())
            }
        } catch (e: Exception) {
            // Handle the exception
            _restaurantList.postValue(emptyList())
        }
    }


    private suspend fun getRestaurantById(restaurantId: Int){
        try {
            val response = RetrofitClient.foodLeftOverApiService.getRestaurantById()
            if (response.succeeded) {
                _restaurant.postValue(response.restaurant)
            } else {
                // Handle the error case
                System.out.println("Restaurant not found")
            }
        } catch (e: Exception) {
            // Handle the exception
            System.out.println("Exception")
        }
    }

    fun registerUser(registerRequest: SignUp) {
        viewModelScope.launch {
            try {
                val registrationStatus = RetrofitClient.foodLeftOverApiService.registerUser(registerRequest)

                // Handle response if needed
                // After successful registration, navigate to the login screen

            } catch (e: Exception) {
                // Handle error
            }
        }
    }

}
