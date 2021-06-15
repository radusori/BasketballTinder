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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.HourFromUser = new System.Windows.Forms.NumericUpDown();
            this.MinsFromUser = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.HourFromUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinsFromUser)).BeginInit();
            this.SuspendLayout();
            // 
            // input
            // 
            this.input.AutoSize = true;
            this.input.Location = new System.Drawing.Point(3, 9);
            this.input.Name = "input";
            this.input.Size = new System.Drawing.Size(38, 13);
            this.input.TabIndex = 0;
            this.input.Text = "Name:";
            this.input.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.input.Click += new System.EventHandler(this.input_Click);
            // 
            // DataCitita
            // 
            this.DataCitita.CustomFormat = "MM/dd/yyyy";
            this.DataCitita.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DataCitita.Location = new System.Drawing.Point(44, 34);
            this.DataCitita.Name = "DataCitita";
            this.DataCitita.Size = new System.Drawing.Size(191, 20);
            this.DataCitita.TabIndex = 1;
            this.DataCitita.Value = new System.DateTime(2021, 6, 14, 22, 29, 7, 0);
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
            this.Ora.Location = new System.Drawing.Point(3, 98);
            this.Ora.Name = "Ora";
            this.Ora.Size = new System.Drawing.Size(33, 13);
            this.Ora.TabIndex = 4;
            this.Ora.Text = "Time:";
            // 
            // SaveAttForm3
            // 
            this.SaveAttForm3.BackColor = System.Drawing.Color.Lime;
            this.SaveAttForm3.Location = new System.Drawing.Point(12, 214);
            this.SaveAttForm3.Name = "SaveAttForm3";
            this.SaveAttForm3.Size = new System.Drawing.Size(107, 35);
            this.SaveAttForm3.TabIndex = 5;
            this.SaveAttForm3.Text = "Save Attendance";
            this.SaveAttForm3.UseVisualStyleBackColor = false;
            this.SaveAttForm3.Click += new System.EventHandler(this.SaveAttForm3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Hour";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(106, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Min.";
            // 
            // HourFromUser
            // 
            this.HourFromUser.Location = new System.Drawing.Point(42, 96);
            this.HourFromUser.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.HourFromUser.Name = "HourFromUser";
            this.HourFromUser.Size = new System.Drawing.Size(42, 20);
            this.HourFromUser.TabIndex = 10;
            // 
            // MinsFromUser
            // 
            this.MinsFromUser.Location = new System.Drawing.Point(109, 96);
            this.MinsFromUser.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.MinsFromUser.Name = "MinsFromUser";
            this.MinsFromUser.Size = new System.Drawing.Size(42, 20);
            this.MinsFromUser.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Showcard Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(91, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(12, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = ":";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.MinsFromUser);
            this.Controls.Add(this.HourFromUser);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SaveAttForm3);
            this.Controls.Add(this.Ora);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DataCitita);
            this.Controls.Add(this.input);
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Attendence";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form3_FormClosing);
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.HourFromUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinsFromUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label input;
        private System.Windows.Forms.DateTimePicker DataCitita;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Ora;
        private System.Windows.Forms.Button SaveAttForm3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown HourFromUser;
        private System.Windows.Forms.NumericUpDown MinsFromUser;
        private System.Windows.Forms.Label label4;
    }
}