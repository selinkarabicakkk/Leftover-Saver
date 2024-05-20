using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitecture.Core.Features.Address.Query.GetAllAddresses
{
    public class GetAllAddressesViewModel
    {

        public int Id { get; set; }
        public string UserName { get; set; }
        public string AddressDefinition { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
        public string AddressTitle { get; set; }
    }
}
