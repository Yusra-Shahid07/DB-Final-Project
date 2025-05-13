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
using MySql.Data.MySqlClient;

namespace DBFinalProject.Reports.Beneficiaries
{
    public partial class FormB : Form
    {
        public FormB()
        {
            InitializeComponent();
        }

        private void FormB_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
            string query = $"CREATE VIEW View_BeneficiaryAid AS SELECT b.FullName, db.Amount, db.BeneficiaryType, cc.CampaignMonth, db.DonationDate FROM DonationBeneficiary as db JOIN Beneficiaries as b ON db.BeneficiaryID = b.BeneficiaryID JOIN CampaignCycle as cc ON db.CampaignCycleID = cc.CampaignCycleID;";
            DataTable dt = SQL_Helper.view(query);

            ReportDataSource rds = new ReportDataSource("DataSet1", dt);
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(rds);
            reportViewer1.LocalReport.Refresh();
        }
    }
}
