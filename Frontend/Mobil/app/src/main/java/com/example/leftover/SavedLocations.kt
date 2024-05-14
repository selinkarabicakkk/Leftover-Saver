package com.example.leftover

import androidx.compose.foundation.layout.Arrangement
import androidx.compose.foundation.layout.Box
import androidx.compose.foundation.layout.Column
import androidx.compose.foundation.layout.Row
import androidx.compose.foundation.layout.Spacer
import androidx.compose.foundation.layout.fillMaxSize
import androidx.compose.material.icons.Icons
import androidx.compose.material.icons.filled.Add
import androidx.compose.material.icons.filled.Close
import androidx.compose.material3.Button
import androidx.compose.material3.Icon
import androidx.compose.material3.IconButton
import androidx.compose.material3.Surface
import androidx.compose.material3.Text
import androidx.compose.runtime.Composable
import androidx.compose.ui.Alignment
import androidx.compose.ui.Modifier
import androidx.compose.ui.graphics.Color
import androidx.compose.ui.res.colorResource
import androidx.compose.ui.tooling.preview.Preview



@Composable
fun SavedLocationsScreen() {
    Surface(
        color = colorResource(id = R.color.Alabaster)
    ) {
        Column(
            modifier = Modifier.fillMaxSize()
        ) {
            Row(verticalAlignment = Alignment.CenterVertically) {
                IconButton(onClick = { /*TODO*/ }) {
                    Icon(Icons.Filled.Close, contentDescription = null )
                }
                Spacer(modifier = Modifier.weight(0.05f))
                Text(text = "Saved Locations")
                Spacer(modifier = Modifier.weight(1f))
            }
            Row {
                Spacer(modifier = Modifier.weight(1f))
                Button(onClick = { /*TODO*/ }) {
                    Icon(Icons.Filled.Add, contentDescription = null )
                    Text(text = "New Location")
                }
                Spacer(modifier = Modifier.weight(1f))
            }

            Box {
                Box {
                   Row {

                   }
                }
            }

        }
        
    }
}

@Preview
@Composable
fun SavedLocationsScreenPreview() {
    SavedLocationsScreen()
}