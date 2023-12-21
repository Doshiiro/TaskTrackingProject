using System;
using System.Linq;
using System.Windows.Forms;
using takvim;
using TaskTracking.PresentationLayer.DAL;
using TaskTracking.PresentationLayer.Entities;
using TaskTracking.PresentationLayer.Management.Concrete;
using TaskTracking.PresentationLayer.Services;

namespace TaskTracking.PresentationLayer
{
    public partial class EventForm : Form
    {
        public EventForm()
        {
            InitializeComponent();
        }

        private void EvenForm_Load(object sender, EventArgs e)
        {
            txtDate.Texts = FormCalendar.static_year + "/" + FormCalendar.static_month + "/" + UserControlDays.static_day;

            EmployeeRepository employeeRepository = new EmployeeRepository();

            var entity = employeeRepository.GetAll();
            foreach (var item in entity)
            {
                if (item.Access != 1)
                {
                    metroComboBox1.Items.Add(item.UserName);
                }

            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            TaskTrackingContext context = new TaskTrackingContext();
            MailSendServices mailService = new MailSendServices();


            if (metroComboBox1.SelectedItem == null)
            {
                MessageBox.Show("Lütfen personel seçiniz");
            }
            else if (txtEvent.Texts == "")
            {
                MessageBox.Show("Lütfen eventi doldurunuz");
            }

            else
            {
                string selectedUserName = metroComboBox1.SelectedItem.ToString();
                Employee selectedEmployee = context.Employees.FirstOrDefault(em => em.UserName == selectedUserName);

                CalendarEntity _calendar = new CalendarEntity()
                {
                    date = txtDate.Texts,
                    events = txtEvent.Texts,
                    emp_ID = selectedEmployee.emp_ID,
                };
                context.Add(_calendar);
                context.SaveChanges();
                MessageBox.Show("Etkinlik eklendi");
                
                mailService.SendEventMail(txtEvent.Texts,selectedEmployee.Email);

                txtEvent.Texts = "";
            }
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
