package com.example.leftover

import androidx.compose.foundation.Image
import androidx.compose.foundation.background
import androidx.compose.foundation.layout.Arrangement
import androidx.compose.foundation.layout.Box
import androidx.compose.foundation.layout.Column
import androidx.compose.foundation.layout.Row
import androidx.compose.foundation.layout.Spacer
import androidx.compose.foundation.layout.fillMaxSize
import androidx.compose.foundation.layout.fillMaxWidth
import androidx.compose.foundation.layout.height
import androidx.compose.foundation.layout.padding
import androidx.compose.foundation.layout.size
import androidx.compose.foundation.shape.RoundedCornerShape
import androidx.compose.material.icons.Icons
import androidx.compose.material.icons.filled.AccountCircle
import androidx.compose.material.icons.filled.Add
import androidx.compose.material.icons.filled.Favorite
import androidx.compose.material.icons.filled.Home
import androidx.compose.material.icons.filled.ShoppingCart
import androidx.compose.material.icons.filled.Star
import androidx.compose.material.icons.outlined.AccountCircle
import androidx.compose.material.icons.outlined.Favorite
import androidx.compose.material.icons.outlined.Home
import androidx.compose.material.icons.outlined.ShoppingCart
import androidx.compose.material3.Icon
import androidx.compose.material3.IconButton
import androidx.compose.material3.Surface
import androidx.compose.material3.Text
import androidx.compose.material3.TextField
import androidx.compose.material3.TextFieldDefaults
import androidx.compose.runtime.Composable
import androidx.compose.ui.Alignment
import androidx.compose.ui.Modifier
import androidx.compose.ui.draw.clip
import androidx.compose.ui.res.colorResource
import androidx.compose.ui.res.painterResource
import androidx.compose.ui.tooling.preview.Preview
import androidx.compose.ui.unit.dp


@Composable
fun RestaurantScreen(
    modifier: Modifier = Modifier,
    onHomePageButtonClicked: () -> Unit,
    onFavouritePageButtonClicked : () -> Unit,
    onReservationScreensButtonClicked : () -> Unit,
    onProfilePageButtonClicked : () -> Unit
) {
    Surface(
        color = colorResource(id = R.color.Alabaster)
    ) {
        Column(modifier = Modifier.background(color = colorResource(id = R.color.Alabaster))) {
            UpPart()
            Spacer(modifier = Modifier.weight(1f))
            RestaurantInfo()
            Spacer(modifier = Modifier.weight(1f))
            BottomPart(
                onHomePageButtonClicked = onHomePageButtonClicked,
                onFavouritePageButtonClicked = onFavouritePageButtonClicked,
                onReservationScreensButtonClicked = onReservationScreensButtonClicked,
                onProfilePageButtonClicked = onProfilePageButtonClicked
            )
        }
    }
}

@Composable
fun BottomPart(
    onHomePageButtonClicked: () -> Unit,
    onFavouritePageButtonClicked: () -> Unit,
    onReservationScreensButtonClicked: () -> Unit,
    onProfilePageButtonClicked: () -> Unit,
) {
    Row(
        modifier = Modifier
            .height(60.dp)
            .fillMaxWidth()
            .background(colorResource(id = R.color.SkyBlue)),
        horizontalArrangement = Arrangement.Center,
        verticalAlignment = Alignment.CenterVertically,
    ) {
        IconButton(onClick = onHomePageButtonClicked) {
            Icon(
                Icons.Outlined.Home,
                contentDescription = null,
                modifier = Modifier.size(40.dp),
                tint = colorResource(id = R.color.Alabaster)
            )
        }
        Spacer(modifier = Modifier.padding(horizontal = 20.dp))
        IconButton(onClick = onFavouritePageButtonClicked) {
            Icon(
                Icons.Outlined.Favorite,
                contentDescription = null,
                modifier = Modifier.size(40.dp)
            )
        }
        Spacer(modifier = Modifier.padding(horizontal = 20.dp))
        IconButton(onClick = onReservationScreensButtonClicked) {
            Icon(
                Icons.Outlined.ShoppingCart,
                contentDescription = null,
                modifier = Modifier.size(40.dp))
        }
        Spacer(modifier = Modifier.padding(horizontal = 20.dp))
        IconButton(onClick = onProfilePageButtonClicked) {
            Icon(
                Icons.Outlined.AccountCircle,
                contentDescription = null,
                modifier = Modifier.size(40.dp)
            )
        }
    }
}

