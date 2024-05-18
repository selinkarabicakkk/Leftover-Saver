package com.example.leftover

import androidx.annotation.StringRes
import androidx.compose.foundation.layout.fillMaxSize
import androidx.compose.foundation.layout.padding
import androidx.compose.foundation.rememberScrollState
import androidx.compose.foundation.verticalScroll
import androidx.compose.material.icons.Icons
import androidx.compose.material.icons.filled.ArrowBack
import androidx.compose.material3.CenterAlignedTopAppBar
import androidx.compose.material3.ExperimentalMaterial3Api
import androidx.compose.material3.Icon
import androidx.compose.material3.IconButton
import androidx.compose.material3.Scaffold
import androidx.compose.material3.Text
import androidx.compose.runtime.Composable
import androidx.compose.runtime.collectAsState
import androidx.compose.runtime.getValue
import androidx.compose.ui.Modifier
import androidx.compose.ui.res.dimensionResource
import androidx.compose.ui.res.stringResource
import androidx.lifecycle.viewmodel.compose.viewModel
import androidx.navigation.compose.NavHost
import androidx.navigation.compose.composable
import androidx.navigation.compose.currentBackStackEntryAsState
import androidx.navigation.compose.rememberNavController


enum class LeftOverScreen() {
    LogIn,SignUp,HomePage,DesiredStore,Filter,Restaurant,Basket,Profile,Reservations,ReservationsDetails,Favourite,AccountSettings,NewLocation,SavedLocations
}



