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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();

            var filteredlist = GlobalVar.AppointmentsList.Where(ab => ab.TerrainId == GlobalVar.TerrainId).ToList();

            foreach (var appointment in filteredlist)
            {
                var item = new ListViewItem(new[] { appointment.UserName, appointment.Date.ToString(), appointment.TimeHour.ToString(),
                    appointment.TimeMins.ToString(), appointment.TerrainName });
                listView1.Items.Add(item);
            }
        }

        private void Form5_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void DataCitita_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var b = new Appointment()
            {
                Date = DataCitita1.Value,
                TimeHour = Convert.ToInt32(HourFromUser1.Value),
                TimeMins = Convert.ToInt32(MinsFromUser1.Value),
                UserName = Form1.SetValueForName,
                TerrainId = GlobalVar.TerrainId
            };
            var attendence = GlobalVar.AppointmentsList.FirstOrDefault(ac => ac.TerrainId == GlobalVar.TerrainId && ac.UserName == Form1.SetValueForName);

            var indexOf = GlobalVar.AppointmentsList.IndexOf(attendence);
            DataCitita1.Value = GlobalVar.AppointmentsList[indexOf].Date ;
            HourFromUser1.Value = GlobalVar.AppointmentsList[indexOf].TimeHour;
            MinsFromUser1.Value = GlobalVar.AppointmentsList[indexOf].TimeMins;

            if (attendence != null)
            {
                GlobalVar.AppointmentsList.Remove(attendence);//
            }

            GlobalVar.AppointmentsList.Add(b);

            var filteredlist = GlobalVar.AppointmentsList.Where(ab => ab.TerrainId == GlobalVar.TerrainId).ToList();

            foreach (var appointment in filteredlist)
            {
                var item = new ListViewItem(new[] { appointment.UserName, appointment.Date.ToString(), appointment.TimeHour.ToString(),
                    appointment.TimeMins.ToString(), appointment.TerrainName });
                listView1.Items.Add(item);
            }

            MessageBox.Show("Attendance was updated");

        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
