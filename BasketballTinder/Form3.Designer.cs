namespace BasketballTinder
{
    partial class Form3
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
            this.input = new System.Windows.Forms.Label();
            this.DataCitita = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.Ora = new System.Windows.Forms.Label();
            this.SaveAttForm3 = new System.Windows.Forms.Button();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.BackBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // input
            // 
            this.input.AutoSize = true;
            this.input.Location = new System.Drawing.Point(0, 9);
            this.input.Name = "input";
            this.input.Size = new System.Drawing.Size(38, 13);
            this.input.TabIndex = 0;
            this.input.Text = "Name:";
            this.input.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.input.Click += new System.EventHandler(this.input_Click);
            // 
            // DataCitita
            // 
            this.DataCitita.Location = new System.Drawing.Point(44, 34);
            this.DataCitita.Name = "DataCitita";
            this.DataCitita.Size = new System.Drawing.Size(191, 20);
            this.DataCitita.TabIndex = 1;
            this.DataCitita.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Date:";
            // 
            // Ora
            // 
            this.Ora.AutoSize = true;
            this.Ora.Location = new System.Drawing.Point(3, 77);
            this.Ora.Name = "Ora";
            this.Ora.Size = new System.Drawing.Size(33, 13);
            this.Ora.TabIndex = 4;
            this.Ora.Text = "Time:";
            // 
            // SaveAttForm3
            // 
            this.SaveAttForm3.Location = new System.Drawing.Point(12, 214);
            this.SaveAttForm3.Name = "SaveAttForm3";
            this.SaveAttForm3.Size = new System.Drawing.Size(107, 35);
            this.SaveAttForm3.TabIndex = 5;
            this.SaveAttForm3.Text = "Save Attendance";
            this.SaveAttForm3.UseVisualStyleBackColor = true;
            this.SaveAttForm3.Click += new System.EventHandler(this.SaveAttForm3_Click);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CustomFormat = "HH:mm";
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(44, 71);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(61, 20);
            this.dateTimePicker2.TabIndex = 6;
            // 
            // BackBtn
            // 
            this.BackBtn.Location = new System.Drawing.Point(197, 226);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(75, 23);
            this.BackBtn.TabIndex = 7;
            this.BackBtn.Text = "Back";
            this.BackBtn.UseVisualStyleBackColor = true;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.SaveAttForm3);
            this.Controls.Add(this.Ora);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DataCitita);
            this.Controls.Add(this.input);
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Attendence";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label input;
        private System.Windows.Forms.DateTimePicker DataCitita;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Ora;
        private System.Windows.Forms.Button SaveAttForm3;
        public System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Button BackBtn;
    }
}