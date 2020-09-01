using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccsess.Entity;

namespace CrystelBusinessLogic.SpecificRepository
{
   public interface IJobRep
    {
        void Insert(Job_Title job);
        void Update(Job_Title job);
        List<Job_Title> LoadMain();
        void Delete(int x);
        Job_Title Load(int x);
    }
}
