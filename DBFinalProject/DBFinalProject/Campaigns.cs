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
    public partial class Campaigns : Form
    {
        public Campaigns()
        {
            InitializeComponent();
            LoadGrid();
        }
        public void LoadGrid()
        {
            dataGridView1.DataSource =CampaignDL.ShowAllCampaigns();
        }
        private void Campaigns_Load(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.Hide();
            campaignNames c=new campaignNames();
            c.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            LeadDashboard lead=new LeadDashboard();
            lead.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a campaign.");
                return;
            }

            DataGridViewRow row = dataGridView1.SelectedRows[0];
            int id = Convert.ToInt32(row.Cells["CampaignID"].Value);
            string name = row.Cells["CampaignName"].Value.ToString();
            string desc = row.Cells["Description"].Value.ToString();
            UpdateCampaign updateForm = new UpdateCampaign(id, name, desc);
            updateForm.ShowDialog();
            LoadGrid();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a campaign to delete.");
                return;
            }

            DialogResult result = MessageBox.Show("Are you sure you want to delete this campaign?", "Confirm", MessageBoxButtons.YesNo);
            if (result == DialogResult.No) return;

            int campaignId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["CampaignId"].Value);
            CampaignDL.DeleteCampaign(campaignId);
            MessageBox.Show("Campaign deleted successfully.");
            LoadGrid(); 

        }
    }
}
