using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccsess.Entity;


namespace CrystelBusinessLogic.SpecificRepository
{
   public interface ISkillRep
    {
        void Insert(Skills skills);
        void Update(Skills skills);
        List<Skills> LoadMain();
        void Delete(int x);
        Skills Load(int x);
    }
}
