using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBFinalProject.bl
{
    public class CampaignBL
    {
        public int campaignID { get; set; }
        public string compaignname { get; set; }
        public string description { get; set; }
        public CampaignBL(int campaignID, string compaignname, string description)
        {
            this.campaignID = campaignID;
            this.compaignname = compaignname;
            this.description = description;
        }
        public CampaignBL(string compaignname, string description)
        {
            this.compaignname = compaignname;
            this.description = description;
        }

        public static bool IsAllAlphabetsOrSpace(string input)
        {
            foreach (char c in input)
            {
                if (!((c >= 'a' && c <= 'z') || (c >= 'A' && c <= 'Z') || c == ' '))
                {
                    return false;
                }
            }
            return true;
        }
    }

}
