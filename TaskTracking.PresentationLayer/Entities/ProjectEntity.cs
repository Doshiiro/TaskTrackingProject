using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskTracking.PresentationLayer.Entities
{
    public class ProjectEntity
    {
        [Key]
        public int ProjectID { get; set; }
        public string ProjectName { get; set; }
        public int? DepartmentID { get; set; }
        public Department Department { get; set; }
        public int projectEmp_ID { get; set; }
        public Employee Employees { get; set; }

    }
}
