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
   public class ProjectRep:IprojectRep
    {
        public void Insert(ProjectName project)
        {

            IGenericCrystel<ProjectName> modu = new GenericCrystel<ProjectName>();
            modu.Insert(project);
        }
        public void Update(ProjectName project)
        {
            IGenericCrystel<ProjectName> modu = new GenericCrystel<ProjectName>();
            modu.Update(project);
        }



        public List<ProjectName> LoadMain()
        {
            CrystelContext con = new CrystelContext();
            List<ProjectName> MainProject = (from a in con.ProjectNames
                                             where a.Id !=1
                                           select a).ToList<ProjectName>();
            return MainProject;
        }

        public void Delete(int x)
        {
            IGenericCrystel<ProjectName> modu = new GenericCrystel<ProjectName>();
            modu.Delete(x);
        }
        public ProjectName Load(int x)
        {
            IGenericCrystel<ProjectName> modu = new GenericCrystel<ProjectName>();
            return modu.Load(x);
        }
    }
}
