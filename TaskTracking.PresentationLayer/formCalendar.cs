using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TaskTracking.PresentationLayer;
using TaskTracking.PresentationLayer.DAL;
using TaskTracking.PresentationLayer.DesignForm;

namespace takvim
{
    public partial class FormCalendar : Form
    {
        int month, year;

        public static int static_month, static_year;

        public static int departmanid;
        public static int EmpAccess;

        public FormCalendar()
        {
            InitializeComponent();
        }
        public static int emp_Fk;
        public static int accessCalender;
        private void Form1_Load(object sender, EventArgs e)
        {
            if (accessCalender == 0)
            {
                eventShowBtn.Visible = false;
            }
            displaDays();
        }

        private void displaDays()
        {
            DateTime simdi = DateTime.Now;
            month = simdi.Month;
            year = simdi.Year;

            string ayismi = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            lbtarih.Text = ayismi + " " + year;

            static_month = month;
            static_year = year;

            DateTime aybaslangic = new DateTime(year, month, 1);
            int gunler = DateTime.DaysInMonth(year, month);


            int haftaningunleri = ((int)aybaslangic.DayOfWeek - 1 + 7) % 7;

            for (int i = 0; i < haftaningunleri; i++)
            {
                UserControlBlank ucblank = new UserControlBlank();
                daycontainer.Controls.Add(ucblank);
            }
            for (int i = 1; i <= gunler; i++)
            {
                UserControlDays ucdays = new UserControlDays();
                ucdays.days(i);
                daycontainer.Controls.Add(ucdays);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PopupFormDesign popupFormDesign = new PopupFormDesign();
            popupFormDesign.Popup<AllEventForm>();
           
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            daycontainer.Controls.Clear();


            month++;
            if (month == 13)
            {
                month = 1;
                year++;
            }

            static_month = month;
            static_year = year;


            string ayismi = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            lbtarih.Text = ayismi + " " + year;

            DateTime aybaslangic = new DateTime(year, month, 1);

            int gunler = DateTime.DaysInMonth(year, month);


            int haftaningunleri = ((int)aybaslangic.DayOfWeek - 1 + 7) % 7;

            for (int i = 0; i < haftaningunleri; i++)
            {
                UserControlBlank ucblank = new UserControlBlank();
                daycontainer.Controls.Add(ucblank);
            }
            for (int i = 1; i <= gunler; i++)
            {
                UserControlDays ucdays = new UserControlDays();
                ucdays.days(i);
                daycontainer.Controls.Add(ucdays);

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            daycontainer.Controls.Clear();

            month--;

            if (month == 0)
            {
                month = 1;

                if (month == 1)
                {
                    month = 12;
                    year--;
                }
            }


            static_month = month;
            static_year = year;

            string ayismi = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            lbtarih.Text = ayismi + " " + year;


            DateTime aybaslangic = new DateTime(year, month, 1);
            int gunler = DateTime.DaysInMonth(year, month);


            int haftaningunleri = ((int)aybaslangic.DayOfWeek - 1 + 7) % 7;

            for (int i = 0; i < haftaningunleri; i++)
            {
                UserControlBlank ucblank = new UserControlBlank();
                daycontainer.Controls.Add(ucblank);
            }
            for (int i = 1; i <= gunler; i++)
            {
                UserControlDays ucdays = new UserControlDays();
                ucdays.days(i);
                daycontainer.Controls.Add(ucdays);
            }
        }

        private void btnsonraki_Click(object sender, EventArgs e)
        {
            
        }

        private void btnonce_Click(object sender, EventArgs e)
        {
            
        }
    }
}
