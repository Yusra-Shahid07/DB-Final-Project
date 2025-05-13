using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBFinalProject.Reports.CampaignCycles
{
    public class ClassC
    {
        public string CampaignName {  get; set; }   
        public string CampaignMonth { get; set; }
        public string FullName { get; set; }
        public string JoinDate { get; set; }

        public ClassC(string campaignName, string campaignMonth, string fullName, string joinDate)
        {
            CampaignName = campaignName;
            CampaignMonth = campaignMonth;
            FullName = fullName;
            JoinDate = joinDate;
        }
    }
}
