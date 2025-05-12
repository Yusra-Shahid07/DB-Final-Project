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
    public partial class LeadDashboard : Form
    {
        public LeadDashboard()
        {
            InitializeComponent();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            this.Hide();
            AssignTasks tasks = new AssignTasks();
            tasks.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Events events = new Events();
            events.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Donars d=new Donars();
            d.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Campaigns c = new Campaigns();
            c.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManageBeneficiaries b = new ManageBeneficiaries();
            b.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.Hide();
            AidDistribution aidDistribution=new AidDistribution();
            aidDistribution.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            leadgivefeedback viewFeedBack = new leadgivefeedback();
            viewFeedBack.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            signin signin = new signin();
            signin.Show();
        }
    }
}
