using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBFinalProject.DL
{
    public class CampaignRequestDL
    {
        public static bool InsertRequest(int campaignCycleId, int volunteerId)
        {
            string query = $"INSERT INTO CampaignRequests (CampaignCycleID, VolunteerID) " +
                           $"VALUES ({campaignCycleId}, {volunteerId})";

            int rowsAffected = SQL_Helper.ExecuteNonQuery(query); // make sure this returns an int
            return rowsAffected > 0;
        }
    }
}
