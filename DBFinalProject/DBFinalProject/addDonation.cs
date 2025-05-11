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
using DBFinalProject.bl;
namespace DBFinalProject
{
    public partial class addDonation : Form
    {
        public addDonation()
        {
            InitializeComponent();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            string donorName = DonarID.Text.Trim(); // Donor name from combo box
            string amountStr = Donationamount.Text.Trim(); // Amount textbox
            DateTime donationDate = dateTimePicker1.Value;

            // --- Validations ---
            if (string.IsNullOrEmpty(donorName) || string.IsNullOrEmpty(amountStr) || CampaignCycle.SelectedItem == null)
            {
                MessageBox.Show("Please fill all fields.");
                return;
            }

            if (!decimal.TryParse(amountStr, out decimal amount) || amount <= 0)
            {
                MessageBox.Show("Enter a valid donation amount.");
                return;
            }

            int campaigncycleId = Convert.ToInt32(CampaignCycle.SelectedItem.ToString()); // direct combo value

            int donorId = DonorDL.GetDonorIdByName(donorName); // Get donor ID
            if (donorId == -1)
            {
                MessageBox.Show("Donor not found.");
                return;
            }

            // --- Create and send to BL ---
            DonationBL donation = new DonationBL(donorId, amount, donationDate, campaigncycleId);
            DonationDL.AddDonation(donation);
            MessageBox.Show("Donation recorded successfully!");

        }
        private void LoadDonorNames()
        {
            DataTable donors = DonorDL.GetAllDonorNames();
            DonarID.Items.Clear();
            foreach (DataRow row in donors.Rows)
            {
                DonarID.Items.Add(row["DonorName"].ToString());
            }
        }

        private void LoadCampaignCycleIds()
        {
            DataTable campaigns = CampaignCycleDL.GetAllCampaignCycleIDs();
            CampaignCycle.Items.Clear();
            foreach (DataRow row in campaigns.Rows)
            {
                CampaignCycle.Items.Add(row["CampaignCycleID"].ToString());
            }
        }
        private void addDonation_Load(object sender, EventArgs e)
        {
            LoadDonorNames();
            LoadCampaignCycleIds();
        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void CampaignCycle_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
