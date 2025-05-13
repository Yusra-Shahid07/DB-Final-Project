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
            string query = $"SELECT d.DonorID, d.DonorName, d.Email, d.City, SUM(dd.Amount) AS TotalAmount FROM Donor AS d LEFT JOIN Donation AS dd ON d.DonorID = dd.DonorID GROUP BY d.DonorID;";
            DataTable dt = SQL_Helper.view(query);

            ReportDataSource rds = new ReportDataSource("DataSet1", dt);
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(rds);
            reportViewer1.LocalReport.Refresh();
        }
    }
}
