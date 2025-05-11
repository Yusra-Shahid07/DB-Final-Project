using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBFinalProject.bl
{
    public class AidDistributionBL
    {
        public int AidID { get; set; }
        public int CampaignCycleID { get; set; }
        public string AidType { get; set; }  // Using string to map enum from DB
        public int Amount { get; set; }
        public DateTime DistributionDate { get; set; }

        public AidDistributionBL(int campaignCycleID, string aidType, int amount, DateTime distributionDate)
        {
            CampaignCycleID = campaignCycleID;
            AidType = aidType;
            Amount = amount;
            DistributionDate = distributionDate;
        }
    }
}
