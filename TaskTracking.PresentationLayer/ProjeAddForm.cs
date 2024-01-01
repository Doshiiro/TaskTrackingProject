using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TaskTracking.PresentationLayer.DAL;
using TaskTracking.PresentationLayer.Entities;

namespace TaskTracking.PresentationLayer
{
    public partial class ProjeAddForm : Form
    {
        public ProjeAddForm()
        {
            InitializeComponent();
        }
        private void ProjeAddForm_Load(object sender, EventArgs e)
        {
            using (var context = new TaskTrackingContext())
            {
                var employeesWithAccess = context.Employees.Where(emp => emp.Access == 2).ToList();
                foreach (var employee in employeesWithAccess)
                {
                    metroComboBox1.Items.Add(employee.UserName);
                }
            }

            if (metroComboBox1.Items.Count > 0)
            {
                metroComboBox1.SelectedIndex = 0;
            }


        }
        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            TaskTrackingContext context = new TaskTrackingContext();
            var data = context.Employees.FirstOrDefault(emp => emp.UserName == metroComboBox1.Text && emp.Access == 2);

            ProjectEntity _project = new ProjectEntity()
            {
                ProjectName = projeNameTxt.Texts,
                projectEmp_ID = data.emp_ID,
                DepartmentID = data.DepartmentID
            };
            context.Add(_project);
            context.SaveChanges();
            MessageBox.Show("Proje Eklendi");

            projeNameTxt.Texts = "";
        }

    }
}
