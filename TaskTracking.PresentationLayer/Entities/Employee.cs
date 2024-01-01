using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskTracking.PresentationLayer.Entities
{
    public class Employee
    {
        [Key]
        public int emp_ID { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }

        public int DepartmentID { get; set; }
        public Department Department { get; set; }
        public int Access { get; set; }

        public ICollection<CalendarEntity> Calendars { get; set; }
        public ICollection<ProjectEntity> Projects { get; set; }

        //public ICollection<ProjectEvent> ProjeEvent { get; set; }


    }
}
