using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiDemo.Models
{
    public class PatientDataModel
    {
        public string MRN { get; set; }
        public string Name { get; set; }
        public string ContactNumber { get; set; }
        public int Age { get; set; }
        public AddressDataModel Address { get; set; }

    }
}
