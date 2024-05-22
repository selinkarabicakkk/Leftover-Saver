using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace CleanArchitecture.Core.Entities
{

    public class BasketItem: Item
    {
        public int BasketId { get; set; }
        public int pieceNumber { get; set; }
        public Basket Basket { get; set; }  
        public Item Item { get; set; }

       
        
    }
}