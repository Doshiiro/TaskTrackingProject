using Microsoft.EntityFrameworkCore;
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
using TaskTracking.PresentationLayer.Entities;
using TaskTracking.PresentationLayer.Management.Concrete;

namespace TaskTracking.PresentationLayer
{
    public partial class ProjectEventForm : Form
    {
        static public int ProjeEventEmpID2;

        public ProjectEventForm()
        {
            InitializeComponent();
        }
        private void ProjectEventForm_Load(object sender, EventArgs e)
        {
            ProjectRepository projectRepository = new ProjectRepository();
            var datacal = projectRepository.GetAll();

            TaskTrackingContext context = new TaskTrackingContext();

            foreach (var item in datacal)
            {
                //yöneticiler sadece kendi projelerini seçebilicek.
                if (ProjeEventEmpID2 == item.projectEmp_ID)
                {
                    metroComboBox1.Items.Add(item.ProjectName);
                }

            }

            var employeeList = context.Employees.ToList();
            var dataemp = context.Employees.Where(emp => emp.emp_ID == ProjeEventEmpID2).FirstOrDefault();

            foreach (var item in employeeList)
            {
                //aynı departmanda olan kullanıcılar gözükecek.
                if (dataemp.DepartmentID == item.DepartmentID)
                {
                    metroComboBox2.Items.Add(item.UserName);
                }
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            TaskTrackingContext context = new TaskTrackingContext();
            var empdata = context.Employees.FirstOrDefault(emp => emp.UserName == metroComboBox2.Text);
            var projedata = context.Projects.FirstOrDefault(p => p.ProjectName == metroComboBox1.Text);

            if (empdata == null || projedata == null || txtDescription.Texts == "")
            {
                MessageBox.Show("Lütfen bütün alanları doldurunuz");
                return;
            }

            ProjeEvent _proje = new ProjeEvent()
            {
                EventEmpFK_ID = empdata.emp_ID,
                ProjeDescription = txtDescription.Texts,
                ProjectID = projedata.ProjectID
            };

            context.Add(_proje);
            context.SaveChanges();

            txtDescription.Texts = "";
            MessageBox.Show("Proje Görevi Eklendi");
        }

    }
}
