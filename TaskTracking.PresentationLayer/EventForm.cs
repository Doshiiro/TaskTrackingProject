using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using takvim;
using TaskTracking.PresentationLayer.DAL;
using TaskTracking.PresentationLayer.Entities;
using TaskTracking.PresentationLayer.Management.Concrete;

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
                metroComboBox1.Items.Add(item.UserName);
              
            }

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            TaskTrackingContext context = new TaskTrackingContext();


           
            if (metroComboBox1.SelectedItem == null)
            {
                MessageBox.Show("Lütfen personel seçiniz");
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
            }
        }

          
    }
}
