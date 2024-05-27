package com.example.leftover

import androidx.compose.foundation.Image
import androidx.compose.foundation.clickable
import androidx.compose.foundation.layout.Column
import androidx.compose.foundation.layout.Row
import androidx.compose.foundation.layout.Spacer
import androidx.compose.foundation.layout.fillMaxWidth
import androidx.compose.foundation.layout.height
import androidx.compose.foundation.layout.padding
import androidx.compose.foundation.lazy.LazyColumn
import androidx.compose.material3.Card
import androidx.compose.material3.Surface
import androidx.compose.material3.Text
import androidx.compose.runtime.Composable
import androidx.compose.runtime.livedata.observeAsState
import androidx.compose.ui.Modifier
import androidx.compose.ui.layout.ContentScale
import androidx.compose.ui.res.colorResource
import androidx.compose.ui.res.painterResource
import androidx.compose.ui.tooling.preview.Preview
import androidx.compose.ui.unit.dp
import androidx.lifecycle.viewmodel.compose.viewModel
import androidx.compose.foundation.lazy.items
import androidx.compose.material3.Scaffold
import androidx.lifecycle.LiveData

@Composable
fun HomePageScreen(
    onHomePageButtonClicked: () -> Unit,
    onFavouritePageButtonClicked : () -> Unit,
    onBasketScreensButtonClicked : () -> Unit,
    onProfilePageButtonClicked : () -> Unit,
    onRestaurantCardClicked: () -> Unit,
    onLocationButtonClicked: () -> Unit,
    viewModel: FoodLeftOverViewModel = viewModel()
){
    //System.out.println("asd")
    val restaurantList = viewModel.restaurants
    
    //val restaurant = viewModel.restaurant

    //System.out.println(restaurantList)
    Scaffold(
        topBar = { UpPart {} },
        bottomBar = {
            BottomPart(
                onHomePageButtonClicked = { /*TODO*/ },
                onFavouritePageButtonClicked = { /*TODO*/ },
                onBasketScreensButtonClicked = { /*TODO*/ }
            ) {}
        }
    ) { innerPadding ->
        Column(modifier = Modifier.padding(innerPadding)) {
            if (restaurantList != null) {
                RestaurantList(restaurantList = restaurantList )
            }
        }
    }

}


@Composable
fun RestaurantCard(
    onRestaurantCardClicked: () -> Unit,
    restaurantName: String,
    restaurantType: String

){
    Card(modifier = Modifier.clickable { onRestaurantCardClicked }.padding(10.dp)) {
        Column {
            Image(
                painter = painterResource(id = R.drawable.foodleftover),
                contentDescription = null,
                modifier = Modifier
                    .fillMaxWidth()
                    .height(194.dp),
                contentScale = ContentScale.Crop
            )
            Row(modifier = Modifier.padding(5.dp)) {
                Text(text = restaurantName)
                Spacer(modifier = Modifier.weight(1f))
                Text(text = restaurantType)
            }


        }
    }

}

@Composable
fun RestaurantList(restaurantList: List<Restaurant>, modifier: Modifier = Modifier) {
    LazyColumn(modifier = modifier) {
        items(restaurantList) { restaurant ->
            RestaurantCard(
                onRestaurantCardClicked = {},
                restaurantName = restaurant.name,
                restaurantType = restaurant.storeType,

            )

        }
    }
}
@Preview
@Composable
fun HomePageScreenPreview(){
    HomePageScreen(
        onHomePageButtonClicked = {},
        onFavouritePageButtonClicked= {},
        onBasketScreensButtonClicked= {},
        onProfilePageButtonClicked = {},
        onRestaurantCardClicked = {},
        onLocationButtonClicked = {}
    )
}