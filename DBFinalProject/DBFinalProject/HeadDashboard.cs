using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBFinalProject
{
    public partial class HeadDashboard : Form
    {
        public HeadDashboard()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            ApproveVolunteer v=new ApproveVolunteer();
            v.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            LaunchCampaign launchCampaign = new LaunchCampaign();

            launchCampaign.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            VerifyDonations d=new VerifyDonations();
            d.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            ExpenseForm expenseForm = new ExpenseForm();
            expenseForm.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManageEventCategories manageEventCategories = new ManageEventCategories();
            manageEventCategories.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Hide();
            ViewFeedBack viewFeedBack = new ViewFeedBack();
            viewFeedBack.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            signin s=new signin();
            s.Show();
        }
    }
}