@Composable
fun RestaurantInfo() {
    Column(
        modifier = Modifier.padding(top = 30.dp, start = 15.dp, end = 15.dp)
    ) {
        Box(
            modifier = Modifier
                .background(colorResource(id = R.color.SkyBlue))
                .fillMaxWidth()
                .height(100.dp),
        ){
            Row(
                verticalAlignment = Alignment.CenterVertically,
                horizontalArrangement = Arrangement.Center,
                modifier = Modifier
                    .fillMaxSize()
                    .padding(10.dp)
            ) {
                Image(painter = painterResource(id = R.drawable.foodleftover), contentDescription = null,modifier = Modifier.size(60.dp))
                Spacer(modifier = Modifier.padding(5.dp))
                Column(modifier = Modifier
                    .fillMaxSize()
                ) {
                    Row(
                        modifier = Modifier.padding(top = 5.dp),
                        verticalAlignment = Alignment.CenterVertically,
                        horizontalArrangement = Arrangement.Center,
                        ) {
                        Text(text = "Restaurant Name")
                        Spacer(modifier = Modifier.weight(1f))
                        IconButton(onClick = { /*TODO*/ }) {
                            Icon(Icons.Filled.Favorite, contentDescription = null)
                        }
                    }
                    Spacer(modifier = Modifier.weight(1f))
                    Row(
                        modifier = Modifier.padding(bottom = 5.dp),
                        verticalAlignment = Alignment.CenterVertically,
                        horizontalArrangement = Arrangement.Center,
                    ) {
                        Icon(Icons.Filled.Star, contentDescription = null )
                        Spacer(modifier = Modifier.weight(0.5f))
                        Text(text = "Rate")
                        Spacer(modifier = Modifier.weight(1f))
                        Text(text = "Hours")
                    }
                }
            }
        }

        Spacer(modifier = Modifier.padding(15.dp))

        Box(
            modifier = Modifier
                .background(colorResource(id = R.color.SkyBlue))
                .fillMaxWidth()
                .height(80.dp)
                .padding(10.dp)
        ){
            Text(text = "Campaigns and Coupons")
        }

        Spacer(modifier = Modifier.padding(20.dp))

        Box(
            modifier = Modifier
                .background(colorResource(id = R.color.SkyBlue))
                .fillMaxWidth()
                .height(100.dp)
                .padding(10.dp)
        ){
            Row(
                modifier = Modifier
                    .fillMaxSize()
            ) {
                Column {
                    Text(text = "Food Name")
                    Spacer(modifier = Modifier.weight(1f))
                    Text(text = "Food Ingrediants")
                    Spacer(modifier = Modifier.weight(1f))
                    IconButton(onClick = { /*TODO*/ }) {
                        Icon(Icons.Filled.Add, contentDescription = null )
                    }
                }
                Spacer(modifier = Modifier.weight(1f))
                Image(painter = painterResource(id = R.drawable.foodleftover), contentDescription = null,modifier = Modifier.size(80.dp))
            }
        }

        Spacer(modifier = Modifier.padding(10.dp))

        Box(
            modifier = Modifier
                .background(colorResource(id = R.color.SkyBlue))
                .fillMaxWidth()
                .height(100.dp)
                .padding(10.dp)
        ){
            Row(
                modifier = Modifier

                    .fillMaxSize()
            ) {
                Column {
                    Text(text = "Food Name")
                    Spacer(modifier = Modifier.weight(1f))
                    Text(text = "Food Ingrediants")
                    Spacer(modifier = Modifier.weight(1f))
                    IconButton(onClick = { /*TODO*/ }) {
                        Icon(Icons.Filled.Add, contentDescription = null )
                    }

                }
                Spacer(modifier = Modifier.weight(1f))
                Image(painter = painterResource(id = R.drawable.foodleftover), contentDescription = null,modifier = Modifier.size(80.dp))
            }
        }

        Spacer(modifier = Modifier.padding(10.dp))

        Box(
            modifier = Modifier
                .background(colorResource(id = R.color.SkyBlue))
                .fillMaxWidth()
                .height(100.dp)
                .padding(10.dp)
        ){
            Row(
                modifier = Modifier

                    .fillMaxSize()
            ) {
                Column {
                    Text(text = "Food Name")
                    Spacer(modifier = Modifier.weight(1f))
                    Text(text = "Food Ingrediants")
                    Spacer(modifier = Modifier.weight(1f))
                    IconButton(onClick = { /*TODO*/ }) {
                        Icon(Icons.Filled.Add, contentDescription = null )
                    }

                }
                Spacer(modifier = Modifier.weight(1f))
                Image(painter = painterResource(id = R.drawable.foodleftover), contentDescription = null,modifier = Modifier.size(80.dp))
            }
        }
    }
}

@Composable
fun UpPart() {
    Column(
        modifier = Modifier
            .fillMaxWidth()
            .background(color = colorResource(id = R.color.Alabaster))
    ) {
        Row(
            modifier = Modifier
                .clip(shape = RoundedCornerShape(10.dp, 10.dp, 10.dp, 10.dp))
                .padding(start = 10.dp, top = 5.dp, end = 10.dp),
            verticalAlignment = Alignment.CenterVertically,
            horizontalArrangement = Arrangement.Center

        ){
            TextField(
                value = "Location",
                onValueChange = {}
            )
            Spacer(modifier = Modifier.weight(1f))
            Image(painter = painterResource(id = R.drawable.foodleftover), contentDescription = null,modifier = Modifier.size(60.dp))

        }
            TextField(
                value = "Search",
                onValueChange = {},
                colors = TextFieldDefaults.colors(),
                modifier = Modifier
                    .clip(shape = RoundedCornerShape(10.dp, 10.dp, 10.dp, 10.dp))
                    .fillMaxWidth()
            )
    }
}


@Preview
@Composable
fun RestaurantScreenPreview() {
    RestaurantScreen(
        onHomePageButtonClicked = {},
        onFavouritePageButtonClicked = {},
        onReservationScreensButtonClicked = {},
        onProfilePageButtonClicked = {}
    )
}

@Composable
fun bottomPart(modifier: Modifier = Modifier){
        Surface(
        ) {
            Row(
                modifier = Modifier.fillMaxWidth(),
                horizontalArrangement = Arrangement.Center
            ) {
                Icon( Icons.Default.Home, contentDescription = null, modifier = Modifier.size(60.dp))
                Spacer(modifier = Modifier.padding(horizontal = 15.dp))
                Icon( Icons.Default.Favorite, contentDescription = null, modifier = Modifier.size(60.dp) )
                Spacer(modifier = Modifier.padding(horizontal = 15.dp))
                Icon( Icons.Default.ShoppingCart, contentDescription = null, modifier = Modifier.size(60.dp))
                Spacer(modifier = Modifier.padding(horizontal = 15.dp))
                Icon( Icons.Default.AccountCircle, contentDescription = null, modifier = Modifier.size(60.dp))
            }
        }
}