@Composable
fun LeftOverApp() {

    val navController = rememberNavController()

    val backStackEntry by navController.currentBackStackEntryAsState()

    /*
    val currentScreen = LeftOverScreen.valueOf(
        backStackEntry?.destination?.route ?: LeftOverScreen.Profile.name
    )
    //val viewModel: OrderViewModel = viewModel( )
    */


    NavHost(
        navController = navController,
        startDestination = LeftOverScreen.HomePage.name
    ) {
        composable(route = LeftOverScreen.LogIn.name) {
            LogInScreen(
                onLogInButtonClicked = {
                    navController.navigate(LeftOverScreen.HomePage.name)
                },
                onSignUpButtonClicked = {
                    navController.navigate(LeftOverScreen.SignUp.name)
                },
            )
        }
        composable(route = LeftOverScreen.SignUp.name) {
            SignUpScreen(
                onLogInButtonClicked = {
                    navController.navigate(LeftOverScreen.LogIn.name)
                },
                onSignUpButtonClicked = {
                    navController.navigate(LeftOverScreen.HomePage.name)
                },
                onContinueWithGoogleButtonClicked = {
                    navController.navigate(LeftOverScreen.SignUp.name)
                }
            )
        }

        composable(route = LeftOverScreen.HomePage.name) {
            HomePageScreen(
                onHomePageButtonClicked = {
                    navController.navigate(LeftOverScreen.HomePage.name)
                },
                onFavouritePageButtonClicked = {
                    navController.navigate(LeftOverScreen.Favourite.name)
                },
                onBasketScreensButtonClicked = {
                    navController.navigate(LeftOverScreen.Basket.name)
                },
                onProfilePageButtonClicked = {
                    navController.navigate(LeftOverScreen.Profile.name)
                },
                onRestaurantBoxClicked = {
                    navController.navigate(LeftOverScreen.Restaurant.name)
                },
                onLocationButtonClicked = {
                    navController.navigate(LeftOverScreen.SavedLocations.name)
                }
            )
        }

        composable(route = LeftOverScreen.DesiredStore.name) {
            DesiredStoreScreen(
                onHomePageButtonClicked = {
                    navController.navigate(LeftOverScreen.HomePage.name)
                },
                onBasketScreensButtonClicked = {
                    navController.navigate(LeftOverScreen.Basket.name)
                },
                onFavouritePageButtonClicked = {
                    navController.navigate(LeftOverScreen.Favourite.name)
                },
                onProfilePageButtonClicked = {
                    navController.navigate(LeftOverScreen.Profile.name)
                },
                onFilterRowClicked = {
                    navController.navigate(LeftOverScreen.Filter.name)
                },
                onRestaurantBoxClicked = {
                    navController.navigate(LeftOverScreen.Restaurant.name)
                },
                onLocationButtonClicked = {
                    navController.navigate(LeftOverScreen.SavedLocations.name)
                }
            )
        }

        composable(route = LeftOverScreen.Filter.name) {
            FilterScreen(
            )
        }

        composable(route = LeftOverScreen.Restaurant.name) {
            RestaurantScreen(
                onHomePageButtonClicked = {
                    navController.navigate(LeftOverScreen.HomePage.name)
                },
                onBasketScreensButtonClicked = {
                    navController.navigate(LeftOverScreen.Basket.name)
                },
                onFavouritePageButtonClicked = {
                    navController.navigate(LeftOverScreen.Favourite.name)
                },
                onProfilePageButtonClicked = {
                    navController.navigate(LeftOverScreen.Profile.name)
                },
                onLocationButtonClicked = {
                    navController.navigate(LeftOverScreen.SavedLocations.name)
                }
            )
        }

        composable(route = LeftOverScreen.Basket.name) {
            BasketScreen(
                onHomePageButtonClicked = {
                    navController.navigate(LeftOverScreen.HomePage.name)
                },
                onReservationScreensButtonClicked = {
                    navController.navigate(LeftOverScreen.Reservations.name)
                },
                onFavouritePageButtonClicked = {
                    navController.navigate(LeftOverScreen.Favourite.name)
                },
                onProfilePageButtonClicked = {
                    navController.navigate(LeftOverScreen.Profile.name)
                },
                onReserveButtonClicked = {
                    navController.navigate(LeftOverScreen.Restaurant.name)
                },
                onLocationButtonClicked = {
                    navController.navigate(LeftOverScreen.SavedLocations.name)
                }
            )
        }

        composable(route = LeftOverScreen.Profile.name) {
            ProfileScreen(
                onHomePageButtonClicked = {
                    navController.navigate(LeftOverScreen.HomePage.name)
                },
                onBasketScreensButtonClicked = {
                    navController.navigate(LeftOverScreen.Basket.name)
                },
                onFavouritePageButtonClicked = {
                    navController.navigate(LeftOverScreen.Favourite.name)
                },
                onProfilePageButtonClicked = {
                    navController.navigate(LeftOverScreen.Profile.name)
                },
                onLogOutButtonClicked = {
                    navController.navigate(LeftOverScreen.LogIn.name)
                },
                onLocationButtonClicked = {
                    navController.navigate(LeftOverScreen.SavedLocations.name)
                }
            )
        }

        composable(route = LeftOverScreen.Reservations.name) {
            ReservationsScreen(
                onHomePageButtonClicked = {
                    navController.navigate(LeftOverScreen.HomePage.name)
                },
                onReservationScreensButtonClicked = {
                    navController.navigate(LeftOverScreen.Reservations.name)
                },
                onFavouritePageButtonClicked = {
                    navController.navigate(LeftOverScreen.Favourite.name)
                },
                onProfilePageButtonClicked = {
                    navController.navigate(LeftOverScreen.Profile.name)
                },
                onGoBackButtonClicked = {
                    navController.navigate(LeftOverScreen.HomePage.name)
                },
                onDetailsButtonClicked = {
                    navController.navigate(LeftOverScreen.ReservationsDetails.name)
                }
            )
        }

        composable(route = LeftOverScreen.ReservationsDetails.name) {
            ReservationsDetailsScreen(
                onHomePageButtonClicked = {
                    navController.navigate(LeftOverScreen.HomePage.name)
                },
                onReservationScreensButtonClicked = {
                    navController.navigate(LeftOverScreen.Reservations.name)
                },
                onFavouritePageButtonClicked = {
                    navController.navigate(LeftOverScreen.Favourite.name)
                },
                onProfilePageButtonClicked = {
                    navController.navigate(LeftOverScreen.Profile.name)
                },
                onGoBackButtonClicked = {
                    navController.navigate(LeftOverScreen.Reservations.name)
                },
                onLocationButtonClicked = {
                    navController.navigate(LeftOverScreen.SavedLocations.name)
                }
            )
        }

        composable(route = LeftOverScreen.Favourite.name) {
            FavouriteScreen(
                onHomePageButtonClicked = {
                    navController.navigate(LeftOverScreen.HomePage.name)
                },
                onBasketScreensButtonClicked = {
                    navController.navigate(LeftOverScreen.Basket.name)
                },
                onFavouritePageButtonClicked = {
                    navController.navigate(LeftOverScreen.Favourite.name)
                },
                onProfilePageButtonClicked = {
                    navController.navigate(LeftOverScreen.Profile.name)
                },
                onRestaurantBoxClicked = {
                    navController.navigate(LeftOverScreen.Restaurant.name)
                },
                onLocationButtonClicked = {
                    navController.navigate(LeftOverScreen.SavedLocations.name)
                }
            )
        }

        composable(route = LeftOverScreen.AccountSettings.name) {
            AccountSettingsScreen(
                onLocationsButtonClicked = {
                    navController.navigate(LeftOverScreen.SavedLocations.name) },
                onSaveButtonClicked = {
                    navController.navigate(LeftOverScreen.Profile.name)
                }
            )
        }

        composable(route = LeftOverScreen.NewLocation.name) {
            NewLocationScreen(
                onBackButtonClicked = { navController.navigate(LeftOverScreen.SavedLocations.name) },
                onSaveMyLocationButtonClicked = { navController.navigate(LeftOverScreen.SavedLocations.name) }
            )
        }

        composable(route = LeftOverScreen.SavedLocations.name) {
            SavedLocationsScreen(
                onBackButtonClicked = { navController.navigate(LeftOverScreen.HomePage.name) },
                onNewLocationButtonClicked = { navController.navigate(LeftOverScreen.NewLocation.name) },
                onEditButtonClicked = { navController.navigate(LeftOverScreen.NewLocation.name) }
            )
        }




    }



}


