using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;



namespace CleanArchitecture.Core.Entities
{
    public class Address : AuditableBaseEntity
    {
       
        public string UserName { get; set; }
        public string AddressDefinition { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
        public string AddressTitle { get; set; }

        //Database Modified
    }
}
