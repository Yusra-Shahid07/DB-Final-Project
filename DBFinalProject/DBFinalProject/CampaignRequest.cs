using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DBFinalProject.bl;
using DBFinalProject.DL;
namespace DBFinalProject
{
    public partial class CampaignRequest : Form
    {
        public CampaignRequest()
        {
            InitializeComponent();
        }
        private void LoadCampaignCycleIDs()
        {
            DataTable table = CampaignCycleDL.GetAllCampaignCycleIDs();
            CampaignCycle.Items.Clear();

            foreach (DataRow row in table.Rows)
            {
                CampaignCycle.Items.Add(row["CampaignCycleID"].ToString());
            }
        }

        private void LoadVolunteerIDs()
        {
            DataTable table = VolunteerDL.GetAllVolunteerIDs();
            VolunteerID.Items.Clear();

            foreach (DataRow row in table.Rows)
            {
                VolunteerID.Items.Add(row["VolunteerID"].ToString());
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void UserID_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (CampaignCycle.SelectedItem == null || VolunteerID.SelectedItem == null)
            {
                MessageBox.Show("Please select both Campaign Cycle ID and Volunteer ID.");
                return;
            }

            // Convert to integers
            int campaignCycleId = Convert.ToInt32(CampaignCycle.SelectedItem.ToString());
            int volunteerId = Convert.ToInt32(VolunteerID.SelectedItem.ToString());

            // Just insert the two IDs into CampaignRequest table
            bool success = CampaignRequestDL.InsertRequest(campaignCycleId, volunteerId);

            if (success)
            {
                MessageBox.Show("Campaign request submitted successfully!");
            }
            else
            {
                MessageBox.Show("Failed to submit campaign request.");
            }
        }

        private void CampaignCycle_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CampaignRequest_Load(object sender, EventArgs e)
        {
            LoadCampaignCycleIDs();
            LoadVolunteerIDs();
        }
    }
}
