using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TaskTracking.PresentationLayer;
using TaskTracking.PresentationLayer.DAL;

namespace takvim
{
    public partial class UserControlDays : UserControl
    {
        public static string static_day;
        public UserControlDays()
        {
            InitializeComponent();
        }

        private void UserControlDays_Load(object sender, EventArgs e)
        {
            displayEvent();
        }
        public void days(int numday)
        {
            lbgunler.Text = numday + "";
        }

        private void UserControlDays_Click(object sender, EventArgs e)
        {
            static_day = lbgunler.Text;
            timer1.Start();
            EventForm eventForm = new EventForm();
            eventForm.Show();
        }

        private void displayEvent()
        {
            //using (TaskTrackingContext context = new TaskTrackingContext())
            //{

            //    var cal = context.Calendars.FirstOrDefault(c => c.emp_ID == emp_Fk);
            //    if (cal != null)
            //    {
            //        displaDays();
            //    }
            //}
            using (TaskTrackingContext context = new TaskTrackingContext())
            {
                string dateString = FormCalendar.static_year + "/" + FormCalendar.static_month + "/" + lbgunler.Text;

                var calendarEvent = context.Calendars
                    .FirstOrDefault(e => e.date == dateString && e.emp_ID == FormCalendar.emp_Fk);

                if (calendarEvent != null)
                {
                    lblEvent.Text = calendarEvent.events;
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            displayEvent();
        }
    }
}
