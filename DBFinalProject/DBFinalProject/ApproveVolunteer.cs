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
    public partial class ApproveVolunteer : Form
    {
        public ApproveVolunteer()
        {
            InitializeComponent();
            LoadGrid();
        }
        
        public void LoadGrid()
        {
            dataGridView1.DataSource = VolunteerDL.ShowAllVolunteers();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int selectedVolunteerId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["VolunteerID"].Value);
                VolunteerDL.UpdateVolunteerStatus(selectedVolunteerId, "Accepted");

                LoadGrid();
            }
            else
            {
                MessageBox.Show("Please select a row first.");
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int selectedVolunteerId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["VolunteerID"].Value);
                VolunteerDL.UpdateVolunteerStatus(selectedVolunteerId, "Rejected");
                LoadGrid();
            }
            else
            {
                MessageBox.Show("Please select a row first.");
            }
        }

        private void ApproveVolunteer_Load(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.Hide();
            HeadDashboard h=new HeadDashboard();
            h.Show();
        }
    }
}
