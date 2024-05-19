using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace CleanArchitecture.Core.Entities
{

    public class Favourites: AuditableBaseEntity
    {
        public string RestaurantID { get; set; }
        public string UserName { get; set; }


        // Other properties
    }
}