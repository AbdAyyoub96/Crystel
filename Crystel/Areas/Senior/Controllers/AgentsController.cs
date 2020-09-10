using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Crystel.Areas.Senior.Controllers
{
    public class AgentsController : Controller
    {
        // GET: Senior/Agents
        public ActionResult NewAgents()
        {
            return View();
        }
    }
}