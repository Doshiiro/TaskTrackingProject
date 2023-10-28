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
using TaskTracking.PresentationLayer.DesignForm;

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
            if (FormCalendar.accessCalender == 0)
            {
                rjButton2.Visible = false;
            }
            displayEvent();

        }
        public void days(int numday)
        {
            lbgunler.Text = numday + "";
        }

        PopupFormDesign popupFrm = new PopupFormDesign();
        private void UserControlDays_Click(object sender, EventArgs e)
        {
            //if (FormCalendar.accessCalender != 0)
            //{
            //    static_day = lbgunler.Text;
            //    timer1.Start();
            //}
            ////default user 0 yetkisine sahip olanlar
            //else
            //{
            //    string dateString = FormCalendar.static_year + "/" + FormCalendar.static_month + "/" + lbgunler.Text;
            //    DefaultUserEvent.DateData = dateString;
            //    popupFrm.Popup<DefaultUserEvent>();
            //}
        }


        private void displayEvent()
        {

            using (TaskTrackingContext context = new TaskTrackingContext())
            {
                string dateString = FormCalendar.static_year + "/" + FormCalendar.static_month + "/" + lbgunler.Text;


                var calenderEvent = context.Calendars.Count(e => e.date == dateString && e.emp_ID == FormCalendar.emp_Fk);

                if (calenderEvent != null)
                {
                    if (calenderEvent == 0)
                    {
                        lblEvent.Text = "";
                    }
                    else
                    {
                        lblEvent.Text = calenderEvent.ToString() + " Etkinlik";
                    }
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            displayEvent();
        }

        private void lblEvent_Click(object sender, EventArgs e)
        {
            string dateString = FormCalendar.static_year + "/" + FormCalendar.static_month + "/" + lbgunler.Text;
            DefaultUserEvent.DateData = dateString;
            popupFrm.Popup<DefaultUserEvent>();
        }

        private void rjButton2_Click(object sender, EventArgs e)
        {
            static_day = lbgunler.Text;
            timer1.Start();
            popupFrm.Popup<EventForm>();
        }
    }
}
