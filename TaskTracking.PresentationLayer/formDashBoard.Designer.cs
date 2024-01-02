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
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Access = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.poisonDataGridView2 = new ReaLTaiizor.Controls.PoisonDataGridView();
            this.departmanID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departmanName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dungeonLabel1 = new ReaLTaiizor.Controls.DungeonLabel();
            this.dungeonLabel2 = new ReaLTaiizor.Controls.DungeonLabel();
            this.metroComboBox2 = new MetroFramework.Controls.MetroComboBox();
            this.dungeonLabel5 = new ReaLTaiizor.Controls.DungeonLabel();
            this.metroComboBox1 = new MetroFramework.Controls.MetroComboBox();
            this.dungeonLabel4 = new ReaLTaiizor.Controls.DungeonLabel();
            this.dungeonLabel3 = new ReaLTaiizor.Controls.DungeonLabel();
            this.dungeonLabel6 = new ReaLTaiizor.Controls.DungeonLabel();
            this.dungeonLabel7 = new ReaLTaiizor.Controls.DungeonLabel();
            this.txtEmpid = new System.Windows.Forms.TextBox();
            this.depUpdateid = new System.Windows.Forms.TextBox();
            this.departmantUpdatetxt = new CustomControls.RJControls.RJTextBox();
            this.depUpdatebtn = new CustomControls.RJControls.RJButton();
            this.rjButton1 = new CustomControls.RJControls.RJButton();
            this.passwordTxt = new CustomControls.RJControls.RJTextBox();
            this.kullaniciAdiTxt = new CustomControls.RJControls.RJTextBox();
            this.emailTxt = new CustomControls.RJControls.RJTextBox();
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
            this.bigLabel1.Location = new System.Drawing.Point(898, 725);
            this.bigLabel1.Name = "bigLabel1";
            this.bigLabel1.Size = new System.Drawing.Size(207, 46);
            this.bigLabel1.TabIndex = 0;
            this.bigLabel1.Text = "Admin Panel";
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
            this.Column3,
            this.password,
            this.Access});
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
            this.poisonDataGridView1.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.poisonDataGridView1_CellEnter);
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
            this.Column4.Width = 150;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Email";
            this.Column3.Name = "Column3";
            this.Column3.Width = 200;
            // 
            // password
            // 
            this.password.HeaderText = "Şifre";
            this.password.Name = "password";
            this.password.Visible = false;
            // 
            // Access
            // 
            this.Access.HeaderText = "Yetki";
            this.Access.Name = "Access";
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
            this.poisonDataGridView2.Size = new System.Drawing.Size(347, 245);
            this.poisonDataGridView2.TabIndex = 6;
            this.poisonDataGridView2.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.poisonDataGridView2_CellEnter);
            // 
            // departmanID
            // 
            this.departmanID.HeaderText = "ID";
            this.departmanID.Name = "departmanID";
            this.departmanID.ReadOnly = true;
            // 
            // departmanName
            // 
            this.departmanName.HeaderText = "Departman";
            this.departmanName.Name = "departmanName";
            this.departmanName.ReadOnly = true;
            this.departmanName.Width = 200;
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
            // metroComboBox2
            // 
            this.metroComboBox2.FormattingEnabled = true;
            this.metroComboBox2.ItemHeight = 23;
            this.metroComboBox2.Items.AddRange(new object[] {
            "Yönetici",
            "Kullanıcı"});
            this.metroComboBox2.Location = new System.Drawing.Point(864, 283);
            this.metroComboBox2.Name = "metroComboBox2";
            this.metroComboBox2.Size = new System.Drawing.Size(250, 29);
            this.metroComboBox2.TabIndex = 29;
            // 
            // dungeonLabel5
            // 
            this.dungeonLabel5.AutoSize = true;
            this.dungeonLabel5.BackColor = System.Drawing.Color.Transparent;
            this.dungeonLabel5.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.dungeonLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(77)))));
            this.dungeonLabel5.Location = new System.Drawing.Point(770, 283);
            this.dungeonLabel5.Name = "dungeonLabel5";
            this.dungeonLabel5.Size = new System.Drawing.Size(40, 20);
            this.dungeonLabel5.TabIndex = 28;
            this.dungeonLabel5.Text = "Yetki";
            // 
            // metroComboBox1
            // 
            this.metroComboBox1.FormattingEnabled = true;
            this.metroComboBox1.ItemHeight = 23;
            this.metroComboBox1.Location = new System.Drawing.Point(864, 188);
            this.metroComboBox1.Name = "metroComboBox1";
            this.metroComboBox1.Size = new System.Drawing.Size(250, 29);
            this.metroComboBox1.TabIndex = 27;
            // 
            // dungeonLabel4
            // 
            this.dungeonLabel4.AutoSize = true;
            this.dungeonLabel4.BackColor = System.Drawing.Color.Transparent;
            this.dungeonLabel4.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.dungeonLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(77)))));
            this.dungeonLabel4.Location = new System.Drawing.Point(765, 233);
            this.dungeonLabel4.Name = "dungeonLabel4";
            this.dungeonLabel4.Size = new System.Drawing.Size(39, 20);
            this.dungeonLabel4.TabIndex = 25;
            this.dungeonLabel4.Text = "Şifre";
            // 
            // dungeonLabel3
            // 
            this.dungeonLabel3.AutoSize = true;
            this.dungeonLabel3.BackColor = System.Drawing.Color.Transparent;
            this.dungeonLabel3.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.dungeonLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(77)))));
            this.dungeonLabel3.Location = new System.Drawing.Point(765, 188);
            this.dungeonLabel3.Name = "dungeonLabel3";
            this.dungeonLabel3.Size = new System.Drawing.Size(84, 20);
            this.dungeonLabel3.TabIndex = 23;
            this.dungeonLabel3.Text = "Departman";
            // 
            // dungeonLabel6
            // 
            this.dungeonLabel6.AutoSize = true;
            this.dungeonLabel6.BackColor = System.Drawing.Color.Transparent;
            this.dungeonLabel6.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.dungeonLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(77)))));
            this.dungeonLabel6.Location = new System.Drawing.Point(770, 144);
            this.dungeonLabel6.Name = "dungeonLabel6";
            this.dungeonLabel6.Size = new System.Drawing.Size(46, 20);
            this.dungeonLabel6.TabIndex = 22;
            this.dungeonLabel6.Text = "Email";
            // 
            // dungeonLabel7
            // 
            this.dungeonLabel7.AutoSize = true;
            this.dungeonLabel7.BackColor = System.Drawing.Color.Transparent;
            this.dungeonLabel7.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.dungeonLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(77)))));
            this.dungeonLabel7.Location = new System.Drawing.Point(765, 99);
            this.dungeonLabel7.Name = "dungeonLabel7";
            this.dungeonLabel7.Size = new System.Drawing.Size(92, 20);
            this.dungeonLabel7.TabIndex = 21;
            this.dungeonLabel7.Text = "Kullanıcı Adı";
            // 
            // txtEmpid
            // 
            this.txtEmpid.Location = new System.Drawing.Point(864, 63);
            this.txtEmpid.Name = "txtEmpid";
            this.txtEmpid.Size = new System.Drawing.Size(100, 20);
            this.txtEmpid.TabIndex = 30;
            this.txtEmpid.Visible = false;
            // 
            // depUpdateid
            // 
            this.depUpdateid.Location = new System.Drawing.Point(306, 691);
            this.depUpdateid.Name = "depUpdateid";
            this.depUpdateid.Size = new System.Drawing.Size(100, 20);
            this.depUpdateid.TabIndex = 34;
            this.depUpdateid.Visible = false;
            // 
            // departmantUpdatetxt
            // 
            this.departmantUpdatetxt.BackColor = System.Drawing.SystemColors.Window;
            this.departmantUpdatetxt.BorderColor = System.Drawing.Color.DarkGray;
            this.departmantUpdatetxt.BorderFocusColor = System.Drawing.SystemColors.MenuHighlight;
            this.departmantUpdatetxt.BorderRadius = 10;
            this.departmantUpdatetxt.BorderSize = 2;
            this.departmantUpdatetxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.departmantUpdatetxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.departmantUpdatetxt.Location = new System.Drawing.Point(49, 692);
            this.departmantUpdatetxt.Margin = new System.Windows.Forms.Padding(4);
            this.departmantUpdatetxt.Multiline = false;
            this.departmantUpdatetxt.Name = "departmantUpdatetxt";
            this.departmantUpdatetxt.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.departmantUpdatetxt.PasswordChar = false;
            this.departmantUpdatetxt.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.departmantUpdatetxt.PlaceholderText = "";
            this.departmantUpdatetxt.Size = new System.Drawing.Size(250, 37);
            this.departmantUpdatetxt.TabIndex = 33;
            this.departmantUpdatetxt.Texts = "";
            this.departmantUpdatetxt.UnderlinedStyle = false;
            // 
            // depUpdatebtn
            // 
            this.depUpdatebtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.depUpdatebtn.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.depUpdatebtn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.depUpdatebtn.BorderRadius = 0;
            this.depUpdatebtn.BorderSize = 0;
            this.depUpdatebtn.FlatAppearance.BorderSize = 0;
            this.depUpdatebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.depUpdatebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.depUpdatebtn.ForeColor = System.Drawing.Color.White;
            this.depUpdatebtn.Location = new System.Drawing.Point(82, 733);
            this.depUpdatebtn.Name = "depUpdatebtn";
            this.depUpdatebtn.Size = new System.Drawing.Size(186, 35);
            this.depUpdatebtn.TabIndex = 32;
            this.depUpdatebtn.Text = "Departman Adı Güncelle";
            this.depUpdatebtn.TextColor = System.Drawing.Color.White;
            this.depUpdatebtn.UseVisualStyleBackColor = false;
            this.depUpdatebtn.Click += new System.EventHandler(this.depUpdatebtn_Click);
            // 
            // rjButton1
            // 
            this.rjButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rjButton1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rjButton1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjButton1.BorderRadius = 0;
            this.rjButton1.BorderSize = 0;
            this.rjButton1.FlatAppearance.BorderSize = 0;
            this.rjButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rjButton1.ForeColor = System.Drawing.Color.White;
            this.rjButton1.Location = new System.Drawing.Point(926, 333);
            this.rjButton1.Name = "rjButton1";
            this.rjButton1.Size = new System.Drawing.Size(137, 35);
            this.rjButton1.TabIndex = 26;
            this.rjButton1.Text = "Kullanıcı Güncelle";
            this.rjButton1.TextColor = System.Drawing.Color.White;
            this.rjButton1.UseVisualStyleBackColor = false;
            this.rjButton1.Click += new System.EventHandler(this.rjButton1_Click);
            // 
            // passwordTxt
            // 
            this.passwordTxt.BackColor = System.Drawing.SystemColors.Window;
            this.passwordTxt.BorderColor = System.Drawing.Color.Silver;
            this.passwordTxt.BorderFocusColor = System.Drawing.SystemColors.MenuHighlight;
            this.passwordTxt.BorderRadius = 10;
            this.passwordTxt.BorderSize = 2;
            this.passwordTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.passwordTxt.Location = new System.Drawing.Point(864, 225);
            this.passwordTxt.Margin = new System.Windows.Forms.Padding(4);
            this.passwordTxt.Multiline = false;
            this.passwordTxt.Name = "passwordTxt";
            this.passwordTxt.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.passwordTxt.PasswordChar = false;
            this.passwordTxt.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.passwordTxt.PlaceholderText = "";
            this.passwordTxt.Size = new System.Drawing.Size(250, 37);
            this.passwordTxt.TabIndex = 24;
            this.passwordTxt.Texts = "";
            this.passwordTxt.UnderlinedStyle = false;
            // 
            // kullaniciAdiTxt
            // 
            this.kullaniciAdiTxt.BackColor = System.Drawing.SystemColors.Window;
            this.kullaniciAdiTxt.BorderColor = System.Drawing.Color.DarkGray;
            this.kullaniciAdiTxt.BorderFocusColor = System.Drawing.SystemColors.MenuHighlight;
            this.kullaniciAdiTxt.BorderRadius = 10;
            this.kullaniciAdiTxt.BorderSize = 2;
            this.kullaniciAdiTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kullaniciAdiTxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.kullaniciAdiTxt.Location = new System.Drawing.Point(864, 90);
            this.kullaniciAdiTxt.Margin = new System.Windows.Forms.Padding(4);
            this.kullaniciAdiTxt.Multiline = false;
            this.kullaniciAdiTxt.Name = "kullaniciAdiTxt";
            this.kullaniciAdiTxt.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.kullaniciAdiTxt.PasswordChar = false;
            this.kullaniciAdiTxt.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.kullaniciAdiTxt.PlaceholderText = "";
            this.kullaniciAdiTxt.Size = new System.Drawing.Size(250, 37);
            this.kullaniciAdiTxt.TabIndex = 20;
            this.kullaniciAdiTxt.Texts = "";
            this.kullaniciAdiTxt.UnderlinedStyle = false;
            // 
            // emailTxt
            // 
            this.emailTxt.BackColor = System.Drawing.SystemColors.Window;
            this.emailTxt.BorderColor = System.Drawing.Color.Silver;
            this.emailTxt.BorderFocusColor = System.Drawing.SystemColors.MenuHighlight;
            this.emailTxt.BorderRadius = 10;
            this.emailTxt.BorderSize = 2;
            this.emailTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailTxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.emailTxt.Location = new System.Drawing.Point(864, 135);
            this.emailTxt.Margin = new System.Windows.Forms.Padding(4);
            this.emailTxt.Multiline = false;
            this.emailTxt.Name = "emailTxt";
            this.emailTxt.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.emailTxt.PasswordChar = false;
            this.emailTxt.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.emailTxt.PlaceholderText = "";
            this.emailTxt.Size = new System.Drawing.Size(250, 37);
            this.emailTxt.TabIndex = 19;
            this.emailTxt.Texts = "";
            this.emailTxt.UnderlinedStyle = false;
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
            this.departmanAdd.Location = new System.Drawing.Point(222, 406);
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
            this.DepartmanDelete.Location = new System.Drawing.Point(269, 406);
            this.DepartmanDelete.Name = "DepartmanDelete";
            this.DepartmanDelete.Size = new System.Drawing.Size(30, 33);
            this.DepartmanDelete.TabIndex = 10;
            this.DepartmanDelete.TextColor = System.Drawing.Color.White;
            this.DepartmanDelete.UseVisualStyleBackColor = false;
            this.DepartmanDelete.Click += new System.EventHandler(this.DepartmanDelete_Click);
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
            this.DepartmanRefresh.Location = new System.Drawing.Point(316, 411);
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
            this.KullaniciEkleBtn.Location = new System.Drawing.Point(561, 15);
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
            this.rjButton3.Location = new System.Drawing.Point(648, 13);
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
            this.rjButton2.Location = new System.Drawing.Point(720, 19);
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
            this.Controls.Add(this.depUpdateid);
            this.Controls.Add(this.departmantUpdatetxt);
            this.Controls.Add(this.depUpdatebtn);
            this.Controls.Add(this.txtEmpid);
            this.Controls.Add(this.metroComboBox2);
            this.Controls.Add(this.dungeonLabel5);
            this.Controls.Add(this.metroComboBox1);
            this.Controls.Add(this.rjButton1);
            this.Controls.Add(this.dungeonLabel4);
            this.Controls.Add(this.passwordTxt);
            this.Controls.Add(this.dungeonLabel3);
            this.Controls.Add(this.dungeonLabel6);
            this.Controls.Add(this.dungeonLabel7);
            this.Controls.Add(this.kullaniciAdiTxt);
            this.Controls.Add(this.emailTxt);
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
        private ReaLTaiizor.Controls.DungeonLabel dungeonLabel1;
        private ReaLTaiizor.Controls.DungeonLabel dungeonLabel2;
        private CustomControls.RJControls.RJButton departmanAdd;
        private CustomControls.RJControls.RJButton DepartmanDelete;
        private CustomControls.RJControls.RJButton DepartmanRefresh;
        private ReaLTaiizor.Controls.PoisonDataGridView poisonDataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn departmanID;
        private System.Windows.Forms.DataGridViewTextBoxColumn departmanName;
        private MetroFramework.Controls.MetroComboBox metroComboBox2;
        private ReaLTaiizor.Controls.DungeonLabel dungeonLabel5;
        private MetroFramework.Controls.MetroComboBox metroComboBox1;
        private CustomControls.RJControls.RJButton rjButton1;
        private ReaLTaiizor.Controls.DungeonLabel dungeonLabel4;
        private CustomControls.RJControls.RJTextBox passwordTxt;
        private ReaLTaiizor.Controls.DungeonLabel dungeonLabel3;
        private ReaLTaiizor.Controls.DungeonLabel dungeonLabel6;
        private ReaLTaiizor.Controls.DungeonLabel dungeonLabel7;
        private CustomControls.RJControls.RJTextBox kullaniciAdiTxt;
        private CustomControls.RJControls.RJTextBox emailTxt;
        private System.Windows.Forms.TextBox txtEmpid;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn password;
        private System.Windows.Forms.DataGridViewTextBoxColumn Access;
        private CustomControls.RJControls.RJTextBox departmantUpdatetxt;
        private CustomControls.RJControls.RJButton depUpdatebtn;
        private System.Windows.Forms.TextBox depUpdateid;
    }
}