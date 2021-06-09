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
    public partial class Form1 : Form
    {
        public static string SetValueForName = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void creditsBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Designed by: \nRadu Lamoran \nGabriel Palasanu \nDragos Cont \n\n\nGuidance: Bogdan Iuga");
        }

        private void StartApp_Btn_Click(object sender, EventArgs e)
        {
            if (inputNameTxtBox.Text == "")
            {
                MessageBox.Show("Please enter your email...");
            }
            else 
            {
                SetValueForName = inputNameTxtBox.Text;

                Form2 f2 = new Form2();
                f2.Show();
                this.Hide();

            }
        }

        private void inputNameTxtBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void pictureFormStart_Click(object sender, EventArgs e)
        {

        }
    }
}
