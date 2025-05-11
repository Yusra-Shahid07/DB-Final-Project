using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBFinalProject.bl;

namespace DBFinalProject.DL
{
    public class CampaignCycleDL
    {
        public static void AddCampaignCycle(CampaignCycleBL campaignCycle)
        {
            string query = $"Insert into CampaignCycle (CampaignMonth, StartDate, EndDate, EditionID, CampaignID, IsActive) Values('{campaignCycle.CampaignMonth}','{campaignCycle.StartDate}','{campaignCycle.EndDate}','{campaignCycle.EditionID}''{campaignCycle.CampaignID}','{campaignCycle.IsActive}') ;";
            SQL_Helper.ExecuteQuery(query);
        }

        public static DataTable ShowAllCampaignCycles()
        {
            string query = "Select * from CampaignCycle";
            DataTable dt = SQL_Helper.view(query);
            return dt;
        }

        public static DataTable GetAllCampaignCycleIDs()
        {
            string query = "SELECT CampaignCycleID FROM CampaignCycle"; // adjust table name if needed
            return SQL_Helper.view(query);
        }

  


    }
}
