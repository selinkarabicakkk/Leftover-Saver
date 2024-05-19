using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace CleanArchitecture.Core.Entities
{

    public class BasketItem: AuditableBaseEntity
    {
        public int Id { get; set; }
        // Foreign key to Product
        public int PieceNumber { get; set; }
        public string BasketID { get; set; }

        // Other properties
    }
}