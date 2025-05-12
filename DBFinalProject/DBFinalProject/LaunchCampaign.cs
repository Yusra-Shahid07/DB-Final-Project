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
using Google.Protobuf.Reflection;

namespace DBFinalProject
{
    public partial class LaunchCampaign : Form
    {
        public LaunchCampaign()
        {
            InitializeComponent();
        }

        private void Addcampaign_Load(object sender, EventArgs e)
        {
            LoadCampaignNames();
            LoadEditionYear();
        }
        private void LoadCampaignNames()
        {
            DataTable edition = CampaignDL.ShowAllCampaigns();
            CampaignName.Items.Clear();
            foreach (DataRow row in edition.Rows)
            {
                CampaignName.Items.Add(row["CampaignName"].ToString());
            }
        }
        private void LoadEditionYear()
        {
            DataTable categories = EditionsDL.GetAllEditionYears();
            CampaignYear.Items.Clear();
            foreach (DataRow row in categories.Rows)
            {
                CampaignYear.Items.Add(row["Year"].ToString());
            }
        }
        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            HeadDashboard h = new HeadDashboard();
            h.Show();
        }

        private void Launch_Click(object sender, EventArgs e)
        {
            string campaignName = CampaignName.Text.Trim();
            string month = CampaignMonth.Text.Trim(); 
            string year = CampaignYear.Text.Trim();  
            DateTime startDate = dateTimePicker1.Value;
            DateTime endDate = dateTimePicker2.Value;
            string startdateFormatted = startDate.ToString("yyyy-MM-dd");
            string enddateFormatted = endDate.ToString("yyyy-MM-dd");
            string isActive = "Active"; 
            if (string.IsNullOrEmpty(campaignName) || string.IsNullOrEmpty(month) || string.IsNullOrEmpty(year))
            {
                MessageBox.Show("Please fill all required fields.");
                return;
            }
           
            int editionId = EditionsDL.GetEditionIdByYear(year);
            if (editionId == -1)
            {
                MessageBox.Show("Edition not found.");
                return;
            }

            int campaignId = CampaignDL.GetCampaignIdByName(campaignName);
            if (campaignId == -1)
            {
                MessageBox.Show("Campaign not found.");
                return;
            }
            CampaignCycleBL cycle = new CampaignCycleBL(month, startdateFormatted, enddateFormatted, editionId, campaignId, isActive);
            CampaignCycleDL.AddCampaignCycle(cycle);

            MessageBox.Show("Campaign cycle added successfully!");
        }
    }
}
