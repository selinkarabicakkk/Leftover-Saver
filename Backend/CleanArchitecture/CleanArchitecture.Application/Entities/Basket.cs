using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace CleanArchitecture.Core.Entities
{

    public class Basket:AuditableBaseEntity
    {
        //public List<BasketItem> Items { get; set; }
         public int itemID { get; set; } // Foreign key to Business
        public double price { get; set; }
        public List<BasketItem> BasketItems { get; set; }
        // Other properties
    }
}