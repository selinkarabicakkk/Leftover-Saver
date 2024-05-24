using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace CleanArchitecture.Core.Entities
{

    public class CartItem: Item
    {
        public int CartId { get; set; }
        public int pieceNumber { get; set; }
        public Cart Cart { get; set; }  
        public Item Item { get; set; }

        
    }
}