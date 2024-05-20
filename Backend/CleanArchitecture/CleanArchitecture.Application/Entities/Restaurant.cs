using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace CleanArchitecture.Core.Entities
{

    public class Restaurant: AuditableBaseEntity
    {
        public string Name { get; set; } // Foreign key to Business
        public string Email { get; set; }
        public string Password { get; set; }
        public string PhoneNumber { get; set; }
        public string AddressID { get; set; }
        public string StoreType { get; set; }

        public List<Item> Items { get; set; }
       

        // public LinkedList<Item> Items { get; set; }
        // Other properties
    }
}