using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasketballTinder
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            nameFromInput.Text = Form1.SetValueForName;
            GlobalVar.TerrainId = 0;
            GlobalVar.TerrainName = "BAZA GHEORGHENI";
        }

        int countImages = 0;
        private void button2_Click(object sender, EventArgs e)
        {
            countImages++;

            if (countImages <= 3)
            {
                if (countImages == 0)
                {
                    detailsTerrain.Text = "BAZA GHEORGHENI";
                    AddressLbl.Text = "Address: Str. Alexandru Vaida Voevod";
                }
                else if (countImages == 1)
                {
                    detailsTerrain.Text = "BT ARENA";
                    AddressLbl.Text = "Address: Str. Uzinei Electrice";

                }
                else if (countImages == 2)
                {
                    detailsTerrain.Text = "TEREN INTRE LACURI";
                    AddressLbl.Text = "Address: Str. Tulcea";

                }
                else if (countImages == 3)
                {
                    detailsTerrain.Text = "PARCUL ROZELOR";
                    AddressLbl.Text = "Address: Str. Plopilor";


                }

                terrainsPictureBox.Image = terrainsImageList.Images[countImages];
                GlobalVar.TerrainId = countImages;
                GlobalVar.TerrainName = detailsTerrain.Text;

            }
            else {
                countImages--;
                MessageBox.Show("This is the end!");
            }


        }

        private void prevBtn_Click(object sender, EventArgs e)
        {
            countImages--;

            if (countImages >= 0)
            {
                if (countImages == 3)
                {
                    detailsTerrain.Text = "PARCUL ROZELOR";
                    AddressLbl.Text = "Address: Str. Plopilor";

                }
                else if (countImages == 2)
                {
                    detailsTerrain.Text = "TEREN INTRE LACURI";
                    AddressLbl.Text = "Address: Str. Tulcea";

                }
                else if (countImages == 1)
                {
                    detailsTerrain.Text = "BT ARENA";
                    AddressLbl.Text = "Address: Str. Uzinei Electrice";

                }
                else if (countImages == 0)
                {
                    detailsTerrain.Text = "BAZA GHEORGHENI";
                    AddressLbl.Text = "Address: Str. Alexandru Vaida Voevod";


                }

                terrainsPictureBox.Image = terrainsImageList.Images[countImages];
                GlobalVar.TerrainId = countImages;
                GlobalVar.TerrainName = detailsTerrain.Text;

            }
            else {
                countImages++;
                MessageBox.Show("There are no previous terrains");
            }


        }

        private void chooseTerrainBtn_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Show();
            this.Hide();
        }

        private void nameFromInput_Click(object sender, EventArgs e)
        {

        }

        private void ViewAttendenceBtn_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            f4.Show();
            this.Hide();
        }

        private void UpdateAttendenceBtn_Click(object sender, EventArgs e)
        {
            Form5 f5 = new Form5();
            f5.Show();
            this.Hide();
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide(); ;
        }

        private void DeleteAttendanceBtn_Click(object sender, EventArgs e)
        {
            Form6 f6 = new Form6();
            f6.Show();
            this.Hide(); ;
        }

        private void detailsTerrain_Click(object sender, EventArgs e)
        {

        }
    }
}
