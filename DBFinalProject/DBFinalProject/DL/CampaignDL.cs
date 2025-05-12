using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBFinalProject.bl;

namespace DBFinalProject.DL
{
    public class CampaignDL
    {
        public static void AddCampaign(CampaignBL campaign)
        {
            string query = $"Insert into Campaign (CampaignName, Description) Values('{campaign.compaignname}','{campaign.description}') ;";
            SQL_Helper.ExecuteQuery(query);
        }
        public static void UpdateCampaign(int campaignId, CampaignBL updatedCampaign)
        {
            string query = $"UPDATE Campaign SET CampaignName = '{updatedCampaign.compaignname}', Description = '{updatedCampaign.description}' WHERE CampaignID = {campaignId};";
            SQL_Helper.ExecuteQuery(query);
        }
        public static int GetCampaignIdByName(string campaignName)
        {
            string query = $"SELECT CampaignID FROM campaign WHERE CampaignName = '{campaignName}'";
            object result = SQL_Helper.ExecuteScalor(query);

            if (result != null && int.TryParse(result.ToString(), out int id))
            {
                return id;
            }

            return -1; 
        }
        public static void DeleteCampaign(int campaignId)
        {
            string query = $"DELETE FROM campaign WHERE CampaignID = {campaignId}";
            SQL_Helper.ExecuteNonQuery(query);
        }
        public static DataTable ShowAllCampaigns()
        {
            string query = "Select * from Campaign";
            DataTable dt = SQL_Helper.view(query);
            return dt;
        }
    }
}
