using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskTracking.PresentationLayer.Entities
{
    public class ProjeEvent
    {
        [Key]
        public int ProjeEventID { get; set; }
        public string ProjeDescription { get; set; }

        public bool Status { get; set; }
        //Kullanıcı adı
        public int EventEmpFK_ID { get; set; }
        public Employee Employees { get; set; }

        //eventler ile ilişkili proje
        public int ProjectID { get; set; }
        public ProjectEntity Project { get; set; }



    }
}
