using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitecture.Core.Features.Restaurant.Query.GetAllRestaurants
{
    public class GetAllRestaurantsViewModel
    {

        public string RestaurantID { get; set; }
        public string Name { get; set; } 
        public string Email { get; set; }
        public string Password { get; set; }
        public string PhoneNumber { get; set; }
        public string AddressID { get; set; }
        public string StoreType { get; set; }
        public double Rate { get; set; }
    }
}
