namespace TaskTracking.PresentationLayer
{
    partial class ProjeAddForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProjeAddForm));
            this.metroComboBox1 = new ReaLTaiizor.Controls.MetroComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.closeBtn = new CustomControls.RJControls.RJButton();
            this.btnSave = new CustomControls.RJControls.RJButton();
            this.projeNameTxt = new CustomControls.RJControls.RJTextBox();
            this.SuspendLayout();
            // 
            // metroComboBox1
            // 
            this.metroComboBox1.AllowDrop = true;
            this.metroComboBox1.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.metroComboBox1.BackColor = System.Drawing.Color.Transparent;
            this.metroComboBox1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.metroComboBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.metroComboBox1.CausesValidation = false;
            this.metroComboBox1.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.metroComboBox1.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.metroComboBox1.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.metroComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.metroComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.metroComboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.metroComboBox1.FormattingEnabled = true;
            this.metroComboBox1.IsDerivedStyle = true;
            this.metroComboBox1.ItemHeight = 20;
            this.metroComboBox1.Location = new System.Drawing.Point(32, 191);
            this.metroComboBox1.Name = "metroComboBox1";
            this.metroComboBox1.SelectedItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroComboBox1.SelectedItemForeColor = System.Drawing.Color.White;
            this.metroComboBox1.Size = new System.Drawing.Size(245, 26);
            this.metroComboBox1.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            this.metroComboBox1.StyleManager = null;
            this.metroComboBox1.TabIndex = 27;
            this.metroComboBox1.ThemeAuthor = "Taiizor";
            this.metroComboBox1.ThemeName = "MetroLight";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(41, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 20);
            this.label2.TabIndex = 24;
            this.label2.Text = "Proje Yöneticisi";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(41, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 20);
            this.label1.TabIndex = 23;
            this.label1.Text = "Proje ismi";
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
            this.closeBtn.Location = new System.Drawing.Point(430, -1);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(41, 31);
            this.closeBtn.TabIndex = 28;
            this.closeBtn.TextColor = System.Drawing.Color.White;
            this.closeBtn.UseVisualStyleBackColor = false;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
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
            this.btnSave.Location = new System.Drawing.Point(323, 186);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(106, 35);
            this.btnSave.TabIndex = 25;
            this.btnSave.Text = "Kaydet";
            this.btnSave.TextColor = System.Drawing.Color.White;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // projeNameTxt
            // 
            this.projeNameTxt.BackColor = System.Drawing.SystemColors.Window;
            this.projeNameTxt.BorderColor = System.Drawing.Color.Silver;
            this.projeNameTxt.BorderFocusColor = System.Drawing.SystemColors.MenuHighlight;
            this.projeNameTxt.BorderRadius = 10;
            this.projeNameTxt.BorderSize = 2;
            this.projeNameTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.projeNameTxt.ForeColor = System.Drawing.Color.Black;
            this.projeNameTxt.Location = new System.Drawing.Point(32, 73);
            this.projeNameTxt.Margin = new System.Windows.Forms.Padding(4);
            this.projeNameTxt.Multiline = false;
            this.projeNameTxt.Name = "projeNameTxt";
            this.projeNameTxt.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.projeNameTxt.PasswordChar = false;
            this.projeNameTxt.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.projeNameTxt.PlaceholderText = "";
            this.projeNameTxt.Size = new System.Drawing.Size(397, 37);
            this.projeNameTxt.TabIndex = 21;
            this.projeNameTxt.Texts = "";
            this.projeNameTxt.UnderlinedStyle = false;
            // 
            // ProjeAddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 252);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.metroComboBox1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.projeNameTxt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ProjeAddForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProjeAddForm";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.ProjeAddForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ReaLTaiizor.Controls.MetroComboBox metroComboBox1;
        private CustomControls.RJControls.RJButton btnSave;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private CustomControls.RJControls.RJTextBox projeNameTxt;
        private CustomControls.RJControls.RJButton closeBtn;
    }
}