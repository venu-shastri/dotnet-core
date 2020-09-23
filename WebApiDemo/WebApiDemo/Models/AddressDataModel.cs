using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiDemo.Models
{
    public class AddressDataModel
    {
        public string Street { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Pincode { get; set; }
    }
}
