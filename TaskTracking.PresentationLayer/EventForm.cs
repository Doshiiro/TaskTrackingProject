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
           
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            TaskTrackingContext context = new TaskTrackingContext();
            CalendarEntity _calendar = new CalendarEntity()
            {
                date = txtDate.Texts,
                events = txtEvent.Texts,
                emp_ID = Convert.ToInt32(empIdTxt.Texts)
        };
        context.Add(_calendar);
            context.SaveChanges();
            MessageBox.Show("Etkinlik eklendi");
        }
}
}
