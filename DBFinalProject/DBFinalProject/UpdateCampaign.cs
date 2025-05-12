using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using DBFinalProject.bl;
using DBFinalProject.DL;
using Mysqlx.Crud;

namespace DBFinalProject
{
    public partial class UpdateCampaign : Form
    {
        int id;
        public UpdateCampaign(int id,string name,string desc)
        {
            InitializeComponent();
            this.id = id;
            Campaignname.Text = name;
            description.Text = desc;

        }
        public UpdateCampaign()
        {
            InitializeComponent();
        }
        private void button8_Click(object sender, EventArgs e)
        {
            string campaignName = Campaignname.Text;
            string Description = description.Text;
            bool check = CampaignBL.IsAllAlphabetsOrSpace(campaignName);
            CampaignBL newCampaign = new CampaignBL(campaignName, Description);
            if (check && id!=-1)
            {
                CampaignDL.UpdateCampaign(id, newCampaign);
                MessageBox.Show("Campaign added successfully!");
            }
            else
            {
                MessageBox.Show("Campaign name must contain only alphabets and spaces or id should not be null");
            }

        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            Campaigns campaigns = new Campaigns();
            campaigns.Show();
        }
    }
}
