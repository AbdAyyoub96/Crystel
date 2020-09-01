using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccsess.Entity;

namespace CrystelBusinessLogic.SpecificRepository
{
   public interface IEmployeeRep
    {
       
        void Insert(Employee emp);
        void Update(Employee emp);
        List<Employee> LoadMain();
        void Delete(int x);
        Employee Load(int x);
    }
}
