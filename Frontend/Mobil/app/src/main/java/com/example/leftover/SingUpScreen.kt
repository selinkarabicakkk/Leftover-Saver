package com.example.leftover

import androidx.compose.foundation.Image
import androidx.compose.foundation.background
import androidx.compose.foundation.layout.Arrangement
import androidx.compose.foundation.layout.Box
import androidx.compose.foundation.layout.Column
import androidx.compose.foundation.layout.Spacer
import androidx.compose.foundation.layout.fillMaxSize
import androidx.compose.foundation.layout.padding
import androidx.compose.foundation.layout.size
import androidx.compose.foundation.shape.RoundedCornerShape
import androidx.compose.material.icons.Icons
import androidx.compose.material.icons.filled.AccountCircle
import androidx.compose.material3.Button
import androidx.compose.material3.Icon
import androidx.compose.material3.Surface
import androidx.compose.material3.Text
import androidx.compose.material3.TextField
import androidx.compose.runtime.Composable
import androidx.compose.ui.Alignment
import androidx.compose.ui.Modifier
import androidx.compose.ui.draw.clip
import androidx.compose.ui.res.colorResource
import androidx.compose.ui.res.painterResource
import androidx.compose.ui.tooling.preview.Preview
import androidx.compose.ui.unit.dp

@Composable
fun SignUpScreen(
    onLogInButtonClicked : () -> Unit,
    onSignUpButtonClicked : () -> Unit,
    onContinueWithGoogleButtonClicked : () -> Unit,
){
    Surface(
        color = colorResource(id = R.color.Alabaster)
    ) {
        Column(modifier = Modifier.fillMaxSize(), horizontalAlignment = Alignment.CenterHorizontally) {
            Spacer(modifier = Modifier.weight(0.4f))
            Image(painter = painterResource(id = R.drawable.foodleftover), contentDescription =null )
            Spacer(modifier = Modifier.weight(0.2f))
            Box(modifier = Modifier
                .clip(shape = RoundedCornerShape(15.dp, 15.dp, 15.dp, 15.dp))
            ) {
                Column(
                    verticalArrangement = Arrangement.Center,
                    horizontalAlignment = Alignment.CenterHorizontally,
                    modifier = Modifier
                        .background(color = colorResource(id = R.color.SkyBlue))
                        .padding(10.dp)
                ) {
                    Icon(Icons.Filled.AccountCircle, contentDescription = null, modifier = Modifier.size(80.dp))
                    Spacer(modifier = Modifier.padding(5.dp))
                    TextField(value = "User Name", onValueChange = {}, modifier = Modifier.clip(shape = RoundedCornerShape(10.dp, 10.dp, 10.dp, 10.dp)) )
                    Spacer(modifier = Modifier.padding(5.dp))
                    TextField(value = "E-mail", onValueChange = {}, modifier = Modifier.clip(shape = RoundedCornerShape(10.dp, 10.dp, 10.dp, 10.dp)) )
                    Spacer(modifier = Modifier.padding(5.dp))
                    TextField(value = "Password", onValueChange = {}, modifier = Modifier.clip(shape = RoundedCornerShape(10.dp, 10.dp, 10.dp, 10.dp)) )
                    Spacer(modifier = Modifier.padding(15.dp))
                    Button(onClick = onSignUpButtonClicked) {
                        Text(text = "Sign Up")
                    }
                    Spacer(modifier = Modifier.padding(5.dp))
                    Button(onClick = onContinueWithGoogleButtonClicked) {
                        Text(text = "Continue with Google")
                    }
                    Spacer(modifier = Modifier.padding(5.dp))
                    Button(onClick = onLogInButtonClicked) {
                        Text(text = "Log in")
                    }
                }
            }
            Spacer(modifier = Modifier.weight(1f))
        }
    }

}


@Preview
@Composable
fun SignUpScreenPreview(){
    SignUpScreen(
        onSignUpButtonClicked = {},
        onLogInButtonClicked = {},
        onContinueWithGoogleButtonClicked = {}
    )
}