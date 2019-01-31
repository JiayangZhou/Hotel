using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyUI.Models
{
    public class Address
    {
        public int AddressId { get; set; }

        public string StreetAddress { get; set; }
        public string City { get; set; }
        public string State { get; set; }

        public string ZipCode { get; set; }
        
        public string FullAddress
        {
            get
            {
                return $"{StreetAddress}, {City}, {State} {ZipCode}";
            }
        }
    }
}
