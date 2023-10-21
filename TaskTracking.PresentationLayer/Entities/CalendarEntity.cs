using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskTracking.PresentationLayer.Entities
{
    public class CalendarEntity
    {

        [Key]
        public int calender_ID { get; set; }
        public string date { get; set; }
        public string events { get; set; }
        public string status { get; set; }

        public int emp_ID { get; set; }
        public Employee Employees { get; set; }
    }
}
