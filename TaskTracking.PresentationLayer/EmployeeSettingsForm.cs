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

namespace TaskTracking.PresentationLayer
{
    public partial class EmployeeSettingsForm : Form
    {
        static public int empid;
        public EmployeeSettingsForm()
        {
            InitializeComponent();
        }
        private void EmployeeSettingsForm_Load(object sender, EventArgs e)
        {
            using (TaskTrackingContext context = new TaskTrackingContext())
            {
                var data = context.Employees.Where(emp => emp.emp_ID == empid).FirstOrDefault();

                emailTxt.Texts = data.Email;
            }
        }
        private void rjButton2_Click(object sender, EventArgs e)
        {
            using (TaskTrackingContext context = new TaskTrackingContext())
            {
                var data = context.Employees.Where(emp => emp.emp_ID == empid).FirstOrDefault();
                empidtxt.Text = empid.ToString();

                Employee DtoEmp = new Employee()
                {
                    emp_ID = Convert.ToInt32(empidtxt.Text),
                    UserName = data.UserName,
                    Password = passwordTxt.Texts,
                    DepartmentID = data.DepartmentID,
                    Email = emailTxt.Texts,
                    Access = data.Access
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

                    if (oldPasstxt.Texts == newpasstxt.Texts && oldPasstxt.Texts != "" && newpasstxt.Texts != "")
                    {
                        if (oldPasstxt.Texts.Length > 2 && newpasstxt.Texts.Length > 2)
                        {
                            if (passwordTxt.Texts == data.Password)
                            {
                                data.Password = newpasstxt.Texts;
                                data.Email = emailTxt.Texts;

                                context.SaveChanges();
                                MessageBox.Show("Kullanıcı güncellendi");
                            }
                            else
                            {
                                MessageBox.Show("Girdiğiniz eski şifre yanlış");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Şifre 2 karakterden fazla olmalıdır");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Lütfen yeni şifre alanlarını doğru giriniz");
                    }
                }
            }
        }



    }
}
