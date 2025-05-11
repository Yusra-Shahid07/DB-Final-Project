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
    public partial class AddCampaignBeneficiaries : Form
    {
        public AddCampaignBeneficiaries()
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
        private void AddCampaignBeneficiaries_Load(object sender, EventArgs e)
        {
            LoadCampaignCycleIDs();
            LoadBeneficiaryIDs();
        }

        private void LoadBeneficiaryIDs()
        {
            DataTable table = BeneficiaryDL.GetAllBeneficiaryIDs(); // This method should fetch IDs from DB
            beneficiaryid.Items.Clear();

            foreach (DataRow row in table.Rows)
            {
                beneficiaryid.Items.Add(row["BeneficiaryID"].ToString());
            }
        }
        private void button13_Click(object sender, EventArgs e)
        {
            string beneficiaryIdStr = beneficiaryid.Text.Trim();
            string aidType = BeneficiaryType.Text.Trim(); 
            string amountStr = Amount.Text.Trim();       
            DateTime distributionDate = dateTimePicker1.Value;
            if (string.IsNullOrEmpty(beneficiaryIdStr) || string.IsNullOrEmpty(aidType) || string.IsNullOrEmpty(amountStr) || CampaignCycleID.SelectedItem == null)
            {
                MessageBox.Show("Please fill all fields.");
                return;
            }

            if (!int.TryParse(beneficiaryIdStr, out int beneficiaryId) || beneficiaryId <= 0)
            {
                MessageBox.Show("Enter a valid Beneficiary ID.");
                return;
            }

            if (!int.TryParse(amountStr, out int amount) || amount <= 0)
            {
                MessageBox.Show("Enter a valid number for amount.");
                return;
            }

            int campaignCycleId = Convert.ToInt32(CampaignCycleID.SelectedItem.ToString());
            DonationBeneficiariesBL aid = new DonationBeneficiariesBL(beneficiaryId,distributionDate,amount,aidType,campaignCycleId);
            DonationBeneficiariesDL.AddDonationBeneficiary(aid);
            MessageBox.Show("Aid distribution recorded successfully!");
        }
    }
}
