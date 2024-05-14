package com.example.leftover

import androidx.compose.foundation.Image
import androidx.compose.foundation.background
import androidx.compose.foundation.clickable
import androidx.compose.foundation.layout.Box
import androidx.compose.foundation.layout.Column
import androidx.compose.foundation.layout.Row
import androidx.compose.foundation.layout.Spacer
import androidx.compose.foundation.layout.fillMaxWidth
import androidx.compose.foundation.layout.height
import androidx.compose.foundation.layout.padding
import androidx.compose.foundation.layout.width
import androidx.compose.foundation.lazy.LazyRow
import androidx.compose.foundation.shape.RoundedCornerShape
import androidx.compose.material.icons.Icons
import androidx.compose.material.icons.filled.Star
import androidx.compose.material3.Card
import androidx.compose.material3.Divider
import androidx.compose.material3.Icon
import androidx.compose.material3.Surface
import androidx.compose.material3.Text
import androidx.compose.runtime.Composable
import androidx.compose.ui.Alignment
import androidx.compose.ui.Modifier
import androidx.compose.ui.draw.clip
import androidx.compose.ui.focus.focusModifier
import androidx.compose.ui.res.colorResource
import androidx.compose.ui.res.dimensionResource
import androidx.compose.ui.res.painterResource
import androidx.compose.ui.tooling.preview.Preview
import androidx.compose.ui.unit.dp

@Composable
fun HomePageScreen(
    onHomePageButtonClicked: () -> Unit,
    onFavouritePageButtonClicked : () -> Unit,
    onBasketScreensButtonClicked : () -> Unit,
    onProfilePageButtonClicked : () -> Unit,
    onRestaurantBoxClicked: () -> Unit,
    onLocationButtonClicked: () -> Unit
){
    Surface(
        color = colorResource(id = R.color.Alabaster)
    ) {
        Column {
            UpPart(onLocationButtonClicked)
            HomePageScreenInfo(
                onRestaurantBoxClicked = onRestaurantBoxClicked
            )
            BottomPart(
                onHomePageButtonClicked = onHomePageButtonClicked,
                onFavouritePageButtonClicked = onFavouritePageButtonClicked,
                onBasketScreensButtonClicked = onBasketScreensButtonClicked,
                onProfilePageButtonClicked = onProfilePageButtonClicked
            )
        }
    }
}

@Composable
fun HomePageScreenInfo(
    onRestaurantBoxClicked: () -> Unit
){
    Column(
        modifier =
        Modifier
            .padding(10.dp)
            .height(600.dp)
            .fillMaxWidth()
    ) {

        Spacer(modifier = Modifier.padding(5.dp))
        Box{
            Column {
                Row {
                    Text(text = "Category 1")
                    Spacer(modifier = Modifier.weight(1f))
                    Text(text = "See all>>")
                }
                Divider( thickness = 2.dp )
                Spacer(modifier = Modifier.padding(2.dp))
                Row {
                    Box(
                        modifier = Modifier
                            .clip(shape = RoundedCornerShape(10.dp, 10.dp, 10.dp, 10.dp))
                            .background(color = colorResource(id = R.color.SkyBlue))
                            .clickable {
                                onRestaurantBoxClicked()
                            }
                    ) {
                        Column(
                            horizontalAlignment = Alignment.CenterHorizontally,
                        ) {
                            Spacer(modifier = Modifier.padding(2.dp))
                            Image(painter = painterResource(id = R.drawable.foodleftover), contentDescription = null, modifier = Modifier.height(100.dp))
                            Row(verticalAlignment = Alignment.CenterVertically) {
                                Text(text = "Name of Business")
                                Spacer(modifier = Modifier.padding(15.dp))
                                Text(text = "Time Interval")
                            }
                            Row(verticalAlignment = Alignment.CenterVertically) {
                                Icon(Icons.Filled.Star, contentDescription = null )
                                Text(text = "Rate")
                                Text(text = " | ")
                                Text(text = "Distance(m)")
                                Spacer(modifier = Modifier.width(95.dp))
                            }
                        }
                    }
                }
            }
        }
        Spacer(modifier = Modifier.weight(1f))
        Box{
            Column {
                Row {
                    Text(text = "Category 2")
                    Spacer(modifier = Modifier.weight(1f))
                    Text(text = "See all>>")
                }
                Divider( thickness = 2.dp )
                Spacer(modifier = Modifier.padding(2.dp))
                Row {
                    Box(modifier = Modifier
                        .clip(shape = RoundedCornerShape(10.dp, 10.dp, 10.dp, 10.dp))
                        .background(color = colorResource(id = R.color.SkyBlue))
                        .clickable {
                            onRestaurantBoxClicked()
                        }
                    ) {
                        Column(horizontalAlignment = Alignment.CenterHorizontally) {
                            Spacer(modifier = Modifier.padding(2.dp))
                            Image(painter = painterResource(id = R.drawable.foodleftover), contentDescription = null, modifier = Modifier.height(100.dp))
                            Row(verticalAlignment = Alignment.CenterVertically) {
                                Text(text = "Name of Business")
                                Spacer(modifier = Modifier.padding(15.dp))
                                Text(text = "Time Interval")
                            }
                            Row(verticalAlignment = Alignment.CenterVertically) {
                                Icon(Icons.Filled.Star, contentDescription = null )
                                Text(text = "Rate")
                                Text(text = " | ")
                                Text(text = "Distance(m)")
                                Spacer(modifier = Modifier.width(95.dp))
                            }
                        }
                    }
                }
            }
        }
        Spacer(modifier = Modifier.weight(1f))
        Box{
            Column {
                Row {
                    Text(text = "Category 3")
                    Spacer(modifier = Modifier.weight(1f))
                    Text(text = "See all>>")
                }
                Divider(thickness = 2.dp)
                Spacer(modifier = Modifier.padding(2.dp))
                Row {
                    Box(
                        modifier = Modifier
                            .clip(shape = RoundedCornerShape(10.dp, 10.dp, 10.dp, 10.dp))
                            .background(color = colorResource(id = R.color.SkyBlue))
                            .clickable {
                                onRestaurantBoxClicked()
                            }
                    ) {
                        Column(horizontalAlignment = Alignment.CenterHorizontally) {
                            Spacer(modifier = Modifier.padding(2.dp))
                            Image(painter = painterResource(id = R.drawable.foodleftover), contentDescription = null, modifier = Modifier.height(100.dp))
                            Row(verticalAlignment = Alignment.CenterVertically) {
                                Text(text = "Name of Business")
                                Spacer(modifier = Modifier.padding(15.dp))
                                Text(text = "Time Interval")
                            }
                            Row(verticalAlignment = Alignment.CenterVertically) {
                                Icon(Icons.Filled.Star, contentDescription = null )
                                Text(text = "Rate")
                                Text(text = " | ")
                                Text(text = "Distance(m)")
                                Spacer(modifier = Modifier.width(95.dp))
                            }
                        }
                    }
                }
            }
        }
        Spacer(modifier = Modifier.padding(5.dp))
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
        onRestaurantBoxClicked = {},
        onLocationButtonClicked = {}
    )
}