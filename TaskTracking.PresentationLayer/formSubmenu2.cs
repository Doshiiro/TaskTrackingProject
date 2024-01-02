using ReaLTaiizor.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TaskTracking.PresentationLayer.DAL;
using TaskTracking.PresentationLayer.DesignForm;
using TaskTracking.PresentationLayer.Management.Concrete;

namespace TaskTracking.PresentationLayer
{
    public partial class formSubmenu2 : Form
    {
        public formSubmenu2()
        {
            InitializeComponent();
        }
        static public int ProjeAccess;
        static public int ProjeDepID;
        static public int projeEventEmpID;
        private void formSubmenu2_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView1.AllowUserToAddRows = false;

            if (ProjeAccess == 0 || ProjeAccess == 2)
            {
                eventShowBtn.Visible = false;
            }
            if (ProjeAccess == 0)
            {
                eventbtn.Visible = false;
            }
            ProjectRepository projectRepository = new ProjectRepository();
            var datacal = projectRepository.GetAll();

            TaskTrackingContext context = new TaskTrackingContext();

            foreach (var item in datacal)
            {
                var empFKName = context.Employees.Where(emp => emp.emp_ID == item.projectEmp_ID).FirstOrDefault();
                var empDepName = context.Departments.Where(d => d.DepID == empFKName.DepartmentID).FirstOrDefault();

                //kullanıcının olduğu departmanda ki projeleri görebilir.
                if (ProjeDepID == item.DepartmentID)
                {
                    dataGridView1.Rows.Add(item.ProjectName, empFKName.UserName, empDepName.DepartmentName);
                }

            }

            //giren kullanıcının id'sini almam lazım eğer id proje event tablosu ile eşit ise dgw yazdır

            var projeEvents = context.ProjeEvent.ToList();
            int projeCount = 0;
            int projeEventCount = 0;
            int projeEventStatusFalse = 0;
            foreach (var item in projeEvents)
            {
                var projectName = context.Projects.Where(p => p.ProjectID == item.ProjectID).FirstOrDefault();

                if (projeEventEmpID == item.EventEmpFK_ID)
                {
                    dataGridView2.Rows.Add(item.ProjeDescription, projectName.ProjectName);
                    if (item.Status == true)
                    {
                        projeEventCount++;
                    }
                    else
                    {
                        projeEventStatusFalse++;
                    }

                }
                if (item.EventEmpFK_ID == projeEventEmpID)
                {
                    projeCount++;
                }
            }


            //ilişkili projeleri projeler label'a yazdırma
            projelbl.Text = "Çalışılan Projeler: " + projeCount.ToString();
            tasklbl.Text = projeEventCount.ToString() + "/" + projeEventStatusFalse.ToString();

        }
        private void eventShowBtn_Click(object sender, EventArgs e)
        {
            PopupFormDesign popupFormDesign = new PopupFormDesign();
            popupFormDesign.Popup<ProjeAddForm>();
        }

        private void eventbtn_Click(object sender, EventArgs e)
        {
            ProjectEventForm projectEventForm = new ProjectEventForm();
            ProjectEventForm.ProjeEventEmpID2 = projeEventEmpID;
            projectEventForm.Show();
        }
    }
}
