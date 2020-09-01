using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccsess.Entity;

namespace CrystelBusinessLogic.SpecificRepository
{
   public interface IDepartmentRep
    {
        void Insert(Department dept);
        void Update(Department dept);
        List<Department> LoadMain();
        void Delete(int x);
        Department Load(int x);
    }
}
