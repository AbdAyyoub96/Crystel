using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace DataAccsess.Entity
{
   public class Schedule
    {
        public int Id { get; set; }
        public DateTime ScheduleDate { get; set; }
        [ForeignKey("workPlace")]
        public int Work_place_id { get; set; }
        public string Shift_start { get; set; }
        public string Shift_End { get; set; }
        public string totalHour { get; set; }
        [ForeignKey("employee")]
        public int Employee_id { get; set; }
        public Employee employee { get; set; }
        public WorkPlace workPlace { get; set; }

    }
}
