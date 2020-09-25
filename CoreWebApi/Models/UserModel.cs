using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreWebApi.Models
{
    public class UserModel
    {
        public string Uid { get; set; }
        public string Name { get; set; }

        public string Email { get; set; }
        public  string Password { get; set; }
    }
}
