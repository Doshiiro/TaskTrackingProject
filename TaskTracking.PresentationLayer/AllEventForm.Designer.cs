namespace TaskTracking.PresentationLayer
{
    partial class AllEventForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AllEventForm));
            this.poisonDataGridView1 = new ReaLTaiizor.Controls.PoisonDataGridView();
            this.CalendarID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PersonelName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CalenderDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PersonelEvent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FkID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ribbonGroupBox1 = new ReaLTaiizor.Controls.RibbonGroupBox();
            this.rjButton1 = new CustomControls.RJControls.RJButton();
            this.poisonDateTime1 = new ReaLTaiizor.Controls.PoisonDateTime();
            this.txtFK = new CustomControls.RJControls.RJTextBox();
            this.txtCalendarID = new CustomControls.RJControls.RJTextBox();
            this.txtPersonel = new CustomControls.RJControls.RJTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSave = new CustomControls.RJControls.RJButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEvent = new CustomControls.RJControls.RJTextBox();
            this.closeBtn = new CustomControls.RJControls.RJButton();
            ((System.ComponentModel.ISupportInitialize)(this.poisonDataGridView1)).BeginInit();
            this.ribbonGroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // poisonDataGridView1
            // 
            this.poisonDataGridView1.AllowUserToAddRows = false;
            this.poisonDataGridView1.AllowUserToResizeRows = false;
            this.poisonDataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
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
            this.CalendarID,
            this.PersonelName,
            this.CalenderDate,
            this.PersonelEvent,
            this.FkID});
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
            this.poisonDataGridView1.Location = new System.Drawing.Point(2, 32);
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
            this.poisonDataGridView1.RowHeadersWidth = 60;
            this.poisonDataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.poisonDataGridView1.RowTemplate.Height = 25;
            this.poisonDataGridView1.RowTemplate.ReadOnly = true;
            this.poisonDataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.poisonDataGridView1.Size = new System.Drawing.Size(762, 355);
            this.poisonDataGridView1.TabIndex = 25;
            this.poisonDataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.poisonDataGridView1_CellContentClick);
            this.poisonDataGridView1.SelectionChanged += new System.EventHandler(this.poisonDataGridView1_SelectionChanged);
            // 
            // CalendarID
            // 
            this.CalendarID.HeaderText = "ID";
            this.CalendarID.Name = "CalendarID";
            this.CalendarID.Visible = false;
            // 
            // PersonelName
            // 
            this.PersonelName.HeaderText = "Personel";
            this.PersonelName.Name = "PersonelName";
            // 
            // CalenderDate
            // 
            this.CalenderDate.HeaderText = "Tarih";
            this.CalenderDate.Name = "CalenderDate";
            // 
            // PersonelEvent
            // 
            this.PersonelEvent.HeaderText = "Görev";
            this.PersonelEvent.Name = "PersonelEvent";
            // 
            // FkID
            // 
            this.FkID.HeaderText = "FkId";
            this.FkID.Name = "FkID";
            this.FkID.Visible = false;
            // 
            // ribbonGroupBox1
            // 
            this.ribbonGroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.ribbonGroupBox1.BaseColor = System.Drawing.Color.Transparent;
            this.ribbonGroupBox1.BorderColorA = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(143)))), ((int)(((byte)(143)))));
            this.ribbonGroupBox1.BorderColorB = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(178)))), ((int)(((byte)(172)))));
            this.ribbonGroupBox1.BorderColorC = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(192)))), ((int)(((byte)(200)))));
            this.ribbonGroupBox1.CompositingQualityType = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
            this.ribbonGroupBox1.Controls.Add(this.rjButton1);
            this.ribbonGroupBox1.Controls.Add(this.poisonDateTime1);
            this.ribbonGroupBox1.Controls.Add(this.txtFK);
            this.ribbonGroupBox1.Controls.Add(this.txtCalendarID);
            this.ribbonGroupBox1.Controls.Add(this.txtPersonel);
            this.ribbonGroupBox1.Controls.Add(this.label3);
            this.ribbonGroupBox1.Controls.Add(this.btnSave);
            this.ribbonGroupBox1.Controls.Add(this.label2);
            this.ribbonGroupBox1.Controls.Add(this.label1);
            this.ribbonGroupBox1.Controls.Add(this.txtEvent);
            this.ribbonGroupBox1.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.ribbonGroupBox1.ForeColor = System.Drawing.Color.Black;
            this.ribbonGroupBox1.LineColorA = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(126)))), ((int)(((byte)(126)))));
            this.ribbonGroupBox1.LineColorB = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(126)))), ((int)(((byte)(126)))));
            this.ribbonGroupBox1.Location = new System.Drawing.Point(12, 393);
            this.ribbonGroupBox1.Name = "ribbonGroupBox1";
            this.ribbonGroupBox1.Size = new System.Drawing.Size(740, 235);
            this.ribbonGroupBox1.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.ribbonGroupBox1.TabIndex = 29;
            this.ribbonGroupBox1.Text = "Düzenle";
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
            this.rjButton1.Location = new System.Drawing.Point(587, 143);
            this.rjButton1.Name = "rjButton1";
            this.rjButton1.Size = new System.Drawing.Size(95, 35);
            this.rjButton1.TabIndex = 33;
            this.rjButton1.Text = "Sil";
            this.rjButton1.TextColor = System.Drawing.Color.White;
            this.rjButton1.UseVisualStyleBackColor = false;
            this.rjButton1.Click += new System.EventHandler(this.rjButton1_Click);
            // 
            // poisonDateTime1
            // 
            this.poisonDateTime1.Location = new System.Drawing.Point(55, 76);
            this.poisonDateTime1.MinimumSize = new System.Drawing.Size(0, 29);
            this.poisonDateTime1.Name = "poisonDateTime1";
            this.poisonDateTime1.Size = new System.Drawing.Size(200, 29);
            this.poisonDateTime1.TabIndex = 32;
            // 
            // txtFK
            // 
            this.txtFK.BackColor = System.Drawing.SystemColors.Window;
            this.txtFK.BorderColor = System.Drawing.Color.Silver;
            this.txtFK.BorderFocusColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtFK.BorderRadius = 10;
            this.txtFK.BorderSize = 2;
            this.txtFK.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFK.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtFK.Location = new System.Drawing.Point(715, 199);
            this.txtFK.Margin = new System.Windows.Forms.Padding(4);
            this.txtFK.Multiline = false;
            this.txtFK.Name = "txtFK";
            this.txtFK.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtFK.PasswordChar = false;
            this.txtFK.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtFK.PlaceholderText = "";
            this.txtFK.Size = new System.Drawing.Size(24, 37);
            this.txtFK.TabIndex = 30;
            this.txtFK.Texts = "";
            this.txtFK.UnderlinedStyle = false;
            this.txtFK.Visible = false;
            // 
            // txtCalendarID
            // 
            this.txtCalendarID.BackColor = System.Drawing.SystemColors.Window;
            this.txtCalendarID.BorderColor = System.Drawing.Color.Silver;
            this.txtCalendarID.BorderFocusColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtCalendarID.BorderRadius = 10;
            this.txtCalendarID.BorderSize = 2;
            this.txtCalendarID.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCalendarID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtCalendarID.Location = new System.Drawing.Point(689, 199);
            this.txtCalendarID.Margin = new System.Windows.Forms.Padding(4);
            this.txtCalendarID.Multiline = false;
            this.txtCalendarID.Name = "txtCalendarID";
            this.txtCalendarID.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtCalendarID.PasswordChar = false;
            this.txtCalendarID.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtCalendarID.PlaceholderText = "";
            this.txtCalendarID.Size = new System.Drawing.Size(29, 37);
            this.txtCalendarID.TabIndex = 29;
            this.txtCalendarID.Texts = "";
            this.txtCalendarID.UnderlinedStyle = false;
            this.txtCalendarID.Visible = false;
            // 
            // txtPersonel
            // 
            this.txtPersonel.BackColor = System.Drawing.SystemColors.Window;
            this.txtPersonel.BorderColor = System.Drawing.Color.Silver;
            this.txtPersonel.BorderFocusColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtPersonel.BorderRadius = 10;
            this.txtPersonel.BorderSize = 2;
            this.txtPersonel.Enabled = false;
            this.txtPersonel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPersonel.ForeColor = System.Drawing.Color.Black;
            this.txtPersonel.Location = new System.Drawing.Point(441, 68);
            this.txtPersonel.Margin = new System.Windows.Forms.Padding(4);
            this.txtPersonel.Multiline = false;
            this.txtPersonel.Name = "txtPersonel";
            this.txtPersonel.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtPersonel.PasswordChar = false;
            this.txtPersonel.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtPersonel.PlaceholderText = "";
            this.txtPersonel.Size = new System.Drawing.Size(241, 37);
            this.txtPersonel.TabIndex = 28;
            this.txtPersonel.Texts = "";
            this.txtPersonel.UnderlinedStyle = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(438, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 17);
            this.label3.TabIndex = 26;
            this.label3.Text = "Personel";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSave.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSave.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnSave.BorderRadius = 0;
            this.btnSave.BorderSize = 0;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(441, 143);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(95, 35);
            this.btnSave.TabIndex = 25;
            this.btnSave.Text = "Güncelle";
            this.btnSave.TextColor = System.Drawing.Color.White;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 17);
            this.label2.TabIndex = 24;
            this.label2.Text = "Event";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 17);
            this.label1.TabIndex = 23;
            this.label1.Text = "Date";
            // 
            // txtEvent
            // 
            this.txtEvent.BackColor = System.Drawing.SystemColors.Window;
            this.txtEvent.BorderColor = System.Drawing.Color.Silver;
            this.txtEvent.BorderFocusColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtEvent.BorderRadius = 10;
            this.txtEvent.BorderSize = 2;
            this.txtEvent.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEvent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtEvent.Location = new System.Drawing.Point(55, 141);
            this.txtEvent.Margin = new System.Windows.Forms.Padding(4);
            this.txtEvent.Multiline = false;
            this.txtEvent.Name = "txtEvent";
            this.txtEvent.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtEvent.PasswordChar = false;
            this.txtEvent.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtEvent.PlaceholderText = "";
            this.txtEvent.Size = new System.Drawing.Size(311, 37);
            this.txtEvent.TabIndex = 22;
            this.txtEvent.Texts = "";
            this.txtEvent.UnderlinedStyle = false;
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
            this.closeBtn.Location = new System.Drawing.Point(727, 0);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(37, 32);
            this.closeBtn.TabIndex = 22;
            this.closeBtn.TextColor = System.Drawing.Color.White;
            this.closeBtn.UseVisualStyleBackColor = false;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // AllEventForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 640);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.ribbonGroupBox1);
            this.Controls.Add(this.poisonDataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AllEventForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Görevler";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.AllEventForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.poisonDataGridView1)).EndInit();
            this.ribbonGroupBox1.ResumeLayout(false);
            this.ribbonGroupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private CustomControls.RJControls.RJButton closeBtn;
        private ReaLTaiizor.Controls.PoisonDataGridView poisonDataGridView1;
        private ReaLTaiizor.Controls.RibbonGroupBox ribbonGroupBox1;
        private System.Windows.Forms.Label label3;
        private CustomControls.RJControls.RJButton btnSave;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private CustomControls.RJControls.RJTextBox txtEvent;
        private CustomControls.RJControls.RJTextBox txtPersonel;
        private CustomControls.RJControls.RJTextBox txtCalendarID;
        private CustomControls.RJControls.RJTextBox txtFK;
        private System.Windows.Forms.DataGridViewTextBoxColumn CalendarID;
        private System.Windows.Forms.DataGridViewTextBoxColumn PersonelName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CalenderDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn PersonelEvent;
        private System.Windows.Forms.DataGridViewTextBoxColumn FkID;
        private ReaLTaiizor.Controls.PoisonDateTime poisonDateTime1;
        private CustomControls.RJControls.RJButton rjButton1;
    }
}