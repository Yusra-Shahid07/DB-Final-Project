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
    public partial class ViewEvents : Form
    {
        public ViewEvents()
        {
            InitializeComponent();
            LoadGrid();
        }
        public void LoadGrid()
        {
            dataGridView1.DataSource = EventDL.ShowAllEvents();
        }
        private void button7_Click(object sender, EventArgs e)
        {
            Member_Dashboard member_Dashboard = new Member_Dashboard();
            member_Dashboard.Show();
            this.Hide();
        }

        private void ViewEvents_Load(object sender, EventArgs e)
        {

        }
    }
}
