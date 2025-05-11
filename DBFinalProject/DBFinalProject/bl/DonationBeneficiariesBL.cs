using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBFinalProject.bl
{
    public class DonationBeneficiariesBL
    {
        public int DonationBeneficiaryID { get; set; }

        public int BeneficiaryID { get; set; }
        public DateTime DonationDate { get; set; }
        public decimal Amount { get; set; }
        public string BeneficiaryType { get; set; }
        public int CampaignCycleID { get; set; }

        public DonationBeneficiariesBL(int beneficiaryID, DateTime donationDate, decimal amount, string beneficiaryType, int campaignCycleID)
        {
            BeneficiaryID = beneficiaryID;
            DonationDate = donationDate;
            Amount = amount;
            BeneficiaryType = beneficiaryType;
            CampaignCycleID = campaignCycleID;
        }
        //public DonationBeneficiariesBL(DateTime donationDate, decimal amount, string beneficiaryType, int campaignCycleID)
        //{
        //    DonationDate = donationDate;
        //    Amount = amount;
        //    BeneficiaryType = beneficiaryType;
        //    CampaignCycleID = campaignCycleID;
        //}
    }
}
