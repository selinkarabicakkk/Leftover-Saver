package com.example.leftover

data class SignUp(
    val confirmPassword: String,
    val email: String,
    val firstName: String,
    val lastName: String,
    val password: String,
    val userName: String
)