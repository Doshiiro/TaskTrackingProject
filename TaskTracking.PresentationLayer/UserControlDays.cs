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
            if (FormCalendar.accessCalender != 0)
            {
                Form formBackground = new Form();
                try
                {
                    static_day = lbgunler.Text;
                    timer1.Start();
                    using (EventForm uu = new EventForm())
                    {
                        formBackground.StartPosition = FormStartPosition.Manual;
                        formBackground.FormBorderStyle = FormBorderStyle.None;
                        formBackground.Opacity = .50d;
                        formBackground.BackColor = Color.Black;
                        formBackground.WindowState = FormWindowState.Maximized;
                        formBackground.TopMost = true;
                        formBackground.Location = this.Location;
                        formBackground.ShowInTaskbar = false;
                        formBackground.Show();

                        uu.Owner = formBackground;
                        uu.ShowDialog();

                        formBackground.Dispose();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    formBackground.Dispose();
                }
            }
            //default user 0 yetkisine sahip olanlar
            else
            {
                Form formBackground = new Form();
                try
                {
                    static_day = lbgunler.Text;
                    timer1.Start();
                    using (DefaultUserEvent uu = new DefaultUserEvent())
                    {
                        formBackground.StartPosition = FormStartPosition.CenterScreen;
                        formBackground.FormBorderStyle = FormBorderStyle.None;
                        formBackground.Opacity = .50d;
                        formBackground.BackColor = Color.Black;
                        formBackground.WindowState = FormWindowState.Maximized;
                        formBackground.TopMost = true;
                        formBackground.Location = this.Location;
                        formBackground.ShowInTaskbar = false;
                        formBackground.Show();

                        string dateString = FormCalendar.static_year + "/" + FormCalendar.static_month + "/" + lbgunler.Text;
                        DefaultUserEvent.DateData = dateString;

                        uu.Owner = formBackground;
                        uu.ShowDialog();

                        formBackground.Dispose();
                        
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    formBackground.Dispose();
                }
            }

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

        }
    }
}
