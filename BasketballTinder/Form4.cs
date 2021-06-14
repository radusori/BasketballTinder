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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();

            var filteredlist = GlobalVar.AppointmentsList.Where(ab => ab.TerrainId == GlobalVar.TerrainId).ToList();
           
            foreach (var appointment in filteredlist) {
                var item = new ListViewItem(new[] { appointment.UserName, appointment.Date.ToString(), appointment.TimeHour.ToString(), 
                    appointment.TimeMins.ToString(), appointment.TerrainName });
                listView1.Items.Add(item);
            }
        }

        private void Form4_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            this.Hide();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            
        }
    }
}
