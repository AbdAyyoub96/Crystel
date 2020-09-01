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
    public class EmployeeController : ApiController
    {
        [HttpGet]
        [Route("api/Employee/departmentRep")]
        public List<Department> departments()
        {
            IDepartmentRep departmentRep = new DepartmentRep();
            return departmentRep.LoadMain();
        }
        [HttpGet]
        [Route("api/Employee/projectRep")]
        public List<ProjectName> projectNames()
        {
            IprojectRep projectRep = new ProjectRep();
            return projectRep.LoadMain();
        }
        [HttpGet]
        [Route("api/Employee/jobRep")]
        public List<Job_Title> job_Titles()
        {
            IJobRep jobRep  = new JobRep();
            return jobRep.LoadMain();
        }

    }
}
