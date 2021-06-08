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
    public partial class Form3 : Form
    {
        public static DateTime SetValueForDate;
        public static DateTime SetValueForTime;
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            input.Text = "Nume: " + Form1.SetValueForName;
        }

        private void input_Click(object sender, EventArgs e)
        {

        }

        private void SaveAttForm3_Click(object sender, EventArgs e)
        {
            var a = new Appointment()
            {
                Date = SetValueForDate,
                Time = SetValueForTime,
                UserName = Form1.SetValueForName,
               // Terrain = "anything",
                TerrainId = 1
            };

            GlobalVar.AppointmentsList.Add(a);
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            this.Hide();
        }
    }
}