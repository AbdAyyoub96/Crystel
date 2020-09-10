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
    public class SkillController : ApiController
    {
        [HttpGet]
        [Route("api/Skill/MainSkill")]
        public List<Skills> LoadMain()
        {
            ISkillRep skillRep = new SkillRep();
            return skillRep.LoadMain();
        }
        [HttpPost]
        [Route("api/Skill/Save")]
        public void Save(Skills mod)
        {
            ISkillRep skillRep = new SkillRep();
            skillRep.Insert(mod);
        }
        [HttpPost]
        [Route("api/Skill/Update")]
        public void Update(Skills mod)
        {
            ISkillRep skillRep = new SkillRep();
            skillRep.Update(mod);
        }
        [HttpGet]
        [Route("api/Skill/Load")]
        public Skills Load(int Id)
        {
            ISkillRep skillRep  = new SkillRep();
            return skillRep.Load(Id);
        }
    }
}
