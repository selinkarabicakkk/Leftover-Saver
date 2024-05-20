using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitecture.Core.Features.Address.Query.GetAllAddresses
{
    public class GetAllAddressesParameter
    {
        public int PageSize { get; set; }
        public int PageNumber { get; set; }
    }
}
