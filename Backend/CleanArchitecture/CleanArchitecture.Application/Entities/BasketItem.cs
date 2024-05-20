using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace CleanArchitecture.Core.Entities
{

    public class BasketItem: Item
    {
        public Item Item { get; set; }
        // Other properties
    }
}