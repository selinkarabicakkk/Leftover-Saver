package com.example.leftover

import androidx.compose.foundation.Image
import androidx.compose.foundation.background
import androidx.compose.foundation.layout.Arrangement
import androidx.compose.foundation.layout.Box
import androidx.compose.foundation.layout.Column
import androidx.compose.foundation.layout.Spacer
import androidx.compose.foundation.layout.fillMaxSize
import androidx.compose.foundation.layout.fillMaxWidth
import androidx.compose.foundation.layout.padding
import androidx.compose.foundation.layout.size
import androidx.compose.foundation.shape.RoundedCornerShape
import androidx.compose.material.icons.Icons
import androidx.compose.material.icons.filled.AccountCircle
import androidx.compose.material3.Button
import androidx.compose.material3.ButtonDefaults
import androidx.compose.material3.Icon
import androidx.compose.material3.Surface
import androidx.compose.material3.Text
import androidx.compose.material3.TextButton
import androidx.compose.material3.TextField
import androidx.compose.material3.TextFieldDefaults
import androidx.compose.runtime.Composable
import androidx.compose.ui.Alignment
import androidx.compose.ui.Modifier
import androidx.compose.ui.draw.clip
import androidx.compose.ui.focus.focusModifier
import androidx.compose.ui.graphics.Color
import androidx.compose.ui.res.colorResource
import androidx.compose.ui.res.painterResource
import androidx.compose.ui.text.font.FontWeight
import androidx.compose.ui.tooling.preview.Preview
import androidx.compose.ui.unit.dp


@Composable
fun LogInScreen(
    onLogInButtonClicked : () -> Unit,
    onSignUpButtonClicked : () -> Unit,
){
    Surface(
        color = colorResource(id = R.color.Alabaster)
    ) {
        Column(modifier = Modifier.fillMaxSize(), horizontalAlignment = Alignment.CenterHorizontally) {
            Spacer(modifier = Modifier.weight(0.5f))
            Image(painter = painterResource(id = R.drawable.foodleftover), contentDescription =null )
            Spacer(modifier = Modifier.weight(0.2f))
            Box(modifier = Modifier
                .clip(shape = RoundedCornerShape(15.dp, 15.dp, 15.dp, 15.dp))
            ) {
                Column(
                    verticalArrangement = Arrangement.Center,
                    horizontalAlignment = Alignment.CenterHorizontally,
                    modifier = Modifier
                        .padding(10.dp)
                ) {
                    Icon(Icons.Filled.AccountCircle, contentDescription = null, modifier = Modifier.size(100.dp))
                    Spacer(modifier = Modifier.padding(5.dp))
                    TextField(
                        value = "Email",
                        onValueChange = {},
                        modifier = Modifier.clip(shape = RoundedCornerShape(10.dp, 10.dp, 10.dp, 10.dp)),
                        colors = TextFieldDefaults.colors(unfocusedContainerColor = colorResource(
                            id = R.color.LightBlue
                        )))
                    Spacer(modifier = Modifier.padding(5.dp))
                    TextField(
                        value = "Password",
                        onValueChange = {},
                        modifier = Modifier.clip(shape = RoundedCornerShape(10.dp, 10.dp, 10.dp, 10.dp)),
                        colors = TextFieldDefaults.colors(unfocusedContainerColor = colorResource(
                            id = R.color.LightBlue
                        )))
                    Spacer(modifier = Modifier.padding(5.dp))
                    TextButton(onClick = { /*TODO*/ }) {
                        Text(text = "Forgot password?", color = colorResource(id = R.color.Blue))
                    }
                    Spacer(modifier = Modifier.padding(10.dp))
                    Button(onClick = onLogInButtonClicked, colors = ButtonDefaults.buttonColors(
                        colorResource(id = R.color.Blue)
                    )) {
                        Text(text = "Sign In")
                    }
                    Spacer(modifier = Modifier.padding(5.dp))
                    Text(text = "Don't you have an account??", color = Color.Gray)
                    TextButton(onClick = onSignUpButtonClicked ) {
                       Text(text = "Sign Up", color = colorResource(id = R.color.Blue), fontWeight = FontWeight.Bold)
                   }
                }
            }
            Spacer(modifier = Modifier.weight(1f))
        }
    }

}


@Preview
@Composable
fun LogInScreenPreview(){
    LogInScreen(
        onLogInButtonClicked = {},
        onSignUpButtonClicked= {},
    )
}