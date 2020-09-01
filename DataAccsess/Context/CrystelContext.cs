using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using DataAccsess.Entity;

namespace DataAccsess.Context
{
   public class CrystelContext:DbContext
    {
        public CrystelContext(): base("name = Crystel")
        {

        }
        public virtual DbSet<Department> Departments { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Job_Title> Job_Titles { get; set; }
        public virtual DbSet<ProjectName> ProjectNames { get; set; }
        public virtual DbSet<Schedule> Schedules { get; set; }
        public virtual DbSet<Skills> Skills  { get; set; }
        public virtual DbSet<WorkPlace> WorkPlaces { get; set; }
    }
}
