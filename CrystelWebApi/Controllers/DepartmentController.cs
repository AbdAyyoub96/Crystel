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
      
        [HttpGet]
        [Route("api/Department/MainDept")]
        public List<Department> LoadMain()
        {
            IDepartmentRep department = new DepartmentRep();
            return department.LoadMain();
        }
        [HttpPost]
        [Route("api/Department/Save")]
        public void Save(Department mod)
        {
            IDepartmentRep departmentRep  = new DepartmentRep();
            departmentRep.Insert(mod);
        }
        [HttpPost]
        [Route("api/Department/Update")]
        public void Update(Department mod)
        {
            IDepartmentRep departmentRep = new DepartmentRep();
            departmentRep.Update(mod);
        }
        [HttpGet]
        [Route("api/Department/Load")]
        public Department Load(int Id)
        {
            IDepartmentRep departmentRep = new DepartmentRep();
            return departmentRep.Load(Id);
        }
    }
}
