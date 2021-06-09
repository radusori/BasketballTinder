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
                Date = DataCitita.Value,
                Time = OraCitita.Value,
                UserName = Form1.SetValueForName,
                // Terrain = "anything",
                TerrainId = GlobalVar.TerrainId
            };

            GlobalVar.AppointmentsList.Add(a);
            var filteredlist = GlobalVar.AppointmentsList.Where(ab => ab.TerrainId == GlobalVar.TerrainId).ToList();//de pus in viewappointment
            var attendence = GlobalVar.AppointmentsList.FirstOrDefault(ac => ac.TerrainId == GlobalVar.TerrainId && ac.UserName == Form1.SetValueForName);
            if (attendence != null)
            {
                GlobalVar.AppointmentsList.Remove(attendence);//
            }
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

        private void OraCitita_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}