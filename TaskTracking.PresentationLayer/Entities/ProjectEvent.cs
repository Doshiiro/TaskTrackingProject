using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskTracking.PresentationLayer.Entities
{
    public class ProjectEvent
    {
        [Key]
        public int ProjectEventID { get; set; }
        public string EventDescription { get; set; }
        public int projectEmp_ID { get; set; }
        public Employee Employees { get; set; }

    }
}
