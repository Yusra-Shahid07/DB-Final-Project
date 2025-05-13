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
using DBFinalProject.DL;
namespace DBFinalProject.Reports.VolunteerTask
{
    public partial class FormV : Form
    {
        public FormV()
        {
            InitializeComponent();
            LoadVolunteerNames();
        }
        private void LoadVolunteerNames()
        {
            DataTable volunteers = VolunteerDL.GetAllVolunteerNames();
            comboBox1.Items.Clear();
            foreach (DataRow row in volunteers.Rows)
            {
                comboBox1.Items.Add(row["FullName"].ToString());
            }
        }

        private void FormV_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
            string fullName = comboBox1.SelectedItem.ToString();

            string query = $"CALL GetVolunteerTasksByName('{fullName}');";
            DataTable dt = SQL_Helper.view(query);

            ReportDataSource rds = new ReportDataSource("DataSet1", dt);
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(rds);
            reportViewer1.LocalReport.Refresh();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
