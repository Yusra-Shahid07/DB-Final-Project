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
    public partial class leadgivefeedback : Form
    {
        public leadgivefeedback()
        {
            InitializeComponent();
        }
        private void LoadUserIDs()
        {
            DataTable users = UserDL.GetAllUserIDs();
            SubmittedID.Items.Clear();
            foreach (DataRow row in users.Rows)
            {
                SubmittedID.Items.Add(row["UserID"].ToString());
            }
        }

        private void LoadCampaigns()
        {
            DataTable campaigns = CampaignDL.ShowAllCampaigns();
            CampaignCycle.Items.Clear();
            foreach (DataRow row in campaigns.Rows)
            {
                CampaignCycle.Items.Add(row["CampaignName"].ToString());
            }
        }
        private void button8_Click(object sender, EventArgs e)
        {
            string submittedbyrole = "Member";
            string submittedBy = SubmittedID.Text.Trim();
            string campaignName = CampaignCycle.Text.Trim();
            int rating = (int)Rating.Value;
            string feedback = FeedBack.Text.Trim();
            DateTime submissionDate = dateTimePicker1.Value;
            string dobFormatted = submissionDate.ToString("yyyy-MM-dd");
            if (!int.TryParse(submittedBy, out int SubmittedBy))
            {
                MessageBox.Show("Submitted By ID must be a valid number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrEmpty(submittedBy) || string.IsNullOrEmpty(campaignName) || string.IsNullOrEmpty(feedback))
            {
                MessageBox.Show("Please fill all required fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (rating < 1 || rating > 5)
            {
                MessageBox.Show("Rating must be between 1 and 5.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int campaignId = CampaignDL.GetCampaignIdByName(campaignName);
            FeedbackBL fb = new FeedbackBL(submittedbyrole, SubmittedBy, campaignId, rating, feedback, dobFormatted);
            FeedbackDL.AddFeedback(fb);

            MessageBox.Show("Feedback submitted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void leadgivefeedback_Load(object sender, EventArgs e)
        {
            LoadUserIDs();
            LoadCampaigns();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            leadgivefeedback f = new leadgivefeedback();
            f.Show();
        }
    }
}
