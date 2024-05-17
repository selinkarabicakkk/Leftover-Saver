using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace CleanArchitecture.Core.Entities
{

    public class Reservation: AuditableBaseEntity
    {
        public string reservationID { get; set; }
        public string UserName { get; set; } // Foreign key to Business
        public string RestaurantID { get; set; }
        public double price { get; set; }

        // Other properties
    }
}