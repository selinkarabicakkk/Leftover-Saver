package com.example.leftover


import androidx.compose.foundation.lazy.LazyColumn
import androidx.compose.runtime.Composable
import androidx.compose.runtime.MutableState
import androidx.compose.runtime.getValue
import androidx.compose.runtime.livedata.observeAsState
import androidx.compose.runtime.mutableStateListOf
import androidx.compose.runtime.mutableStateOf
import androidx.compose.runtime.remember
import androidx.compose.runtime.setValue
import androidx.lifecycle.LiveData
import androidx.lifecycle.MutableLiveData
import androidx.lifecycle.ViewModel
import androidx.lifecycle.viewModelScope
import androidx.lifecycle.viewmodel.compose.viewModel
import kotlinx.coroutines.launch
import org.json.JSONArray

class FoodLeftOverViewModel: ViewModel() {
    var restaurantList by mutableStateOf<List<Restaurant>>(emptyList())
        private set

    lateinit var restaurant: Restaurant

    lateinit var restaurants : List<Restaurant>

    init {
        viewModelScope.launch {
            getAllRestaurant()

            //getRestaurantById(1)
        }
    }

    private suspend fun getAllRestaurant(){
        /*restaurantList  = RetrofitClient.foodLeftOverApiService.getAllRestaurants().data
        //_restaurantData.value = RetrofitClient.foodLeftOverApiService.getAllRestaurants().toString()
        System.out.println("asd")
        var json = RetrofitClient.foodLeftOverApiService.getAllRestaurants()
        System.out.println(json)
        var obj = json.getJSONArray("data")

        for (i in 0 until obj.length()) {
            restaurants[i].id = obj.getJSONObject(i).getInt("name")
            restaurants[i].name = obj.getJSONObject(i).getString("name")
            restaurants[i].email = obj.getJSONObject(i).getString("name")
            restaurants[i].password = obj.getJSONObject(i).getString("name")
            restaurants[i].phoneNumber = obj.getJSONObject(i).getString("name")
            restaurants[i].streetInformation = obj.getJSONObject(i).getString("name")
            restaurants[i].city = obj.getJSONObject(i).getString("name")
            restaurants[i].postalCode = obj.getJSONObject(i).getString("name")
            restaurants[i].country = obj.getJSONObject(i).getString("name")
            restaurants[i].storeType = obj.getJSONObject(i).getString("name")
        }
        //System.out.println(restaurantData)
        //System.out.println(RetrofitClient.foodLeftOverApiService.getRestaurantById(id=1).data[0])
        */
    }


    private suspend fun getRestaurantById(restaurantId: Int){
       // restaurant  = RetrofitClient.foodLeftOverApiService.getRestaurantById(id=1).data[0]
    }
}
