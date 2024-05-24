using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;



namespace CleanArchitecture.Core.Entities
{
    public class Customer : AuditableBaseEntity
    {
        public string Id {  get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }


        public int AdressId { get; set; }
        public int CartId { get; set; }
        public int FavouritesId { get; set; }
        public int ReservationId { get; set; }

        public Address Address { get; set; }
        public Favourites Favorites { get; set; }
        public Cart Cart { get; set; }
        public Reservation Reservation { get; set; }


        //Database Modified

    }
}