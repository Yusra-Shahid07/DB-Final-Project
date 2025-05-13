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

namespace DBFinalProject.Reports.Events
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
            //SELECT Event.EventID, EventName, EventDate, Location, CategoryName, Edition.Year FROM Event JOIN EventCategory ON Event.CategoryID = EventCategory.CategoryID JOIN Edition ON Event.EditionID = Edition.EditionID;
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
            string query = $"SELECT Event.EventName, Event.EventDate, Event.Location, EventCategory.CategoryName, Edition.Year FROM Event JOIN EventCategory ON Event.CategoryID = EventCategory.CategoryID JOIN Edition ON Event.EditionID = Edition.EditionID;";
            DataTable dt = SQL_Helper.view(query);

            ReportDataSource rds = new ReportDataSource("DataSet1", dt);
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(rds);
            reportViewer1.LocalReport.Refresh();
        }
    }
}
