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

        public static DataTable ShowAllCampaigns()
        {
            string query = "Select * from Campaign";
            DataTable dt = SQL_Helper.view(query);
            return dt;
        }
    }
}
