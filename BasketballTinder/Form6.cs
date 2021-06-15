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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();

            var filteredlist = GlobalVar.AppointmentsList.Where(ab => ab.TerrainId == GlobalVar.TerrainId).ToList();

            foreach (var appointment in filteredlist)
            {
                var item = new ListViewItem(new[] { appointment.UserName, appointment.Date.ToString("MM/dd/yyyy"), appointment.TimeHour.ToString(),
                    appointment.TimeMins.ToString(), appointment.TerrainName.ToString() });
                listView1.Items.Add(item);
            }
        }

            private void DeleteBTN_Click(object sender, EventArgs e)
            {
                var attendence = GlobalVar.AppointmentsList.FirstOrDefault(ac => ac.TerrainId == GlobalVar.TerrainId && ac.UserName == Form1.SetValueForName);
                if (attendence != null)
                {
                    GlobalVar.AppointmentsList.Remove(attendence);//
                }
                MessageBox.Show("Attendance was deleted!");

            Form2 f2 = new Form2();
            f2.Show();
            this.Hide();
            }

            private void Form6_FormClosing(object sender, FormClosingEventArgs e)
            {
                Form2 f2 = new Form2();
                f2.Show();
                this.Hide();
            }
        
    } 
}
