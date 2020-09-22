using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace PatientDataSeviceWebApp.Controllers
{
    //MVC Controller
    public class PatientDataController : Controller
    {
        //Action Method 
        //ContentResult - Generate Http Response 
        public ContentResult GetPatientName()
        {
            return Content("Hello from Patient Data Controller Action");
        }
        public ContentResult GetPatientByMrn(string mrn)
        {
            string name=this.RouteData.Values["name"] as string;
            return Content($"Hello from Patient Data Controller Action {mrn} and {name}" );
        }
    }
}
