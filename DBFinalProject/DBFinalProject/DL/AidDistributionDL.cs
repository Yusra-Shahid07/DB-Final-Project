using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBFinalProject.bl;

namespace DBFinalProject.DL
{
    public class AidDistributionDL
    {
        public static void AddAidDistribution(AidDistributionBL aidDistribution)
        {
            string query = $"Insert into AidDistribution (CampaignCycleID, AidType, AmountDonated, DistributionDate) Values('{aidDistribution.CampaignCycleID}','{aidDistribution.AidType}','{aidDistribution.Amount}','{aidDistribution.DistributionDate}') ;";
            SQL_Helper.ExecuteQuery(query);
        }

        public static DataTable ShowAllAidDistributions()
        {
            string query = "Select * from AidDistribution";
            DataTable dt = SQL_Helper.view(query);
            return dt;
        }
    }
}
