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
    public class JobTitleController : ApiController
    {
        [HttpGet]
        [Route("api/JobTitle/MainJob")]
        public List<Job_Title> LoadMain()
        {
            IJobRep jobRep = new JobRep();
            return jobRep.LoadMain();
        }

        [HttpPost]
        [Route("api/JobTitle/Save")]
        public void Save(Job_Title mod)
        {
            IJobRep job  = new JobRep();
            job.Insert(mod);
        }
        [HttpPost]
        [Route("api/JobTitle/Update")]
        public void Update(Job_Title mod)
        {
            IJobRep job = new JobRep();
            job.Update(mod);
        }
        [HttpGet]
        [Route("api/JobTitle/Load/{id}")]
        public Job_Title Load(int id)
        {
            IJobRep modu = new JobRep();
            return modu.Load(id);
        }
    }
}
