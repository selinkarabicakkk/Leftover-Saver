using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;


namespace CleanArchitecture.Core.Entities
{

    public class Reservation: AuditableBaseEntity
    {
        [ForeignKey("Restaurant")]
        public int RestaurantId { get; set; }
        public Restaurant Restaurant { get; set; }

       

        [ForeignKey("Item")]
        public int itemId { get; set; }
        public Item Items { get; set; }

        public bool isDelivered { get; set; }
        public bool isCancelled { get; set; }
        public double totalPrice { get; set; }
        public string ReservationCode { get; set; }



        // Other properties
    }
}