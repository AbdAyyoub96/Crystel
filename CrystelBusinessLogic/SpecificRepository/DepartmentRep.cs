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
   public class DepartmentRep:IDepartmentRep
    {
        public void Insert(Department dept)
        {

            IGenericCrystel<Department> modu = new GenericCrystel<Department>();
            modu.Insert(dept);
        }
        public void Update(Department dept)
        {
            IGenericCrystel<Department> modu = new GenericCrystel<Department>();
            modu.Update(dept);
        }



        public List<Department> LoadMain()
        {
            CrystelContext con = new CrystelContext();
            List<Department> MainDepartment = (from a in con.Departments
                                           select a).ToList<Department>();
            return MainDepartment;
        }

        public void Delete(int x)
        {
            IGenericCrystel<Department> modu = new GenericCrystel<Department>();
            modu.Delete(x);
        }
        public Department Load(int x)
        {
            IGenericCrystel<Department> modu = new GenericCrystel<Department>();
            return modu.Load(x);
        }
    }
}
