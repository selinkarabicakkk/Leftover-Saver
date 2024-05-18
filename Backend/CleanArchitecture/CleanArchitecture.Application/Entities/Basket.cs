using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace CleanArchitecture.Core.Entities
{

    public class Basket:AuditableBaseEntity
    {
        public string BasketID { get; set; }
        public string UserName { get; set; }
        public string itemID { get; set; } // Foreign key to Business
        public double price { get; set; }

        // Other properties
    }
}