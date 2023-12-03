﻿namespace TaskTracking.PresentationLayer
{
    partial class HomeForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeForm));
            this.sidebar = new System.Windows.Forms.FlowLayoutPanel();
            this.pnDashboard = new ReaLTaiizor.Controls.Panel();
            this.pnSettings = new ReaLTaiizor.Controls.Panel();
            this.menuContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.panel3 = new ReaLTaiizor.Controls.Panel();
            this.panel6 = new ReaLTaiizor.Controls.Panel();
            this.panel4 = new ReaLTaiizor.Controls.Panel();
            this.panel8 = new ReaLTaiizor.Controls.Panel();
            this.menuTransition = new System.Windows.Forms.Timer(this.components);
            this.sidebartransition = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.closeBtn = new CustomControls.RJControls.RJButton();
            this.rjButton2 = new CustomControls.RJControls.RJButton();
            this.rjButton1 = new CustomControls.RJControls.RJButton();
            this.calenderbtn = new CustomControls.RJControls.RJButton();
            this.menubtn = new CustomControls.RJControls.RJButton();
            this.submenu1btn = new CustomControls.RJControls.RJButton();
            this.submenu2btn = new CustomControls.RJControls.RJButton();
            this.submenu3btn = new CustomControls.RJControls.RJButton();
            this.sidebar.SuspendLayout();
            this.pnDashboard.SuspendLayout();
            this.pnSettings.SuspendLayout();
            this.menuContainer.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // sidebar
            // 
            this.sidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.sidebar.Controls.Add(this.rjButton2);
            this.sidebar.Controls.Add(this.pnDashboard);
            this.sidebar.Controls.Add(this.pnSettings);
            this.sidebar.Controls.Add(this.menuContainer);
            this.sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.sidebar.Location = new System.Drawing.Point(0, 0);
            this.sidebar.Name = "sidebar";
            this.sidebar.Size = new System.Drawing.Size(229, 819);
            this.sidebar.TabIndex = 2;
            this.sidebar.Paint += new System.Windows.Forms.PaintEventHandler(this.sidebar_Paint);
            // 
            // pnDashboard
            // 
            this.pnDashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(51)))), ((int)(((byte)(63)))));
            this.pnDashboard.Controls.Add(this.rjButton1);
            this.pnDashboard.EdgeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(41)))), ((int)(((byte)(50)))));
            this.pnDashboard.Location = new System.Drawing.Point(3, 71);
            this.pnDashboard.Name = "pnDashboard";
            this.pnDashboard.Padding = new System.Windows.Forms.Padding(5);
            this.pnDashboard.Size = new System.Drawing.Size(226, 62);
            this.pnDashboard.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.pnDashboard.TabIndex = 4;
            this.pnDashboard.Text = "panel2";
            // 
            // pnSettings
            // 
            this.pnSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(51)))), ((int)(((byte)(63)))));
            this.pnSettings.Controls.Add(this.calenderbtn);
            this.pnSettings.EdgeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(41)))), ((int)(((byte)(50)))));
            this.pnSettings.Location = new System.Drawing.Point(3, 139);
            this.pnSettings.Name = "pnSettings";
            this.pnSettings.Padding = new System.Windows.Forms.Padding(5);
            this.pnSettings.Size = new System.Drawing.Size(226, 61);
            this.pnSettings.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.pnSettings.TabIndex = 10;
            this.pnSettings.Text = "Settings";
            // 
            // menuContainer
            // 
            this.menuContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.menuContainer.Controls.Add(this.panel3);
            this.menuContainer.Controls.Add(this.panel6);
            this.menuContainer.Controls.Add(this.panel4);
            this.menuContainer.Controls.Add(this.panel8);
            this.menuContainer.Location = new System.Drawing.Point(3, 206);
            this.menuContainer.Name = "menuContainer";
            this.menuContainer.Size = new System.Drawing.Size(226, 60);
            this.menuContainer.TabIndex = 8;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.panel3.Controls.Add(this.menubtn);
            this.panel3.EdgeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(5);
            this.panel3.Size = new System.Drawing.Size(237, 55);
            this.panel3.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.panel3.TabIndex = 9;
            this.panel3.Text = "panel3";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.panel6.Controls.Add(this.submenu1btn);
            this.panel6.EdgeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(41)))), ((int)(((byte)(50)))));
            this.panel6.Location = new System.Drawing.Point(3, 64);
            this.panel6.Name = "panel6";
            this.panel6.Padding = new System.Windows.Forms.Padding(5);
            this.panel6.Size = new System.Drawing.Size(237, 50);
            this.panel6.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.panel6.TabIndex = 11;
            this.panel6.Text = "panel6";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.panel4.Controls.Add(this.submenu2btn);
            this.panel4.EdgeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(41)))), ((int)(((byte)(50)))));
            this.panel4.Location = new System.Drawing.Point(3, 120);
            this.panel4.Name = "panel4";
            this.panel4.Padding = new System.Windows.Forms.Padding(5);
            this.panel4.Size = new System.Drawing.Size(237, 50);
            this.panel4.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.panel4.TabIndex = 12;
            this.panel4.Text = "panel4";
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.panel8.Controls.Add(this.submenu3btn);
            this.panel8.EdgeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(41)))), ((int)(((byte)(50)))));
            this.panel8.Location = new System.Drawing.Point(3, 176);
            this.panel8.Name = "panel8";
            this.panel8.Padding = new System.Windows.Forms.Padding(5);
            this.panel8.Size = new System.Drawing.Size(237, 50);
            this.panel8.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.panel8.TabIndex = 14;
            this.panel8.Text = "panel8";
            // 
            // menuTransition
            // 
            this.menuTransition.Interval = 10;
            this.menuTransition.Tick += new System.EventHandler(this.menuTransition_Tick);
            // 
            // sidebartransition
            // 
            this.sidebartransition.Interval = 10;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.closeBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(229, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1126, 25);
            this.panel1.TabIndex = 6;
            // 
            // closeBtn
            // 
            this.closeBtn.BackColor = System.Drawing.Color.Gray;
            this.closeBtn.BackgroundColor = System.Drawing.Color.Gray;
            this.closeBtn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.closeBtn.BorderRadius = 0;
            this.closeBtn.BorderSize = 0;
            this.closeBtn.FlatAppearance.BorderSize = 0;
            this.closeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.closeBtn.ForeColor = System.Drawing.Color.White;
            this.closeBtn.Image = ((System.Drawing.Image)(resources.GetObject("closeBtn.Image")));
            this.closeBtn.Location = new System.Drawing.Point(1099, 0);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(27, 25);
            this.closeBtn.TabIndex = 23;
            this.closeBtn.TextColor = System.Drawing.Color.White;
            this.closeBtn.UseVisualStyleBackColor = false;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // rjButton2
            // 
            this.rjButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.rjButton2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.rjButton2.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjButton2.BorderRadius = 0;
            this.rjButton2.BorderSize = 0;
            this.rjButton2.FlatAppearance.BorderSize = 0;
            this.rjButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rjButton2.ForeColor = System.Drawing.Color.White;
            this.rjButton2.Image = ((System.Drawing.Image)(resources.GetObject("rjButton2.Image")));
            this.rjButton2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.rjButton2.Location = new System.Drawing.Point(3, 3);
            this.rjButton2.Name = "rjButton2";
            this.rjButton2.Size = new System.Drawing.Size(226, 62);
            this.rjButton2.TabIndex = 6;
            this.rjButton2.Text = "Ana Sayfa";
            this.rjButton2.TextColor = System.Drawing.Color.White;
            this.rjButton2.UseVisualStyleBackColor = false;
            this.rjButton2.Click += new System.EventHandler(this.rjButton2_Click);
            // 
            // rjButton1
            // 
            this.rjButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.rjButton1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.rjButton1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjButton1.BorderRadius = 0;
            this.rjButton1.BorderSize = 0;
            this.rjButton1.FlatAppearance.BorderSize = 0;
            this.rjButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rjButton1.ForeColor = System.Drawing.Color.White;
            this.rjButton1.Image = ((System.Drawing.Image)(resources.GetObject("rjButton1.Image")));
            this.rjButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.rjButton1.Location = new System.Drawing.Point(-2, 0);
            this.rjButton1.Name = "rjButton1";
            this.rjButton1.Padding = new System.Windows.Forms.Padding(1);
            this.rjButton1.Size = new System.Drawing.Size(228, 62);
            this.rjButton1.TabIndex = 5;
            this.rjButton1.Text = "Dashboard";
            this.rjButton1.TextColor = System.Drawing.Color.White;
            this.rjButton1.UseVisualStyleBackColor = false;
            this.rjButton1.Click += new System.EventHandler(this.rjButton1_Click);
            // 
            // calenderbtn
            // 
            this.calenderbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.calenderbtn.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.calenderbtn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.calenderbtn.BorderRadius = 0;
            this.calenderbtn.BorderSize = 0;
            this.calenderbtn.FlatAppearance.BorderSize = 0;
            this.calenderbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.calenderbtn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.calenderbtn.ForeColor = System.Drawing.Color.White;
            this.calenderbtn.Image = ((System.Drawing.Image)(resources.GetObject("calenderbtn.Image")));
            this.calenderbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.calenderbtn.Location = new System.Drawing.Point(-3, -1);
            this.calenderbtn.Name = "calenderbtn";
            this.calenderbtn.Padding = new System.Windows.Forms.Padding(1);
            this.calenderbtn.Size = new System.Drawing.Size(229, 62);
            this.calenderbtn.TabIndex = 5;
            this.calenderbtn.Text = "Takvim";
            this.calenderbtn.TextColor = System.Drawing.Color.White;
            this.calenderbtn.UseVisualStyleBackColor = false;
            this.calenderbtn.Click += new System.EventHandler(this.calenderbtn_Click);
            // 
            // menubtn
            // 
            this.menubtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.menubtn.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.menubtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.menubtn.BorderRadius = 0;
            this.menubtn.BorderSize = 0;
            this.menubtn.FlatAppearance.BorderSize = 0;
            this.menubtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menubtn.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.menubtn.ForeColor = System.Drawing.Color.White;
            this.menubtn.Image = ((System.Drawing.Image)(resources.GetObject("menubtn.Image")));
            this.menubtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.menubtn.Location = new System.Drawing.Point(-3, -3);
            this.menubtn.Name = "menubtn";
            this.menubtn.Padding = new System.Windows.Forms.Padding(1);
            this.menubtn.Size = new System.Drawing.Size(226, 60);
            this.menubtn.TabIndex = 5;
            this.menubtn.Text = "Yapılacaklar";
            this.menubtn.TextColor = System.Drawing.Color.White;
            this.menubtn.UseVisualStyleBackColor = false;
            this.menubtn.Click += new System.EventHandler(this.menubtn_Click);
            // 
            // submenu1btn
            // 
            this.submenu1btn.BackColor = System.Drawing.Color.Transparent;
            this.submenu1btn.BackgroundColor = System.Drawing.Color.Transparent;
            this.submenu1btn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.submenu1btn.BorderRadius = 0;
            this.submenu1btn.BorderSize = 0;
            this.submenu1btn.FlatAppearance.BorderSize = 0;
            this.submenu1btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.submenu1btn.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.submenu1btn.ForeColor = System.Drawing.Color.White;
            this.submenu1btn.Image = ((System.Drawing.Image)(resources.GetObject("submenu1btn.Image")));
            this.submenu1btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.submenu1btn.Location = new System.Drawing.Point(-3, 0);
            this.submenu1btn.Name = "submenu1btn";
            this.submenu1btn.Padding = new System.Windows.Forms.Padding(0, 0, 50, 0);
            this.submenu1btn.Size = new System.Drawing.Size(240, 47);
            this.submenu1btn.TabIndex = 5;
            this.submenu1btn.Text = "Yapılacaklar";
            this.submenu1btn.TextColor = System.Drawing.Color.White;
            this.submenu1btn.UseVisualStyleBackColor = false;
            this.submenu1btn.Click += new System.EventHandler(this.submenu1btn_Click);
            // 
            // submenu2btn
            // 
            this.submenu2btn.BackColor = System.Drawing.Color.Transparent;
            this.submenu2btn.BackgroundColor = System.Drawing.Color.Transparent;
            this.submenu2btn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.submenu2btn.BorderRadius = 0;
            this.submenu2btn.BorderSize = 0;
            this.submenu2btn.FlatAppearance.BorderSize = 0;
            this.submenu2btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.submenu2btn.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.submenu2btn.ForeColor = System.Drawing.Color.White;
            this.submenu2btn.Image = ((System.Drawing.Image)(resources.GetObject("submenu2btn.Image")));
            this.submenu2btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.submenu2btn.Location = new System.Drawing.Point(-3, 0);
            this.submenu2btn.Name = "submenu2btn";
            this.submenu2btn.Padding = new System.Windows.Forms.Padding(0, 0, 50, 0);
            this.submenu2btn.Size = new System.Drawing.Size(240, 47);
            this.submenu2btn.TabIndex = 5;
            this.submenu2btn.Text = "Menu 1";
            this.submenu2btn.TextColor = System.Drawing.Color.White;
            this.submenu2btn.UseVisualStyleBackColor = false;
            this.submenu2btn.Click += new System.EventHandler(this.submenu2btn_Click_1);
            // 
            // submenu3btn
            // 
            this.submenu3btn.BackColor = System.Drawing.Color.Transparent;
            this.submenu3btn.BackgroundColor = System.Drawing.Color.Transparent;
            this.submenu3btn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.submenu3btn.BorderRadius = 0;
            this.submenu3btn.BorderSize = 0;
            this.submenu3btn.FlatAppearance.BorderSize = 0;
            this.submenu3btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.submenu3btn.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.submenu3btn.ForeColor = System.Drawing.Color.White;
            this.submenu3btn.Image = ((System.Drawing.Image)(resources.GetObject("submenu3btn.Image")));
            this.submenu3btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.submenu3btn.Location = new System.Drawing.Point(-3, 0);
            this.submenu3btn.Name = "submenu3btn";
            this.submenu3btn.Padding = new System.Windows.Forms.Padding(0, 0, 50, 0);
            this.submenu3btn.Size = new System.Drawing.Size(240, 47);
            this.submenu3btn.TabIndex = 5;
            this.submenu3btn.Text = "Menu 1";
            this.submenu3btn.TextColor = System.Drawing.Color.White;
            this.submenu3btn.UseVisualStyleBackColor = false;
            // 
            // HomeForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1355, 819);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.sidebar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.MaximumSize = new System.Drawing.Size(1920, 1040);
            this.Name = "HomeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.HomeForm_Load);
            this.sidebar.ResumeLayout(false);
            this.pnDashboard.ResumeLayout(false);
            this.pnSettings.ResumeLayout(false);
            this.menuContainer.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel sidebar;
        private ReaLTaiizor.Controls.Panel pnDashboard;
        private CustomControls.RJControls.RJButton rjButton1;
        private System.Windows.Forms.FlowLayoutPanel menuContainer;
        private ReaLTaiizor.Controls.Panel panel3;
        private CustomControls.RJControls.RJButton menubtn;
        private ReaLTaiizor.Controls.Panel pnSettings;
        private CustomControls.RJControls.RJButton calenderbtn;
        private ReaLTaiizor.Controls.Panel panel6;
        private CustomControls.RJControls.RJButton submenu1btn;
        private ReaLTaiizor.Controls.Panel panel4;
        private CustomControls.RJControls.RJButton submenu2btn;
        private ReaLTaiizor.Controls.Panel panel8;
        private CustomControls.RJControls.RJButton submenu3btn;
        private System.Windows.Forms.Timer menuTransition;
        private System.Windows.Forms.Timer sidebartransition;
        private CustomControls.RJControls.RJButton rjButton2;
        private System.Windows.Forms.Panel panel1;
        private CustomControls.RJControls.RJButton closeBtn;
    }
}