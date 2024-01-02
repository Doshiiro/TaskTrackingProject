namespace TaskTracking.PresentationLayer
{
    partial class formDashBoard
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formDashBoard));
            this.bigLabel1 = new ReaLTaiizor.Controls.BigLabel();
            this.poisonDataGridView1 = new ReaLTaiizor.Controls.PoisonDataGridView();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.poisonDataGridView2 = new ReaLTaiizor.Controls.PoisonDataGridView();
            this.departmanID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departmanName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dungeonLabel1 = new ReaLTaiizor.Controls.DungeonLabel();
            this.dungeonLabel2 = new ReaLTaiizor.Controls.DungeonLabel();
            this.departmanAdd = new CustomControls.RJControls.RJButton();
            this.DepartmanDelete = new CustomControls.RJControls.RJButton();
            this.DepartmanRefresh = new CustomControls.RJControls.RJButton();
            this.KullaniciEkleBtn = new CustomControls.RJControls.RJButton();
            this.rjButton3 = new CustomControls.RJControls.RJButton();
            this.rjButton2 = new CustomControls.RJControls.RJButton();
            ((System.ComponentModel.ISupportInitialize)(this.poisonDataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.poisonDataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // bigLabel1
            // 
            this.bigLabel1.AutoSize = true;
            this.bigLabel1.BackColor = System.Drawing.Color.Transparent;
            this.bigLabel1.Font = new System.Drawing.Font("Segoe UI", 25F);
            this.bigLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.bigLabel1.Location = new System.Drawing.Point(824, 725);
            this.bigLabel1.Name = "bigLabel1";
            this.bigLabel1.Size = new System.Drawing.Size(290, 46);
            this.bigLabel1.TabIndex = 0;
            this.bigLabel1.Text = "Admin Dashboard";
            // 
            // poisonDataGridView1
            // 
            this.poisonDataGridView1.AllowUserToResizeRows = false;
            this.poisonDataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.poisonDataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.poisonDataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.poisonDataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.MediumTurquoise;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.poisonDataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.poisonDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.poisonDataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Column2,
            this.Column4,
            this.Column3});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(1);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.poisonDataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.poisonDataGridView1.EnableHeadersVisualStyles = false;
            this.poisonDataGridView1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.poisonDataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.poisonDataGridView1.Location = new System.Drawing.Point(12, 49);
            this.poisonDataGridView1.MultiSelect = false;
            this.poisonDataGridView1.Name = "poisonDataGridView1";
            this.poisonDataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.poisonDataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.poisonDataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.poisonDataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.poisonDataGridView1.Size = new System.Drawing.Size(743, 335);
            this.poisonDataGridView1.TabIndex = 1;
            this.poisonDataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.poisonDataGridView1_CellContentClick);
            // 
            // poisonDataGridView2
            // 
            this.poisonDataGridView2.AllowUserToResizeRows = false;
            this.poisonDataGridView2.BackgroundColor = System.Drawing.Color.White;
            this.poisonDataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.poisonDataGridView2.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.poisonDataGridView2.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.MediumTurquoise;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.poisonDataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.poisonDataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.poisonDataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.departmanID,
            this.departmanName});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(1);
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.poisonDataGridView2.DefaultCellStyle = dataGridViewCellStyle5;
            this.poisonDataGridView2.EnableHeadersVisualStyles = false;
            this.poisonDataGridView2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.poisonDataGridView2.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.poisonDataGridView2.Location = new System.Drawing.Point(12, 440);
            this.poisonDataGridView2.MultiSelect = false;
            this.poisonDataGridView2.Name = "poisonDataGridView2";
            this.poisonDataGridView2.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.poisonDataGridView2.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.poisonDataGridView2.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.poisonDataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.poisonDataGridView2.Size = new System.Drawing.Size(347, 328);
            this.poisonDataGridView2.TabIndex = 6;
            // 
            // departmanID
            // 
            this.departmanID.HeaderText = "ID";
            this.departmanID.Name = "departmanID";
            // 
            // departmanName
            // 
            this.departmanName.HeaderText = "Departman";
            this.departmanName.Name = "departmanName";
            this.departmanName.Width = 200;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Name";
            this.Column2.Name = "Column2";
            this.Column2.Width = 150;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Departman";
            this.Column4.Name = "Column4";
            this.Column4.Width = 200;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Email";
            this.Column3.Name = "Column3";
            this.Column3.Width = 250;
            // 
            // dungeonLabel1
            // 
            this.dungeonLabel1.AutoSize = true;
            this.dungeonLabel1.BackColor = System.Drawing.Color.Transparent;
            this.dungeonLabel1.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.dungeonLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(77)))));
            this.dungeonLabel1.Location = new System.Drawing.Point(12, 18);
            this.dungeonLabel1.Name = "dungeonLabel1";
            this.dungeonLabel1.Size = new System.Drawing.Size(107, 28);
            this.dungeonLabel1.TabIndex = 7;
            this.dungeonLabel1.Text = "Kullanıcılar";
            // 
            // dungeonLabel2
            // 
            this.dungeonLabel2.AutoSize = true;
            this.dungeonLabel2.BackColor = System.Drawing.Color.Transparent;
            this.dungeonLabel2.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.dungeonLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(77)))));
            this.dungeonLabel2.Location = new System.Drawing.Point(15, 409);
            this.dungeonLabel2.Name = "dungeonLabel2";
            this.dungeonLabel2.Size = new System.Drawing.Size(132, 28);
            this.dungeonLabel2.TabIndex = 8;
            this.dungeonLabel2.Text = "Departmanlar";
            // 
            // departmanAdd
            // 
            this.departmanAdd.BackColor = System.Drawing.Color.Transparent;
            this.departmanAdd.BackgroundColor = System.Drawing.Color.Transparent;
            this.departmanAdd.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.departmanAdd.BorderRadius = 0;
            this.departmanAdd.BorderSize = 0;
            this.departmanAdd.FlatAppearance.BorderSize = 0;
            this.departmanAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.departmanAdd.ForeColor = System.Drawing.Color.White;
            this.departmanAdd.Image = ((System.Drawing.Image)(resources.GetObject("departmanAdd.Image")));
            this.departmanAdd.Location = new System.Drawing.Point(365, 440);
            this.departmanAdd.Name = "departmanAdd";
            this.departmanAdd.Size = new System.Drawing.Size(30, 31);
            this.departmanAdd.TabIndex = 11;
            this.departmanAdd.TextColor = System.Drawing.Color.White;
            this.departmanAdd.UseVisualStyleBackColor = false;
            this.departmanAdd.Click += new System.EventHandler(this.departmanAdd_Click);
            // 
            // DepartmanDelete
            // 
            this.DepartmanDelete.BackColor = System.Drawing.Color.Transparent;
            this.DepartmanDelete.BackgroundColor = System.Drawing.Color.Transparent;
            this.DepartmanDelete.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.DepartmanDelete.BorderRadius = 0;
            this.DepartmanDelete.BorderSize = 0;
            this.DepartmanDelete.FlatAppearance.BorderSize = 0;
            this.DepartmanDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DepartmanDelete.ForeColor = System.Drawing.Color.White;
            this.DepartmanDelete.Image = ((System.Drawing.Image)(resources.GetObject("DepartmanDelete.Image")));
            this.DepartmanDelete.Location = new System.Drawing.Point(365, 477);
            this.DepartmanDelete.Name = "DepartmanDelete";
            this.DepartmanDelete.Size = new System.Drawing.Size(30, 33);
            this.DepartmanDelete.TabIndex = 10;
            this.DepartmanDelete.TextColor = System.Drawing.Color.White;
            this.DepartmanDelete.UseVisualStyleBackColor = false;
            // 
            // DepartmanRefresh
            // 
            this.DepartmanRefresh.BackColor = System.Drawing.Color.Transparent;
            this.DepartmanRefresh.BackgroundColor = System.Drawing.Color.Transparent;
            this.DepartmanRefresh.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.DepartmanRefresh.BorderRadius = 0;
            this.DepartmanRefresh.BorderSize = 0;
            this.DepartmanRefresh.FlatAppearance.BorderSize = 0;
            this.DepartmanRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DepartmanRefresh.ForeColor = System.Drawing.Color.White;
            this.DepartmanRefresh.Image = ((System.Drawing.Image)(resources.GetObject("DepartmanRefresh.Image")));
            this.DepartmanRefresh.Location = new System.Drawing.Point(365, 516);
            this.DepartmanRefresh.Name = "DepartmanRefresh";
            this.DepartmanRefresh.Size = new System.Drawing.Size(30, 24);
            this.DepartmanRefresh.TabIndex = 9;
            this.DepartmanRefresh.TextColor = System.Drawing.Color.White;
            this.DepartmanRefresh.UseVisualStyleBackColor = false;
            this.DepartmanRefresh.Click += new System.EventHandler(this.DepartmanRefresh_Click);
            // 
            // KullaniciEkleBtn
            // 
            this.KullaniciEkleBtn.BackColor = System.Drawing.Color.Transparent;
            this.KullaniciEkleBtn.BackgroundColor = System.Drawing.Color.Transparent;
            this.KullaniciEkleBtn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.KullaniciEkleBtn.BorderRadius = 0;
            this.KullaniciEkleBtn.BorderSize = 0;
            this.KullaniciEkleBtn.FlatAppearance.BorderSize = 0;
            this.KullaniciEkleBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.KullaniciEkleBtn.ForeColor = System.Drawing.Color.White;
            this.KullaniciEkleBtn.Image = ((System.Drawing.Image)(resources.GetObject("KullaniciEkleBtn.Image")));
            this.KullaniciEkleBtn.Location = new System.Drawing.Point(761, 49);
            this.KullaniciEkleBtn.Name = "KullaniciEkleBtn";
            this.KullaniciEkleBtn.Size = new System.Drawing.Size(30, 31);
            this.KullaniciEkleBtn.TabIndex = 5;
            this.KullaniciEkleBtn.TextColor = System.Drawing.Color.White;
            this.KullaniciEkleBtn.UseVisualStyleBackColor = false;
            this.KullaniciEkleBtn.Click += new System.EventHandler(this.KullaniciEkleBtn_Click);
            // 
            // rjButton3
            // 
            this.rjButton3.BackColor = System.Drawing.Color.Transparent;
            this.rjButton3.BackgroundColor = System.Drawing.Color.Transparent;
            this.rjButton3.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjButton3.BorderRadius = 0;
            this.rjButton3.BorderSize = 0;
            this.rjButton3.FlatAppearance.BorderSize = 0;
            this.rjButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton3.ForeColor = System.Drawing.Color.White;
            this.rjButton3.Image = ((System.Drawing.Image)(resources.GetObject("rjButton3.Image")));
            this.rjButton3.Location = new System.Drawing.Point(761, 86);
            this.rjButton3.Name = "rjButton3";
            this.rjButton3.Size = new System.Drawing.Size(30, 33);
            this.rjButton3.TabIndex = 4;
            this.rjButton3.TextColor = System.Drawing.Color.White;
            this.rjButton3.UseVisualStyleBackColor = false;
            this.rjButton3.Click += new System.EventHandler(this.rjButton3_Click);
            // 
            // rjButton2
            // 
            this.rjButton2.BackColor = System.Drawing.Color.Transparent;
            this.rjButton2.BackgroundColor = System.Drawing.Color.Transparent;
            this.rjButton2.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjButton2.BorderRadius = 0;
            this.rjButton2.BorderSize = 0;
            this.rjButton2.FlatAppearance.BorderSize = 0;
            this.rjButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton2.ForeColor = System.Drawing.Color.White;
            this.rjButton2.Image = ((System.Drawing.Image)(resources.GetObject("rjButton2.Image")));
            this.rjButton2.Location = new System.Drawing.Point(761, 125);
            this.rjButton2.Name = "rjButton2";
            this.rjButton2.Size = new System.Drawing.Size(30, 24);
            this.rjButton2.TabIndex = 3;
            this.rjButton2.TextColor = System.Drawing.Color.White;
            this.rjButton2.UseVisualStyleBackColor = false;
            this.rjButton2.Click += new System.EventHandler(this.rjButton2_Click);
            // 
            // formDashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1117, 780);
            this.Controls.Add(this.departmanAdd);
            this.Controls.Add(this.DepartmanDelete);
            this.Controls.Add(this.DepartmanRefresh);
            this.Controls.Add(this.dungeonLabel2);
            this.Controls.Add(this.dungeonLabel1);
            this.Controls.Add(this.poisonDataGridView2);
            this.Controls.Add(this.KullaniciEkleBtn);
            this.Controls.Add(this.rjButton3);
            this.Controls.Add(this.rjButton2);
            this.Controls.Add(this.poisonDataGridView1);
            this.Controls.Add(this.bigLabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(261, 65);
            this.Name = "formDashBoard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "dungeonForm1";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.Load += new System.EventHandler(this.formDashBoard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.poisonDataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.poisonDataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ReaLTaiizor.Controls.BigLabel bigLabel1;
        private ReaLTaiizor.Controls.PoisonDataGridView poisonDataGridView1;
        private System.Windows.Forms.FontDialog fontDialog1;
        private CustomControls.RJControls.RJButton rjButton2;
        private CustomControls.RJControls.RJButton rjButton3;
        private CustomControls.RJControls.RJButton KullaniciEkleBtn;
        private ReaLTaiizor.Controls.PoisonDataGridView poisonDataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn departmanID;
        private System.Windows.Forms.DataGridViewTextBoxColumn departmanName;
        private ReaLTaiizor.Controls.DungeonLabel dungeonLabel1;
        private ReaLTaiizor.Controls.DungeonLabel dungeonLabel2;
        private CustomControls.RJControls.RJButton departmanAdd;
        private CustomControls.RJControls.RJButton DepartmanDelete;
        private CustomControls.RJControls.RJButton DepartmanRefresh;
    }
}