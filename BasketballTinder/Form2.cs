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
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.ExitThread();
        }

        int countImages = 0;
        private void button2_Click(object sender, EventArgs e)
        {
            if (countImages < 3)
            {
                if (countImages == 0)
                {
                    detailsTerrain.Text = "Imagine 0";
                }
                else if (countImages == 1)
                {
                    detailsTerrain.Text = "Imagine 1";
                }
                else if (countImages == 2)
                {
                    detailsTerrain.Text = "Imagine 2";
                }
                else if (countImages == 3)
                {
                    detailsTerrain.Text = "Imagine 3";

                }

                countImages++;
            }

            terrainsPictureBox.Image = terrainsImageList.Images[countImages];

        }

        private void prevBtn_Click(object sender, EventArgs e)
        {
            if (countImages > 0)
            {
                if (countImages == 3)
                {
                    detailsTerrain.Text = "Imagine 3";
                }
                else if (countImages == 2)
                {
                    detailsTerrain.Text = "Imagine 2";
                }
                else if (countImages == 1)
                {
                    detailsTerrain.Text = "Imagine 1";
                }
                else if (countImages == 0)
                {
                    detailsTerrain.Text = "Imagine 0";

                }
                countImages--;
            }

            terrainsPictureBox.Image = terrainsImageList.Images[countImages];

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
    }
}
