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
using TaskTracking.PresentationLayer.Management.Concrete;

namespace TaskTracking.PresentationLayer
{
    public partial class HomeForm : Form
    {
        formDashBoard dashBoard;
        formDefaultDashboard defaultDashboard;
        formSubmenu1 sub1;
        formSubmenu2 sub2;
        FormCalendar frmcalendar;


        public HomeForm()
        {
            InitializeComponent();
        }

        public int employeeRole;
        public int emp_id;
        public int emp_calendarAccess;

        private void HomeForm_Load(object sender, EventArgs e)
        {
            formDefaultDashboard.taskListId = emp_id;
            if (employeeRole != 1)
            {
                defaultDashboard = new formDefaultDashboard();
                defaultDashboard.Show();
                defaultDashboard.MdiParent = this;
                defaultDashboard.Dock = DockStyle.Fill;

                rjButton1.Visible = false;
                pnDashboard.Visible = false;

            }
            else
            {
                dashBoard = new formDashBoard();
                dashBoard.Show();
                dashBoard.MdiParent = this;
                dashBoard.Dock = DockStyle.Fill;
                rjButton2.Visible = false;
            }



        }
        bool menuExpand = false;
        private void menuTransition_Tick(object sender, EventArgs e)
        {
            if (menuExpand == false)
            {
                menuContainer.Height += 10;
                if (menuContainer.Height >= 228)
                {
                    menuTransition.Stop();
                    menuExpand = true;
                }
            }
            else
            {
                menuContainer.Height -= 4;
                if (menuContainer.Height <= 62)
                {
                    menuTransition.Stop();
                    menuExpand = false;
                }
            }
        }

        private void menubtn_Click(object sender, EventArgs e)
        {
            menuTransition.Start();
        }
        bool sidebarExpand = true;
        private void sidebartransition_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                sidebar.Width -= 7;
                if (sidebar.Width <= 50)
                {
                    sidebarExpand = false;
                    sidebartransition.Stop();
                }
            }
            else
            {
                sidebar.Width += 7;
                if (sidebar.Width >= 240)
                {
                    sidebarExpand = true;
                    sidebartransition.Stop();
                }
            }
        }

        private void btnHam_Click(object sender, EventArgs e)
        {
            sidebartransition.Start();
        }

        private void rjButton1_Click(object sender, EventArgs e)
        {


            if (dashBoard == null)
            {
                dashBoard = new formDashBoard();
                dashBoard.FormClosed += Dashboard_FormClosed;
                dashBoard.MdiParent = this;
                dashBoard.Dock = DockStyle.Fill;
                dashBoard.Show();

            }
            else
            {
                dashBoard.Activate();
            }
        }

        private void Dashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            dashBoard = null;
        }


        private void submenu1btn_Click(object sender, EventArgs e)
        {
            if (sub1 == null)
            {
                sub1 = new formSubmenu1();
                sub1.FormClosed += Sub1_FormClosed;
                sub1.MdiParent = this;
                sub1.Dock = DockStyle.Fill;
                formSubmenu1.taskEmp_Fk = emp_id;
                sub1.Show();
            }
            else
            {
                sub1.Activate();
            }
        }

        private void Sub1_FormClosed(object sender, FormClosedEventArgs e)
        {
            sub1 = null;
        }
        private void submenu2btn_Click_1(object sender, EventArgs e)
        {
            if (sub2 == null)
            {
                sub2 = new formSubmenu2();
                sub2.FormClosed += Sub2_FormClosed;
                sub2.MdiParent = this;
                sub2.Dock = DockStyle.Fill;
                sub2.Show();
            }
            else
            {
                sub2.Activate();
            }
        }
        private void Sub2_FormClosed(object sender, FormClosedEventArgs e)
        {
            sub2 = null;
        }

        private void calenderbtn_Click(object sender, EventArgs e)
        {
            if (frmcalendar == null)
            {

                frmcalendar = new FormCalendar();
                frmcalendar.FormClosed += Calender_FormClosed;
                frmcalendar.MdiParent = this;
                frmcalendar.Dock = DockStyle.Fill;
                FormCalendar.emp_Fk = emp_id;
                FormCalendar.accessCalender = emp_calendarAccess;
                frmcalendar.Show();
            }
            else
            {
                frmcalendar.Activate();
            }

        }
        private void Calender_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmcalendar = null;
        }

        private void rjButton2_Click(object sender, EventArgs e)
        {
            if (defaultDashboard == null)
            {

                defaultDashboard = new formDefaultDashboard();
                defaultDashboard.FormClosed += DefaultDashboard_FormClosed;
                defaultDashboard.MdiParent = this;
                defaultDashboard.Dock = DockStyle.Fill;
                formDefaultDashboard.taskListId = emp_id;
                defaultDashboard.Show();

            }

            else
            {
                defaultDashboard.Activate();
            }
        }
        private void DefaultDashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            dashBoard = null;
        }

        private void sidebar_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
