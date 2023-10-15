﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TaskTracking.PresentationLayer.DesignForm;

namespace TaskTracking.PresentationLayer
{
    public partial class Form1 : Form
    {
        private Label dummyLabel;

        public Form1()
        {
            InitializeComponent();
            SetRoundShape(panel1, 10);
            //BackColor = Color.FromArgb(60, 154, 226);

            CustomCenter customCenter= new CustomCenter();

            customCenter.CenterToolAll(this, panel1);
            customCenter.CenterToolLeft(panel1, pictureBox1);
            customCenter.CenterToolLeft(panel1, rjTextBox2);
            customCenter.CenterToolLeft(panel1, rjTextBox3);
            customCenter.CenterToolLeft(panel1, rjButton1);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            rjTextBox3.Texts = "Kullanıcı Adı";
            rjTextBox2.Texts = "Şifre";

            rjTextBox3.ForeColor = Color.FromArgb(175, 175, 175);
            rjTextBox2.ForeColor = Color.FromArgb(175, 175, 175);


            rjTextBox3.BorderColor = Color.FromArgb(227, 227, 227);
            rjTextBox2.BorderColor = Color.FromArgb(227, 227, 227);

            rjTextBox3.BorderFocusColor = Color.FromArgb(60, 154, 226);
            rjTextBox2.BorderFocusColor = Color.FromArgb(60, 154, 226);

            rjTextBox3.BackColor = Color.FromArgb(227, 227, 227);
            rjTextBox2.BackColor = Color.FromArgb(227, 227, 227);

            dummyLabel = new Label();
            dummyLabel.Size = new Size(0, 0);
            dummyLabel.Location = new Point(-100, -100); 
            this.Controls.Add(dummyLabel);

            // Dummy Label'e focus yapmayı sağlar
            dummyLabel.Select();
        }
        private void SetRoundShape(Control control, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(control.Width - radius, 0, radius, radius, 270, 90);
            path.AddArc(control.Width - radius, control.Height - radius, radius, radius, 0, 90);
            path.AddArc(0, control.Height - radius, radius, radius, 90, 90);
            control.Region = new Region(path);
        }


        #region Eventler
        private void rjTextBox2_Enter(object sender, EventArgs e)
        {
            if (rjTextBox2.Texts == "Şifre")
            {
                rjTextBox2.Texts = "";
                rjTextBox2.ForeColor = Color.Black;
            }
        }
        private void rjTextBox2_Leave(object sender, EventArgs e)
        {
            if (rjTextBox2.Texts == "")
            {
                rjTextBox2.Texts = "Şifre";
                rjTextBox2.ForeColor = Color.FromArgb(175, 175, 175);

            }
        }
        private void rjTextBox3_Enter_1(object sender, EventArgs e)
        {
            if (rjTextBox3.Texts == "Kullanıcı Adı")
            {
                rjTextBox3.Texts = "";
                rjTextBox3.ForeColor = Color.Black;
            }
        }
        private void rjTextBox3_Leave_1(object sender, EventArgs e)
        {
            if (rjTextBox3.Texts == "")
            {
                rjTextBox3.Texts = "Kullanıcı Adı";
                rjTextBox3.ForeColor = Color.FromArgb(175, 175, 175);

            }
        }
        #endregion

        private void rjButton1_Click(object sender, EventArgs e)
        {

        }
    }
}