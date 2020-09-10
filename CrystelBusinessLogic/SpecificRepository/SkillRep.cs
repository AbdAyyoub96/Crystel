using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccsess.Entity;
using DataAccsess.Generic;
using DataAccsess.Context;

namespace CrystelBusinessLogic.SpecificRepository
{
    public class SkillRep:ISkillRep
    {
        public void Insert(Skills skills)
        {

            IGenericCrystel<Skills> modu = new GenericCrystel<Skills>();
            modu.Insert(skills);
        }
        public void Update(Skills skills)
        {
            IGenericCrystel<Skills> modu = new GenericCrystel<Skills>();
            modu.Update(skills);
        }



        public List<Skills> LoadMain()
        {
            CrystelContext con = new CrystelContext();
            List<Skills> MainProject = (from a in con.Skills
                                        where a.Id != 1
                                        select a).ToList<Skills>();
            return MainProject;
        }

        public void Delete(int x)
        {
            IGenericCrystel<Skills> modu = new GenericCrystel<Skills>();
            modu.Delete(x);
        }
        public Skills Load(int x)
        {
            IGenericCrystel<Skills> modu = new GenericCrystel<Skills>();
            return modu.Load(x);
        }
    }
}
