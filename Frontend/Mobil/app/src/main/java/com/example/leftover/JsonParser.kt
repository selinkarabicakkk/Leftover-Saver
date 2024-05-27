package com.example.leftover

import org.json.JSONArray
import org.json.JSONObject


    class JsonParser(jsonString: String) {
        private val jsonObject: JSONObject = JSONObject(jsonString)

        private fun parseItems(): List<Restaurant> {
            val itemsArray: JSONArray = jsonObject.getJSONArray("data")
            val itemsList = mutableListOf<Restaurant>()

            for (i in 0 until itemsArray.length()) {
                val itemObject = itemsArray.getJSONObject(i)
                val id = itemObject.getInt("id")
                val name = itemObject.getString("name")
                val email = itemObject.getString("email")
                val password = itemObject.getString("password")
                val phoneNumber = itemObject.getString("phoneNumber")
                val streetInformation = itemObject.getString("streetInformation")
                val city = itemObject.getString("city")
                val postalCode = itemObject.getString("postalCode")
                val country = itemObject.getString("country")
                val storeType = itemObject.getString("storeType")

                val item = Restaurant(id, name, email, password, phoneNumber, streetInformation, city,postalCode,country,storeType)
                itemsList.add(item)
            }

            return itemsList
        }

        fun displayItems() {
            val items = parseItems()

            for (item in items) {
                println("ID: ${item.id}")
                /*println("Title: ${item.title}")
                println("Image: ${item.image}")
                println("Content: ${item.content}")
                println("Tags: ${item.tags.joinToString(", ")}")*/
                println()
            }
        }
    }
