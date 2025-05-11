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
    public partial class AidDistribution : Form
    {
        public AidDistribution()
        {
            InitializeComponent();
        }
        private void LoadCampaignCycleIDs()
        {
            DataTable table = CampaignCycleDL.GetAllCampaignCycleIDs();
            CampaignCycleID.Items.Clear();

            foreach (DataRow row in table.Rows)
            {
                CampaignCycleID.Items.Add(row["CampaignCycleID"].ToString());
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void AidDistribution_Load(object sender, EventArgs e)
        {
            LoadCampaignCycleIDs();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            string aidType = AidType.Text.Trim(); // Combo: "Medical", "Food", etc.
            string amountStr = Amount.Text.Trim(); // TextBox
            DateTime distributionDate = date.Value;

            // Validation: Ensure combo is selected
            if (string.IsNullOrEmpty(aidType) || string.IsNullOrEmpty(amountStr) || CampaignCycleID.SelectedItem == null)
            {
                MessageBox.Show("Please fill all fields.");
                return;
            }

            if (!int.TryParse(amountStr, out int amount) || amount <= 0)
            {
                MessageBox.Show("Enter a valid number for amount.");
                return;
            }

            // CampaignCycleID is numeric value stored directly in combo
            int campaignCycleId = Convert.ToInt32(CampaignCycleID.SelectedItem.ToString());

            // --- Create and Send to BL ---
            AidDistributionBL aid = new AidDistributionBL(campaignCycleId, aidType, amount, distributionDate);
            AidDistributionDL.AddAidDistribution(aid);
            MessageBox.Show("Aid distribution recorded successfully!");
        }
    }
}
