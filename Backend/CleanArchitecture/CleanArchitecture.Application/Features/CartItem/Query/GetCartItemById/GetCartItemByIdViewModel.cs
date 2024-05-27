using System;
using System.Collections.Generic;
using System.Text;
using CleanArchitecture.Core.Features.CartItem.Query.GetAllCartItems;

namespace CleanArchitecture.Core.Features.CartItem.Query.GetCartItemById
{
    public class GetCartItemByIdViewModel
    {
        public int CartItemId { get; set; }
        public int ItemId { get; set; }
        public string ItemName { get; set; }
        public double Price { get; set; }
        public string Picture { get; set; }
        public string Explanation { get; set; }
        public int PieceNumber { get; set; }
    }
}

