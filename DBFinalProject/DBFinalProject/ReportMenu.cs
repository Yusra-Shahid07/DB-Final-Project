using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DBFinalProject.Reports.Beneficiaries;
using DBFinalProject.Reports.CampaignCycles;
using DBFinalProject.Reports.Donor;
using DBFinalProject.Reports.Events;
using DBFinalProject.Reports.VolunteerTask;
namespace DBFinalProject
{
    public partial class ReportMenu : Form
    {
        public ReportMenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormB form = new FormB();
            form.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form = new Form1();
            form.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormC form = new FormC();
            form.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormD form = new FormD();
            form.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            ComboVolunteerName form = new ComboVolunteerName();
            form.ShowDialog();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            this.Hide();
            HeadDashboard headDashboard = new HeadDashboard();
            headDashboard.Show();
        }
    }
}
