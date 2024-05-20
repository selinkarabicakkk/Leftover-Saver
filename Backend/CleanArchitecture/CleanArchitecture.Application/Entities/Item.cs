using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;




namespace CleanArchitecture.Core.Entities
{
    public class Item: AuditableBaseEntity
    { 
        public string itemName { get; set; }
        public double price { get; set; }
        public string picture { get; set; }
        public string explanation { get; set; }
        public Restaurant Restaurant { get; set; }
        // Other properties
    }
}