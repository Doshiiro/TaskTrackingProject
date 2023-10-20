namespace TaskTracking.PresentationLayer
{
    partial class EventForm
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
            this.txtEvent = new CustomControls.RJControls.RJTextBox();
            this.txtDate = new CustomControls.RJControls.RJTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSave = new CustomControls.RJControls.RJButton();
            this.SuspendLayout();
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
            this.txtEvent.Location = new System.Drawing.Point(139, 169);
            this.txtEvent.Margin = new System.Windows.Forms.Padding(4);
            this.txtEvent.Multiline = false;
            this.txtEvent.Name = "txtEvent";
            this.txtEvent.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtEvent.PasswordChar = false;
            this.txtEvent.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtEvent.PlaceholderText = "";
            this.txtEvent.Size = new System.Drawing.Size(397, 37);
            this.txtEvent.TabIndex = 14;
            this.txtEvent.Texts = "";
            this.txtEvent.UnderlinedStyle = false;
            // 
            // txtDate
            // 
            this.txtDate.BackColor = System.Drawing.SystemColors.Window;
            this.txtDate.BorderColor = System.Drawing.Color.Silver;
            this.txtDate.BorderFocusColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtDate.BorderRadius = 10;
            this.txtDate.BorderSize = 2;
            this.txtDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtDate.Location = new System.Drawing.Point(139, 71);
            this.txtDate.Margin = new System.Windows.Forms.Padding(4);
            this.txtDate.Multiline = false;
            this.txtDate.Name = "txtDate";
            this.txtDate.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtDate.PasswordChar = false;
            this.txtDate.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtDate.PlaceholderText = "";
            this.txtDate.Size = new System.Drawing.Size(397, 37);
            this.txtDate.TabIndex = 12;
            this.txtDate.Texts = "";
            this.txtDate.UnderlinedStyle = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(149, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(149, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Event";
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
            this.btnSave.Location = new System.Drawing.Point(430, 268);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(106, 35);
            this.btnSave.TabIndex = 17;
            this.btnSave.Text = "Kaydet";
            this.btnSave.TextColor = System.Drawing.Color.White;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // EvenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 382);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtEvent);
            this.Controls.Add(this.txtDate);
            this.Name = "EvenForm";
            this.Text = "EvenForm";
            this.Load += new System.EventHandler(this.EvenForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomControls.RJControls.RJTextBox txtEvent;
        private CustomControls.RJControls.RJTextBox txtDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private CustomControls.RJControls.RJButton btnSave;
    }
}