using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace DataAccsess.Entity
{
    public class Employee
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        [ForeignKey("department")]
        public int Department_id { get; set; }
        [ForeignKey("projectName")]
        public int Project_Name_id { get; set; }
        [ForeignKey("jobTitle")]
        public int Job_Title_id { get; set; }
        public string National_id { get; set; }
        public DateTime Birthdate { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public int Gender { get; set;}
        public string CompanyEmail { get; set; }
        public string Password { get; set; }
        public int status { get; set; }
        [ForeignKey("skills")]
        public int skils_id { get; set; }
        public Skills skills { get; set; }
        public Department department { get; set; }
        public ProjectName projectName { get; set; }
        public Job_Title jobTitle { get; set; }
        public List<Schedule> schedules { get; set; }
    }
}
