using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DBFinalProject.Reports.Beneficiaries;
using DBFinalProject.Reports.CampaignCycles;
using DBFinalProject.Reports.Donor;
using DBFinalProject.Reports.Events;
using DBFinalProject.Reports.VolunteerTask;

namespace DBFinalProject
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormD());
        }
    }
}
