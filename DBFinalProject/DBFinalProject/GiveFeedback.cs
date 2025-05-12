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
    public partial class GiveFeedback : Form
    {
        public GiveFeedback()
        {
            InitializeComponent();
        }

        private void GiveFeedback_Load(object sender, EventArgs e)
        {
            LoadUserIDs();
            LoadCampaigns();
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
            string submittedbyrole = "Volunteer";
            string submittedBy = SubmittedID.Text.Trim();
            string campaignName = CampaignCycle.Text.Trim();
            int rating = (int)Rating.Value;
            string feedback = FeedBack.Text.Trim();
            DateTime submissionDate = dateTimePicker1.Value;
            string dobFormatted =submissionDate.ToString("yyyy-MM-dd");

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
            FeedbackBL fb = new FeedbackBL(submittedbyrole,SubmittedBy, campaignId, rating, feedback, dobFormatted);
            FeedbackDL.AddFeedback(fb);

            MessageBox.Show("Feedback submitted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
          
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            Member_Dashboard member_Dashboard=new Member_Dashboard();
            member_Dashboard.Show();
            
        }

        private void SubmittedID_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void SubmittedRole_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CampaignCycle_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Rating_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void FeedBack_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
