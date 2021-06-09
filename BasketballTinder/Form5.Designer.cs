
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
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.HourFromUser = new System.Windows.Forms.NumericUpDown();
            this.MinsFromUser = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.HourFromUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinsFromUser)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 54);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Existing Attendance:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(367, 54);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Update Attendace:";
            // 
            // SaveAttForm5
            // 
            this.SaveAttForm5.Location = new System.Drawing.Point(40, 382);
            this.SaveAttForm5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SaveAttForm5.Name = "SaveAttForm5";
            this.SaveAttForm5.Size = new System.Drawing.Size(105, 40);
            this.SaveAttForm5.TabIndex = 4;
            this.SaveAttForm5.Text = "Save Attendance";
            this.SaveAttForm5.UseVisualStyleBackColor = true;
            this.SaveAttForm5.Click += new System.EventHandler(this.button1_Click);
            // 
            // AttendanceShow
            // 
            this.AttendanceShow.AutoSize = true;
            this.AttendanceShow.Location = new System.Drawing.Point(146, 54);
            this.AttendanceShow.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.AttendanceShow.Name = "AttendanceShow";
            this.AttendanceShow.Size = new System.Drawing.Size(0, 13);
            this.AttendanceShow.TabIndex = 5;
            this.AttendanceShow.Click += new System.EventHandler(this.label3_Click);
            // 
            // DataCitita
            // 
            this.DataCitita.Location = new System.Drawing.Point(466, 54);
            this.DataCitita.Name = "DataCitita";
            this.DataCitita.Size = new System.Drawing.Size(191, 20);
            this.DataCitita.TabIndex = 7;
            this.DataCitita.ValueChanged += new System.EventHandler(this.DataCitita_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(421, 120);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Time:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(530, 104);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Min";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(463, 104);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Hour";
            // 
            // HourFromUser
            // 
            this.HourFromUser.Location = new System.Drawing.Point(466, 120);
            this.HourFromUser.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.HourFromUser.Name = "HourFromUser";
            this.HourFromUser.Size = new System.Drawing.Size(45, 20);
            this.HourFromUser.TabIndex = 12;
            // 
            // MinsFromUser
            // 
            this.MinsFromUser.Location = new System.Drawing.Point(533, 120);
            this.MinsFromUser.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.MinsFromUser.Name = "MinsFromUser";
            this.MinsFromUser.Size = new System.Drawing.Size(45, 20);
            this.MinsFromUser.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Showcard Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(516, 120);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(12, 17);
            this.label6.TabIndex = 14;
            this.label6.Text = ":";
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.MinsFromUser);
            this.Controls.Add(this.HourFromUser);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.DataCitita);
            this.Controls.Add(this.AttendanceShow);
            this.Controls.Add(this.SaveAttForm5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form5";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Update Attendance";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form5_FormClosing);
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.HourFromUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinsFromUser)).EndInit();
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
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown HourFromUser;
        private System.Windows.Forms.NumericUpDown MinsFromUser;
        private System.Windows.Forms.Label label6;
    }
}