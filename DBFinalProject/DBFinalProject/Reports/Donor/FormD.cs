using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace DBFinalProject.Reports.Donor
{
    public partial class FormD : Form
    {
        public FormD()
        {
            InitializeComponent();
        }

        private void FormD_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
            string checkViewQuery = "SELECT COUNT(*) FROM information_schema.views WHERE table_schema = 'pp' AND table_name = 'View_CampaignCycleVolunteers';";
            object result = SQL_Helper.ExecuteScalor(checkViewQuery);
            int count = Convert.ToInt32(result);

            if (count == 0)
            {
                string createViewQuery = @"CREATE VIEW View_CampaignCycleVolunteers AS SELECT v.VolunteerID, v.FullName, cc.CampaignMonth FROM CampaignVolunteer AS cv JOIN Volunteers AS v ON cv.VolunteerID = v.VolunteerID JOIN CampaignCycle AS cc ON cv.CampaignCycleID = cc.CampaignCycleID;";

                SQL_Helper.ExecuteQuery(createViewQuery);
            }
            string selectQuery = "SELECT * FROM View_CampaignCycleVolunteers;";
            DataTable dt = SQL_Helper.view(selectQuery);
            ReportDataSource rds = new ReportDataSource("DataSet1", dt);
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(rds);
            reportViewer1.LocalReport.Refresh();

        }

        private void button14_Click(object sender, EventArgs e)
        {
            this.Hide();
            ReportMenu reportMenu = new ReportMenu();
            reportMenu.Show();
        }
    }
}
