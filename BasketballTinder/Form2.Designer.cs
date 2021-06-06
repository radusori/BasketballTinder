
namespace BasketballTinder
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.nameFromInput = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.terrainsPictureBox = new System.Windows.Forms.PictureBox();
            this.prevBtn = new System.Windows.Forms.Button();
            this.nextBtn = new System.Windows.Forms.Button();
            this.chooseTerrainBtn = new System.Windows.Forms.Button();
            this.terrainsImageList = new System.Windows.Forms.ImageList(this.components);
            this.detailsTerrain = new System.Windows.Forms.Label();
            this.ViewAttendenceBtn = new System.Windows.Forms.Button();
            this.DeleteAttendanceBtn = new System.Windows.Forms.Button();
            this.UpdateAttendenceBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.terrainsPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // nameFromInput
            // 
            this.nameFromInput.AutoSize = true;
            this.nameFromInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameFromInput.ForeColor = System.Drawing.Color.Maroon;
            this.nameFromInput.Location = new System.Drawing.Point(57, 45);
            this.nameFromInput.Name = "nameFromInput";
            this.nameFromInput.Size = new System.Drawing.Size(98, 24);
            this.nameFromInput.TabIndex = 0;
            this.nameFromInput.Text = "userName";
            this.nameFromInput.Click += new System.EventHandler(this.nameFromInput_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1133, 644);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(57, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Welcome, ";
            // 
            // terrainsPictureBox
            // 
            this.terrainsPictureBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("terrainsPictureBox.BackgroundImage")));
            this.terrainsPictureBox.InitialImage = ((System.Drawing.Image)(resources.GetObject("terrainsPictureBox.InitialImage")));
            this.terrainsPictureBox.Location = new System.Drawing.Point(338, 9);
            this.terrainsPictureBox.Name = "terrainsPictureBox";
            this.terrainsPictureBox.Size = new System.Drawing.Size(869, 442);
            this.terrainsPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.terrainsPictureBox.TabIndex = 4;
            this.terrainsPictureBox.TabStop = false;
            // 
            // prevBtn
            // 
            this.prevBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prevBtn.ForeColor = System.Drawing.Color.ForestGreen;
            this.prevBtn.Image = ((System.Drawing.Image)(resources.GetObject("prevBtn.Image")));
            this.prevBtn.Location = new System.Drawing.Point(540, 609);
            this.prevBtn.Name = "prevBtn";
            this.prevBtn.Size = new System.Drawing.Size(196, 40);
            this.prevBtn.TabIndex = 6;
            this.prevBtn.Text = "\r\n";
            this.prevBtn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.prevBtn.UseVisualStyleBackColor = true;
            this.prevBtn.Click += new System.EventHandler(this.prevBtn_Click);
            // 
            // nextBtn
            // 
            this.nextBtn.Image = ((System.Drawing.Image)(resources.GetObject("nextBtn.Image")));
            this.nextBtn.Location = new System.Drawing.Point(822, 609);
            this.nextBtn.Name = "nextBtn";
            this.nextBtn.Size = new System.Drawing.Size(196, 40);
            this.nextBtn.TabIndex = 7;
            this.nextBtn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.nextBtn.UseVisualStyleBackColor = true;
            this.nextBtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // chooseTerrainBtn
            // 
            this.chooseTerrainBtn.BackColor = System.Drawing.Color.LimeGreen;
            this.chooseTerrainBtn.Location = new System.Drawing.Point(12, 589);
            this.chooseTerrainBtn.Name = "chooseTerrainBtn";
            this.chooseTerrainBtn.Size = new System.Drawing.Size(183, 65);
            this.chooseTerrainBtn.TabIndex = 8;
            this.chooseTerrainBtn.Text = "CHOOSE TERRAIN";
            this.chooseTerrainBtn.UseVisualStyleBackColor = false;
            this.chooseTerrainBtn.Click += new System.EventHandler(this.chooseTerrainBtn_Click);
            // 
            // terrainsImageList
            // 
            this.terrainsImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("terrainsImageList.ImageStream")));
            this.terrainsImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.terrainsImageList.Images.SetKeyName(0, "BasketTerrainGheorgheni.jpg");
            this.terrainsImageList.Images.SetKeyName(1, "bt arena-outdoor.jpg");
            this.terrainsImageList.Images.SetKeyName(2, "Intre-Lacuri.jpg");
            this.terrainsImageList.Images.SetKeyName(3, "parcul rozelor.jpg");
            // 
            // detailsTerrain
            // 
            this.detailsTerrain.AutoSize = true;
            this.detailsTerrain.Location = new System.Drawing.Point(392, 467);
            this.detailsTerrain.Name = "detailsTerrain";
            this.detailsTerrain.Size = new System.Drawing.Size(0, 13);
            this.detailsTerrain.TabIndex = 12;
            // 
            // ViewAttendenceBtn
            // 
            this.ViewAttendenceBtn.Location = new System.Drawing.Point(16, 192);
            this.ViewAttendenceBtn.Name = "ViewAttendenceBtn";
            this.ViewAttendenceBtn.Size = new System.Drawing.Size(183, 55);
            this.ViewAttendenceBtn.TabIndex = 13;
            this.ViewAttendenceBtn.Text = "VIEW ATTENDENCE";
            this.ViewAttendenceBtn.UseVisualStyleBackColor = true;
            this.ViewAttendenceBtn.Click += new System.EventHandler(this.ViewAttendenceBtn_Click);
            // 
            // DeleteAttendanceBtn
            // 
            this.DeleteAttendanceBtn.Location = new System.Drawing.Point(16, 335);
            this.DeleteAttendanceBtn.Name = "DeleteAttendanceBtn";
            this.DeleteAttendanceBtn.Size = new System.Drawing.Size(183, 55);
            this.DeleteAttendanceBtn.TabIndex = 15;
            this.DeleteAttendanceBtn.Text = "DELETE ATTENDENCE";
            this.DeleteAttendanceBtn.UseVisualStyleBackColor = true;
            // 
            // UpdateAttendenceBtn
            // 
            this.UpdateAttendenceBtn.Location = new System.Drawing.Point(16, 262);
            this.UpdateAttendenceBtn.Name = "UpdateAttendenceBtn";
            this.UpdateAttendenceBtn.Size = new System.Drawing.Size(183, 55);
            this.UpdateAttendenceBtn.TabIndex = 16;
            this.UpdateAttendenceBtn.Text = "UPDATE ATTENDENCE";
            this.UpdateAttendenceBtn.UseVisualStyleBackColor = true;
            this.UpdateAttendenceBtn.Click += new System.EventHandler(this.UpdateAttendenceBtn_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1220, 679);
            this.Controls.Add(this.UpdateAttendenceBtn);
            this.Controls.Add(this.DeleteAttendanceBtn);
            this.Controls.Add(this.ViewAttendenceBtn);
            this.Controls.Add(this.detailsTerrain);
            this.Controls.Add(this.chooseTerrainBtn);
            this.Controls.Add(this.nextBtn);
            this.Controls.Add(this.prevBtn);
            this.Controls.Add(this.terrainsPictureBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.nameFromInput);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Basketball Terrain Tinder";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.terrainsPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nameFromInput;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox terrainsPictureBox;
        private System.Windows.Forms.Button prevBtn;
        private System.Windows.Forms.Button nextBtn;
        private System.Windows.Forms.Button chooseTerrainBtn;
        private System.Windows.Forms.ImageList terrainsImageList;
        private System.Windows.Forms.Label detailsTerrain;
        private System.Windows.Forms.Button ViewAttendenceBtn;
        private System.Windows.Forms.Button DeleteAttendanceBtn;
        private System.Windows.Forms.Button UpdateAttendenceBtn;
    }
}