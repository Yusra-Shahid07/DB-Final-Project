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
    public partial class campaignNames : Form
    {
        public campaignNames()
        {
            InitializeComponent();
        }
        private void campaignNames_Load(object sender, EventArgs e)
        {

        }
        private void button8_Click(object sender, EventArgs e)
        {
            string campaignName = Campaignname.Text;
            string Description = description.Text;
            bool check = CampaignBL.IsAllAlphabetsOrSpace(campaignName);
            CampaignBL newCampaign = new CampaignBL(campaignName, Description);
            if (check)
            {
                CampaignDL.AddCampaign(newCampaign);
            }
        }
    }
}
