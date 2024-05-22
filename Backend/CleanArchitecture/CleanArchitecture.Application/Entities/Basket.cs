using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace CleanArchitecture.Core.Entities
{

    public class Basket:AuditableBaseEntity
    {
         public int itemID { get; set; } 
        public double price { get; set; }
        public int customerId { get; set; }
        public List<BasketItem> BasketItems { get; set; }

    }
}