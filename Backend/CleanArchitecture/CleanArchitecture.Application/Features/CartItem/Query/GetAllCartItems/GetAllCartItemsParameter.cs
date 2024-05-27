using CleanArchitecture.Core.Filters;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitecture.Core.Features.CartItem.Query.GetAllCartItems
{
    public class GetAllCartItemsParameter : RequestParameter
    {
        public int PageSize { get; set; }
        public int PageNumber { get; set; }
    }
}


   