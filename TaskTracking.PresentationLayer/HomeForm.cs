﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TaskTracking.PresentationLayer.Management.Concrete;

namespace TaskTracking.PresentationLayer
{
    public partial class HomeForm : Form
    {
        formDashBoard dashBoard;
        formCalendar frmcalendar;
        formSubmenu1 sub1;
        formSubmenu2 sub2;
        formToDo frmtodo;
        public HomeForm()
        {
            InitializeComponent();
        }

        private void HomeForm_Load(object sender, EventArgs e)
        {
            EmployeeRepository employeeRepository = new EmployeeRepository();
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
                menuContainer.Height -= 10;
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
                frmcalendar = new formCalendar();
                frmcalendar.FormClosed += Calender_FormClosed;
                frmcalendar.MdiParent = this;
                frmcalendar.Dock = DockStyle.Fill;
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
    }
}