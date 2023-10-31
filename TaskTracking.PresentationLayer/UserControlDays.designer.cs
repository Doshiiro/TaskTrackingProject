namespace takvim
{
    partial class UserControlDays
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControlDays));
            this.lbgunler = new System.Windows.Forms.Label();
            this.lblEvent = new ReaLTaiizor.Controls.BigLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.rjButton2 = new CustomControls.RJControls.RJButton();
            this.SuspendLayout();
            // 
            // lbgunler
            // 
            this.lbgunler.AutoSize = true;
            this.lbgunler.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbgunler.Location = new System.Drawing.Point(16, 17);
            this.lbgunler.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbgunler.Name = "lbgunler";
            this.lbgunler.Size = new System.Drawing.Size(24, 18);
            this.lbgunler.TabIndex = 0;
            this.lbgunler.Text = "00";
            this.lbgunler.Click += new System.EventHandler(this.lbgunler_Click);
            // 
            // lblEvent
            // 
            this.lblEvent.BackColor = System.Drawing.Color.Transparent;
            this.lblEvent.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblEvent.ForeColor = System.Drawing.Color.Maroon;
            this.lblEvent.Location = new System.Drawing.Point(3, 50);
            this.lblEvent.Name = "lblEvent";
            this.lblEvent.Size = new System.Drawing.Size(124, 35);
            this.lblEvent.TabIndex = 1;
            this.lblEvent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblEvent.Click += new System.EventHandler(this.lblEvent_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
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
            this.rjButton2.Location = new System.Drawing.Point(45, 9);
            this.rjButton2.Name = "rjButton2";
            this.rjButton2.Size = new System.Drawing.Size(46, 38);
            this.rjButton2.TabIndex = 4;
            this.rjButton2.TextColor = System.Drawing.Color.White;
            this.rjButton2.UseVisualStyleBackColor = false;
            this.rjButton2.Click += new System.EventHandler(this.rjButton2_Click);
            // 
            // UserControlDays
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.rjButton2);
            this.Controls.Add(this.lblEvent);
            this.Controls.Add(this.lbgunler);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "UserControlDays";
            this.Size = new System.Drawing.Size(130, 85);
            this.Load += new System.EventHandler(this.UserControlDays_Load);
            this.Click += new System.EventHandler(this.UserControlDays_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbgunler;
        private ReaLTaiizor.Controls.BigLabel lblEvent;
        private System.Windows.Forms.Timer timer1;
        private CustomControls.RJControls.RJButton rjButton2;
    }
}
