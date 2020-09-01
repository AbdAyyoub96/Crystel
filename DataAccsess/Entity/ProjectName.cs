using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataAccsess.Entity
{
   public class ProjectName
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Employee> employees { get; set; }
        public List<Skills> skills { get; set; }
    }
}
