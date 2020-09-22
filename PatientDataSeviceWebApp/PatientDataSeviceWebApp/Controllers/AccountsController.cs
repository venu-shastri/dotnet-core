using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace PatientDataSeviceWebApp.Controllers
{
    public class AccountsController : Controller
    {
        public Boolean Login(string userName,string password)
        {
            if (userName == "tom" && password == "tom@123")
            {
                return true;
            }
            
                return false;
            
        }

        public ContentResult Signup(string userName,string passord, string email)
        {
            return Content($"{userName} with {email} Registered Successfully");
        }
    }
}
