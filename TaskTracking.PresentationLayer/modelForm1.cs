using FluentValidation.Results;
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
using TaskTracking.PresentationLayer.Entities.Validations;
using TaskTracking.PresentationLayer.Management.Concrete;

namespace TaskTracking.PresentationLayer
{
    public partial class modelForm1 : Form
    {
        public modelForm1()
        {
            InitializeComponent();
        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void rjButton2_Click(object sender, EventArgs e)
        {

            TaskTrackingContext context = new TaskTrackingContext();
            // Department tablosundan veritabanında Departman adına sahip olanı bul
            var selectedDepID = context.Departments.FirstOrDefault(d => d.DepartmentName == metroComboBox1.Text);

            int accessID;

            if (metroComboBox2.Text == "Yönetici")
                accessID = 2;
            else
                accessID = 0;

            EmployeeRepository employeeRepository = new EmployeeRepository();
            Employee DtoEmp = new Employee()
            {
                UserName = kullaniciAdiTxt.Texts,
                Password = passwordTxt.Texts,
                DepartmentID = selectedDepID.DepID,
                Email = emailTxt.Texts,
                Access = accessID
            };
            if (DtoEmp != null)
            {
                EmployeeValidation validationRules = new EmployeeValidation();
                ValidationResult result = validationRules.Validate(DtoEmp);
                IList<ValidationFailure> failures = result.Errors;
                if (!result.IsValid)
                {
                    foreach (ValidationFailure failure in failures)
                    {
                        MessageBox.Show(failure.ErrorMessage, "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }
                await employeeRepository.Create(DtoEmp);
                MessageBox.Show("kullanıcı eklendi");
            }

        }
        private void modelForm1_Load(object sender, EventArgs e)
        {
            using (var context = new TaskTrackingContext())
            {
                List<Department> data = context.Departments.ToList();
                foreach (var department in data)
                {
                    metroComboBox1.Items.Add(department.DepartmentName);
                }
            }
            if (metroComboBox1.Items.Count > 0)
            {
                metroComboBox1.SelectedIndex = 0;
            }
            if (metroComboBox2.Items.Count > 0)
            {
                metroComboBox2.SelectedIndex = 0;
            }

        }

        private void metroComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
