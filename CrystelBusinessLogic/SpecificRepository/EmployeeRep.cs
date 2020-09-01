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
    public class EmployeeRep : IEmployeeRep
    {
        public void Insert(Employee emp)
        {
            
            IGenericCrystel<Employee> modu = new GenericCrystel<Employee>();
            modu.Insert(emp);
        }
        public void Update(Employee emp)
        {
            IGenericCrystel<Employee> modu = new GenericCrystel<Employee>();
            modu.Update(emp);
        }

       

        public List<Employee> LoadMain()
        {
            CrystelContext con = new CrystelContext();
            List<Employee> MainEmployee = (from a in con.Employees
                                        select a).ToList<Employee>();
            return MainEmployee;
        }

        public void Delete(int x)
        {
            IGenericCrystel<Employee> modu = new GenericCrystel<Employee>();
            modu.Delete(x);
        }
        public Employee Load(int x)
        {
            IGenericCrystel<Employee> modu = new GenericCrystel<Employee>();
            return modu.Load(x);
        }
    }
}
