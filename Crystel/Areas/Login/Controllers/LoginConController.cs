using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DataAccsess.Entity;
using CrystelBusinessLogic.SpecificRepository;

namespace Crystel.Areas.Login.Controllers
{
    public class LoginConController : Controller
    {
        // GET: Login/LoginCon
        public ActionResult LoginView()

        {
            //Login obj = new Login();
            Employee obj = new Employee();
            obj.FullName = Request.Form["txtusername"];
            obj.Password = Request.Form["txtPassword"];


            return View();
        }

            public ActionResult login()

        {

            return View();
        }
       
    }
}