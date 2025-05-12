using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBFinalProject.bl
{
    public class CampaignCycleBL
    {
        public int CampaignCycleID { get; set; }
        public string CampaignMonth { get; set; } 
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public int EditionID { get; set; }
        public int CampaignID { get; set; }
        public string IsActive { get; set; } 

      
        public CampaignCycleBL(string campaignMonth,string startDate,string endDate, int editionID, int campaignID, string isActive)
        {
            CampaignMonth = campaignMonth;
            StartDate = startDate;
            EndDate = endDate;
            EditionID = editionID;
            CampaignID = campaignID;
            IsActive = isActive;
        }
    }
}
