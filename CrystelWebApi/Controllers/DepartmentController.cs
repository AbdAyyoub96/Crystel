using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using DataAccsess.Entity;
using CrystelBusinessLogic.SpecificRepository;

namespace CrystelWebApi.Controllers
{
    public class DepartmentController : ApiController
    {
        [HttpPost]
        [Route("api/Department/Save")]
        public void Save(Department mod)
        {
            IDepartmentRep modu = new DepartmentRep();
            modu.Insert(mod);
        }

        [HttpGet]
        [Route("api/Department/MainDept")]
        public List<Department> LoadMain()
        {
            IDepartmentRep department = new DepartmentRep();
            return department.LoadMain();
        }
    }
}
