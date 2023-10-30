using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using takvim;
using TaskTracking.PresentationLayer.DAL;

namespace TaskTracking.PresentationLayer
{
    public partial class DefaultUserEvent : Form
    {
        public static string DateData;
        public DefaultUserEvent()
        {
            InitializeComponent();
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DefaultUserEvent_Load(object sender, EventArgs e)
        {
            using (TaskTrackingContext context = new TaskTrackingContext())
            {
                var calendarEvent = context.Calendars
                  .Where(c => c.date == DateData && c.emp_ID == FormCalendar.emp_Fk).ToList();
                if (calendarEvent != null)
                {
                    foreach (var item in calendarEvent)
                    {
                        metroListBox1.Items.Add(item.events);
                    }

                }
            }

        }

        private void bigLabel1_Click(object sender, EventArgs e)
        {

        }

        private void metroListBox1_SelectedIndexChanged(object sender)
        {
            this.BackColor = Color.White;
        }
    }
}
