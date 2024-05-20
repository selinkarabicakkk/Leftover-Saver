using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace CleanArchitecture.Core.Entities
{

    public class Reservation: AuditableBaseEntity
    {
        public int RestaurantId { get; set; }
        public double totalPrice { get; set; }
        public int itemId { get; set; }
        public bool isDelivered { get; set; }
        public bool isCancelled { get; set; }

        public Restaurant Restaurant { get; set; }
        public List<Item> Items { get; set; }

        // Other properties
    }
}