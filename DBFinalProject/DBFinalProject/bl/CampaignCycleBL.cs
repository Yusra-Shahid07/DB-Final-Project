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
        public string CampaignMonth { get; set; } // Optionally can use an enum
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int EditionID { get; set; }
        public int CampaignID { get; set; }
        public string IsActive { get; set; } // Can also be an enum for "Active"/"Expired"

        public CampaignCycleBL(int campaignCycleID, string campaignMonth, DateTime startDate, DateTime endDate, int editionID, int campaignID, string isActive)
        {
            CampaignCycleID = campaignCycleID;
            CampaignMonth = campaignMonth;
            StartDate = startDate;
            EndDate = endDate;
            EditionID = editionID;
            CampaignID = campaignID;
            IsActive = isActive;
        }

        public CampaignCycleBL(string campaignMonth, DateTime startDate, DateTime endDate, int editionID, int campaignID, string isActive)
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
