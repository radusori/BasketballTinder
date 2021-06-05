namespace BasketballTinder
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.StartApp_Btn = new System.Windows.Forms.Button();
            this.creditsBtn = new System.Windows.Forms.Button();
            this.pictureFormStart = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.nameForm1lbl = new System.Windows.Forms.Label();
            this.inputNameTxtBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureFormStart)).BeginInit();
            this.SuspendLayout();
            // 
            // StartApp_Btn
            // 
            this.StartApp_Btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.StartApp_Btn.Location = new System.Drawing.Point(251, 523);
            this.StartApp_Btn.Name = "StartApp_Btn";
            this.StartApp_Btn.Size = new System.Drawing.Size(280, 23);
            this.StartApp_Btn.TabIndex = 0;
            this.StartApp_Btn.Text = "START APPLICATION";
            this.StartApp_Btn.UseVisualStyleBackColor = false;
            this.StartApp_Btn.Click += new System.EventHandler(this.StartApp_Btn_Click);
            // 
            // creditsBtn
            // 
            this.creditsBtn.Location = new System.Drawing.Point(12, 523);
            this.creditsBtn.Name = "creditsBtn";
            this.creditsBtn.Size = new System.Drawing.Size(75, 23);
            this.creditsBtn.TabIndex = 1;
            this.creditsBtn.Text = "Credits";
            this.creditsBtn.UseVisualStyleBackColor = true;
            this.creditsBtn.Click += new System.EventHandler(this.creditsBtn_Click);
            // 
            // pictureFormStart
            // 
            this.pictureFormStart.Image = ((System.Drawing.Image)(resources.GetObject("pictureFormStart.Image")));
            this.pictureFormStart.Location = new System.Drawing.Point(18, 12);
            this.pictureFormStart.Name = "pictureFormStart";
            this.pictureFormStart.Size = new System.Drawing.Size(513, 385);
            this.pictureFormStart.TabIndex = 2;
            this.pictureFormStart.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Matura MT Script Capitals", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(331, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 126);
            this.label1.TabIndex = 3;
            this.label1.Text = "Basketball\r\nTerrain\r\nTinder\r\n";
            // 
            // nameForm1lbl
            // 
            this.nameForm1lbl.AutoSize = true;
            this.nameForm1lbl.Font = new System.Drawing.Font("Goudy Old Style", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameForm1lbl.Location = new System.Drawing.Point(50, 426);
            this.nameForm1lbl.Name = "nameForm1lbl";
            this.nameForm1lbl.Size = new System.Drawing.Size(124, 21);
            this.nameForm1lbl.TabIndex = 4;
            this.nameForm1lbl.Text = "Enter your name:";
            // 
            // inputNameTxtBox
            // 
            this.inputNameTxtBox.Location = new System.Drawing.Point(181, 426);
            this.inputNameTxtBox.Name = "inputNameTxtBox";
            this.inputNameTxtBox.Size = new System.Drawing.Size(236, 20);
            this.inputNameTxtBox.TabIndex = 5;
            this.inputNameTxtBox.TextChanged += new System.EventHandler(this.inputNameTxtBox_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 558);
            this.Controls.Add(this.inputNameTxtBox);
            this.Controls.Add(this.nameForm1lbl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureFormStart);
            this.Controls.Add(this.creditsBtn);
            this.Controls.Add(this.StartApp_Btn);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Basketball Terrain Tinder";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureFormStart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button StartApp_Btn;
        private System.Windows.Forms.Button creditsBtn;
        private System.Windows.Forms.PictureBox pictureFormStart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label nameForm1lbl;
        private System.Windows.Forms.TextBox inputNameTxtBox;
    }
}

