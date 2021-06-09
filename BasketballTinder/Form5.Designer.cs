
namespace BasketballTinder
{
    partial class Form5
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SaveAttForm5 = new System.Windows.Forms.Button();
            this.AttendanceShow = new System.Windows.Forms.Label();
            this.DataCitita = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.OraCitita = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Existing Attendance:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(489, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Update Attendace:";
            // 
            // SaveAttForm5
            // 
            this.SaveAttForm5.Location = new System.Drawing.Point(54, 470);
            this.SaveAttForm5.Name = "SaveAttForm5";
            this.SaveAttForm5.Size = new System.Drawing.Size(140, 49);
            this.SaveAttForm5.TabIndex = 4;
            this.SaveAttForm5.Text = "Save Attendance";
            this.SaveAttForm5.UseVisualStyleBackColor = true;
            this.SaveAttForm5.Click += new System.EventHandler(this.button1_Click);
            // 
            // AttendanceShow
            // 
            this.AttendanceShow.AutoSize = true;
            this.AttendanceShow.Location = new System.Drawing.Point(194, 66);
            this.AttendanceShow.Name = "AttendanceShow";
            this.AttendanceShow.Size = new System.Drawing.Size(0, 17);
            this.AttendanceShow.TabIndex = 5;
            this.AttendanceShow.Click += new System.EventHandler(this.label3_Click);
            // 
            // DataCitita
            // 
            this.DataCitita.Location = new System.Drawing.Point(622, 66);
            this.DataCitita.Margin = new System.Windows.Forms.Padding(4);
            this.DataCitita.Name = "DataCitita";
            this.DataCitita.Size = new System.Drawing.Size(253, 22);
            this.DataCitita.TabIndex = 7;
            this.DataCitita.ValueChanged += new System.EventHandler(this.DataCitita_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(572, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Time:";
            // 
            // OraCitita
            // 
            this.OraCitita.CustomFormat = "HH:mm";
            this.OraCitita.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.OraCitita.Location = new System.Drawing.Point(622, 115);
            this.OraCitita.Margin = new System.Windows.Forms.Padding(4);
            this.OraCitita.Name = "OraCitita";
            this.OraCitita.Size = new System.Drawing.Size(80, 22);
            this.OraCitita.TabIndex = 9;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.OraCitita);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.DataCitita);
            this.Controls.Add(this.AttendanceShow);
            this.Controls.Add(this.SaveAttForm5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form5";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Update Attendance";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form5_FormClosing);
            this.Load += new System.EventHandler(this.Form5_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button SaveAttForm5;
        private System.Windows.Forms.Label AttendanceShow;
        private System.Windows.Forms.DateTimePicker DataCitita;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.DateTimePicker OraCitita;
    }
}