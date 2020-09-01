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
    public class JobRep:IJobRep
    {
        public void Insert(Job_Title job)
        {

            IGenericCrystel<Job_Title> modu = new GenericCrystel<Job_Title>();
            modu.Insert(job);
        }
        public void Update(Job_Title job)
        {
            IGenericCrystel<Job_Title> modu = new GenericCrystel<Job_Title>();
            modu.Update(job);
        }



        public List<Job_Title> LoadMain()
        {
            CrystelContext con = new CrystelContext();
            List<Job_Title> MainJob = (from a in con.Job_Titles
                                           select a).ToList<Job_Title>();
            return MainJob;
        }

        public void Delete(int x)
        {
            IGenericCrystel<Job_Title> modu = new GenericCrystel<Job_Title>();
            modu.Delete(x);
        }
        public Job_Title Load(int x)
        {
            IGenericCrystel<Job_Title> modu = new GenericCrystel<Job_Title>();
            return modu.Load(x);
        }
    }
}
