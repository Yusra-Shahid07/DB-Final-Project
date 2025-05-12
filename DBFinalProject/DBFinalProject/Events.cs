using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DBFinalProject.DL;

namespace DBFinalProject
{
    public partial class Events : Form
    {
        public Events()
        {
            InitializeComponent();
            LoadGrid(); 
        }
        public void LoadGrid()
        {
            dataGridView1.DataSource = EventDL.ShowAllEvents();
        }
        private void Events_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddEvent addEvent = new AddEvent();
           
            addEvent.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            
        }

        private void button7_Click(object sender, EventArgs e)
        {

            this.Hide();
            LeadDashboard lead=new LeadDashboard();
            lead.Show();
        }
    }
}
