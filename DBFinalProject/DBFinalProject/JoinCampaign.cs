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
    public partial class JoinCampaign : Form
    {
        public JoinCampaign()
        {
            InitializeComponent();
        }

        private void JoinCampaign_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            CampaignRequest campaignRequest = new CampaignRequest();
            campaignRequest.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Member_Dashboard member_Dashboard = new Member_Dashboard();
            member_Dashboard.Show();
            this.Hide();
        }
    }
}
