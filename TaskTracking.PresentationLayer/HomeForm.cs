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
        formToDo sub3;
        FormCalendar frmcalendar;
        EmployeeSettingsForm employeeSettingsForm;

        public HomeForm()
        {
            InitializeComponent();
        }

        public int employeeRole;
        public int emp_id;
        public int emp_calendarAccess;
        public string emp_UserName;

        //proje sayfası
        public int projeAccessId;
        public int projeDepIDAccess;
        public int projeEventAccesID;



        private void HomeForm_Load(object sender, EventArgs e)
        {
            crownLabel1.Text = emp_UserName;
            formDefaultDashboard.taskListId = emp_id;
            if (employeeRole != 1)
            {
                defaultDashboard = new formDefaultDashboard();
                defaultDashboard.Show();
                defaultDashboard.MdiParent = this;
                defaultDashboard.Dock = DockStyle.Fill;

                rjButton1.Visible = false;

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
            formSubmenu2.ProjeAccess = projeAccessId;
            formSubmenu2.ProjeDepID = projeDepIDAccess;
            formSubmenu2.projeEventEmpID = projeEventAccesID;

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
            FormCalendar.departmanid = projeDepIDAccess;
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

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void submenu3btn_Click(object sender, EventArgs e)
        {
            formToDo.eventEmpID = emp_id;
            if (sub3 == null)
            {
                sub3 = new formToDo();
                sub3.FormClosed += submenu3_FormClosed;
                sub3.MdiParent = this;
                sub3.Dock = DockStyle.Fill;
                sub3.Show();
            }
            else
            {
                sub3.Activate();
            }
        }
        private void submenu3_FormClosed(object sender, FormClosedEventArgs e)
        {
            sub3 = null;
        }

        private void settingsBtn_Click(object sender, EventArgs e)
        {
            EmployeeSettingsForm.empid = emp_id;
            if (employeeSettingsForm == null)
            {
                employeeSettingsForm = new EmployeeSettingsForm();
                employeeSettingsForm.FormClosed += submenu3_FormClosed;
                employeeSettingsForm.MdiParent = this;
                employeeSettingsForm.Dock = DockStyle.Fill;
                employeeSettingsForm.Show();
            }
            else
            {
                employeeSettingsForm.Activate();
            }
        }
        private void settings_FormClosed(object sender, FormClosedEventArgs e)
        {
            employeeSettingsForm = null;
        }

    }
}
