namespace TaskTracking.PresentationLayer
{
    partial class DefaultUserEvent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DefaultUserEvent));
            this.bigLabel1 = new ReaLTaiizor.Controls.BigLabel();
            this.metroListBox1 = new ReaLTaiizor.Controls.MetroListBox();
            this.closeBtn = new CustomControls.RJControls.RJButton();
            this.SuspendLayout();
            // 
            // bigLabel1
            // 
            this.bigLabel1.AutoSize = true;
            this.bigLabel1.BackColor = System.Drawing.Color.Transparent;
            this.bigLabel1.Font = new System.Drawing.Font("Segoe UI", 25F);
            this.bigLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.bigLabel1.Location = new System.Drawing.Point(170, -1);
            this.bigLabel1.Name = "bigLabel1";
            this.bigLabel1.Size = new System.Drawing.Size(193, 46);
            this.bigLabel1.TabIndex = 0;
            this.bigLabel1.Text = "Yapılacaklar";
            this.bigLabel1.Click += new System.EventHandler(this.bigLabel1_Click);
            // 
            // metroListBox1
            // 
            this.metroListBox1.BackColor = System.Drawing.Color.White;
            this.metroListBox1.BorderColor = System.Drawing.Color.LightGray;
            this.metroListBox1.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.metroListBox1.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.metroListBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.metroListBox1.HoveredItemBackColor = System.Drawing.Color.LightGray;
            this.metroListBox1.HoveredItemColor = System.Drawing.Color.DimGray;
            this.metroListBox1.IsDerivedStyle = true;
            this.metroListBox1.ItemHeight = 30;
            this.metroListBox1.Location = new System.Drawing.Point(0, 58);
            this.metroListBox1.MultiSelect = false;
            this.metroListBox1.Name = "metroListBox1";
            this.metroListBox1.SelectedIndex = -1;
            this.metroListBox1.SelectedItem = null;
            this.metroListBox1.SelectedItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroListBox1.SelectedItemColor = System.Drawing.Color.White;
            this.metroListBox1.SelectedText = null;
            this.metroListBox1.SelectedValue = null;
            this.metroListBox1.ShowBorder = false;
            this.metroListBox1.ShowScrollBar = false;
            this.metroListBox1.Size = new System.Drawing.Size(539, 345);
            this.metroListBox1.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            this.metroListBox1.StyleManager = null;
            this.metroListBox1.TabIndex = 25;
            this.metroListBox1.ThemeAuthor = "Taiizor";
            this.metroListBox1.ThemeName = "MetroLight";
            this.metroListBox1.SelectedIndexChanged += new ReaLTaiizor.Controls.MetroListBox.SelectedIndexChangedEventHandler(this.metroListBox1_SelectedIndexChanged);
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
            this.closeBtn.Location = new System.Drawing.Point(498, -1);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(41, 31);
            this.closeBtn.TabIndex = 22;
            this.closeBtn.TextColor = System.Drawing.Color.White;
            this.closeBtn.UseVisualStyleBackColor = false;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // DefaultUserEvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 400);
            this.Controls.Add(this.metroListBox1);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.bigLabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DefaultUserEvent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DefaultUserEvent";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.DefaultUserEvent_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ReaLTaiizor.Controls.BigLabel bigLabel1;
        private CustomControls.RJControls.RJButton closeBtn;
        private ReaLTaiizor.Controls.MetroListBox metroListBox1;
    }
}