using CrystelBusinessLogic.SpecificRepository;
using DataAccsess.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CrystelWebApi.Controllers
{
    public class ProjectController : ApiController
    {
        [HttpGet]
        [Route("api/Project/MainProject")]
        public List<ProjectName> LoadMain()
        {
            IprojectRep iproject = new ProjectRep();
            return iproject.LoadMain();
        }
    }
}
