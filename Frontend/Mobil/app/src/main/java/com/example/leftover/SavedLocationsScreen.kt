package com.example.leftover

import androidx.compose.foundation.background
import androidx.compose.foundation.layout.Arrangement
import androidx.compose.foundation.layout.Box
import androidx.compose.foundation.layout.Column
import androidx.compose.foundation.layout.Row
import androidx.compose.foundation.layout.Spacer
import androidx.compose.foundation.layout.fillMaxSize
import androidx.compose.foundation.layout.fillMaxWidth
import androidx.compose.foundation.layout.padding
import androidx.compose.material.icons.Icons
import androidx.compose.material.icons.filled.Add
import androidx.compose.material.icons.filled.Close
import androidx.compose.material.icons.filled.Create
import androidx.compose.material3.Button
import androidx.compose.material3.ButtonDefaults
import androidx.compose.material3.Icon
import androidx.compose.material3.IconButton
import androidx.compose.material3.RadioButton
import androidx.compose.material3.RadioButtonDefaults
import androidx.compose.material3.Surface
import androidx.compose.material3.Text
import androidx.compose.runtime.Composable
import androidx.compose.ui.Alignment
import androidx.compose.ui.Modifier
import androidx.compose.ui.res.colorResource
import androidx.compose.ui.text.font.FontWeight
import androidx.compose.ui.tooling.preview.Preview
import androidx.compose.ui.unit.dp


@Composable
fun SavedLocationsScreen(
    onBackButtonClicked: () -> Unit,
    onNewLocationButtonClicked: () -> Unit,
    onEditButtonClicked:() -> Unit,
) {
    Surface(
        color = colorResource(id = R.color.white),

    ) {
        Column(
            modifier = Modifier
                .fillMaxSize()

        ) {
            Row(
                verticalAlignment = Alignment.CenterVertically,
                modifier = Modifier.background(color = colorResource(id = R.color.Alabaster)).padding(top = 10.dp)
            ) {
                IconButton(onClick = { onBackButtonClicked() }) {
                    Icon(Icons.Filled.Close, contentDescription = null )
                }
                Spacer(modifier = Modifier.weight(0.05f))
                Text(text = "Saved Locations")
                Spacer(modifier = Modifier.weight(1f))
            }
            Spacer(modifier = Modifier.weight(0.05f))
            Row {
                Spacer(modifier = Modifier.weight(1f))
                Button(
                    onClick = { onNewLocationButtonClicked() },
                    colors = ButtonDefaults.buttonColors( containerColor = colorResource(id = R.color.Alabaster))
                ) {
                    Icon(Icons.Filled.Add, contentDescription = null, tint = colorResource(id = R.color.Blue) )
                    Text(text = "New Location", color = colorResource(id = R.color.Blue))
                }
                Spacer(modifier = Modifier.weight(1f))
            }
            Spacer(modifier = Modifier.weight(0.05f))
            Box {
                Column(
                    horizontalAlignment = Alignment.CenterHorizontally,
                    verticalArrangement = Arrangement.Center,
                    modifier = Modifier.fillMaxWidth()
                ) {
                    Box(
                        modifier = Modifier
                            .background(color = colorResource(id = R.color.Alabaster))
                            .padding(10.dp)
                            .fillMaxWidth(0.8f)
                    ) {
                        Row(
                            modifier = Modifier
                        ) {
                            RadioButton(
                                selected = true,
                                onClick = { /*TODO*/ },
                                colors = RadioButtonDefaults.colors(unselectedColor = colorResource(id = R.color.Blue),selectedColor = colorResource(id = R.color.Blue))
                                )
                            Spacer(modifier = Modifier.weight(0.1f))
                            Column {
                                Text(text = "Home", fontWeight = FontWeight.Bold)
                                Text(text = "Lorem ipsum sit dolar upset")
                                Text(text = "Lorem ipsum sit dolar upset")
                                Text(text = "054167****7")
                            }
                            Spacer(modifier = Modifier.weight(0.1f))
                            IconButton(onClick = { onEditButtonClicked() }
                            ) {
                                Icon(Icons.Filled.Create, contentDescription = null, tint = colorResource(id = R.color.Blue) )
                            }
                        }
                    }
                    Spacer(modifier = Modifier.padding(10.dp))
                    Box(
                        modifier = Modifier
                            .background(color = colorResource(id = R.color.Alabaster))
                            .padding(10.dp)
                            .fillMaxWidth(0.8f)
                    ) {
                        Row {
                            RadioButton(
                                selected = false,
                                onClick = {  },
                                colors = RadioButtonDefaults.colors(unselectedColor = colorResource(id = R.color.Blue),
                                    selectedColor = colorResource(id = R.color.Blue))
                            )
                            Spacer(modifier = Modifier.weight(0.1f))
                            Column {
                                Text(text = "Home", fontWeight = FontWeight.Bold)
                                Text(text = "Lorem ipsum sit dolar upset")
                                Text(text = "Lorem ipsum sit dolar upset")
                                Text(text = "054167****7")
                            }
                            Spacer(modifier = Modifier.weight(0.1f))
                            IconButton(onClick = { /*TODO*/ }) {
                                Icon(Icons.Filled.Create, contentDescription = null,tint = colorResource(id = R.color.Blue) )
                            }
                        }
                    }
                    Spacer(modifier = Modifier.padding(10.dp))
                    Box(
                        modifier = Modifier
                            .background(color = colorResource(id = R.color.Alabaster))
                            .padding(10.dp)
                            .fillMaxWidth(0.8f)
                    ) {
                        Row {
                            RadioButton(
                                selected = false,
                                onClick = { /*TODO*/ },
                                colors = RadioButtonDefaults.colors(unselectedColor = colorResource(id = R.color.Blue), selectedColor = colorResource(id = R.color.Blue))
                            )
                            Spacer(modifier = Modifier.weight(0.1f))
                            Column {
                                Text(text = "Home", fontWeight = FontWeight.Bold)
                                Text(text = "Lorem ipsum sit dolar upset")
                                Text(text = "Lorem ipsum sit dolar upset")
                                Text(text = "054167****7")
                            }
                            Spacer(modifier = Modifier.weight(0.1f))
                            IconButton(onClick = { /*TODO*/ }) {
                                Icon(
                                    Icons.Filled.Create,
                                    contentDescription = null,
                                    tint = colorResource(id = R.color.Blue)
                                )
                            }
                        }
                    }
                }
            }
            Spacer(modifier = Modifier.weight(1f))
        }
    }
}

@Preview
@Composable
fun SavedLocationsScreenPreview() {
    SavedLocationsScreen(
        onBackButtonClicked = {},
        onNewLocationButtonClicked = {},
        onEditButtonClicked = {}
    )
}