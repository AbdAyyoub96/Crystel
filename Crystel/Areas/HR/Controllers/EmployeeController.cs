using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Crystel.Areas.HR.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: HR/Employee
        public ActionResult NewEmployee()
        {
            return View();
        }
       
    }
}