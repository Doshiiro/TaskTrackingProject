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
            EmployeeRepository employeeRepository = new EmployeeRepository();
            Employee DtoEmp = new Employee()
            {
                UserName = kullaniciAdiTxt.Texts,
                Password=passwordTxt.Texts,
                Departman=departmanTxt.Texts,
                Email=emailTxt.Texts,
            };
            if (DtoEmp!=null)
            {
                EmployeeValidation validationRules = new EmployeeValidation();
                ValidationResult result = validationRules.Validate(DtoEmp);
                IList<ValidationFailure> failures = result.Errors;
                if (!result.IsValid)
                {
                    foreach(ValidationFailure failure in failures)
                    {
                        MessageBox.Show(failure.ErrorMessage,"Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }
                await employeeRepository.Create(DtoEmp);
                MessageBox.Show("kullanıcı eklendi");
            }
            
        }
       
    }
}
