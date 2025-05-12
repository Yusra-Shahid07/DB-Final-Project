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
    public partial class ManageBeneficiaries : Form
    {
        public ManageBeneficiaries()
        {
            InitializeComponent();
        }

        private void button18_Click(object sender, EventArgs e)
        {

        }

        private void button19_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            LeadDashboard lead=new LeadDashboard();
            lead.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddCampaignBeneficiaries co=new AddCampaignBeneficiaries();
            co.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Benefiaries benefiaries = new Benefiaries();
            benefiaries.Show();
        }
    }
}
