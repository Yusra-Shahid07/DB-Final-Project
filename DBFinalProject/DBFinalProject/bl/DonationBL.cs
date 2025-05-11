using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBFinalProject.bl
{
    public class DonationBL
    {
        public int DonationID { get; set; }
        public int DonorID { get; set; }
        public decimal Amount { get; set; }
        public DateTime DonationDate { get; set; }
        public int CampaignCycleID { get; set; }

        public DonationBL(int donationID, int donorID, decimal amount, DateTime donationDate, int campaignCycleID)
        {
            DonationID = donationID;
            DonorID = donorID;
            Amount = amount;
            DonationDate = donationDate;
            CampaignCycleID = campaignCycleID;
        }
        public DonationBL(int donorID, decimal amount, DateTime donationDate, int campaignCycleID)
        {
            DonorID = donorID;
            Amount = amount;
            DonationDate = donationDate;
            CampaignCycleID = campaignCycleID;
        }
    }
}
