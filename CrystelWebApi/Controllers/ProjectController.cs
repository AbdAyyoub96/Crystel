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
        [HttpPost]
        [Route("api/Project/Save")]
        public void Save(ProjectName mod)
        {
            IprojectRep iproject = new ProjectRep();
            iproject.Insert(mod);
        }
        [HttpPost]
        [Route("api/Project/Update")]
        public void Update(ProjectName mod)
        {
            IprojectRep iproject = new ProjectRep();
            iproject.Update(mod);
        }
        [HttpGet]
        [Route("api/Project/LoadProject")]
        public ProjectName Load(int Id)
        {
            IprojectRep iproject  = new ProjectRep();
            return iproject.Load(Id);
        }
    }
}
