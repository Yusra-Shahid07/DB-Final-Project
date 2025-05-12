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
            this.Hide();
            UpdateCampaign updateCampaign = new UpdateCampaign();
            updateCampaign.Show();
        }
    }
}
