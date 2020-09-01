using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccsess.Entity;

namespace CrystelBusinessLogic.SpecificRepository
{
  public  interface IprojectRep
    {
        void Insert(ProjectName project);
        void Update(ProjectName project);
        List<ProjectName> LoadMain();
        void Delete(int x);
        ProjectName Load(int x);
    }
}
