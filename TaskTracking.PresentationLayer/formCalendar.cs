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

namespace takvim
{
    public partial class FormCalendar : Form
    {
        int month, year;
        
        public static int static_month, static_year;

        public FormCalendar()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
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

            DateTime aybaslangic = new DateTime(year,month,1);
            int gunler = DateTime.DaysInMonth(year,month);


            int haftaningunleri = ((int)aybaslangic.DayOfWeek - 1 + 7) % 7;

            for (int i=0; i < haftaningunleri; i++)
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
            daycontainer.Controls.Clear();

            month--;


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

        private void btnonce_Click(object sender, EventArgs e)
        {
            daycontainer.Controls.Clear();

            month++;


            static_month = month;
            static_year = year;

            string ayismi = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            lbtarih.Text = ayismi + " " + year;


            DateTime aybaslangic = new DateTime(year,month, 1);
            //month değeri 13 e geliyor ve bu yüzden program burada patlıyor daha sonra fixlencek.
            int gunler = DateTime.DaysInMonth(year,month);


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
    }
}
