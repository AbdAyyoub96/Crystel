using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccsess.Entity
{
   public class WorkPlace
    {
        public int Id { get; set; }
        public string Time { get; set; }
        public List<Schedule> schedules { get; set; }
    }
}
