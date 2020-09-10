using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Crystel.Areas.Agent.Controllers
{
    public class ScheduleController : Controller
    {
        // GET: Agent/Schedule
        public ActionResult ScheduleList()
        {
            return View();
        }
    }
}