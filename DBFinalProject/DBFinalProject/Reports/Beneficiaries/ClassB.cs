using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBFinalProject.Reports.Beneficiaries
{
    public class ClassB
    {
        public string FullName { get; set; }
        public Decimal Amount { get; set; }
        public string BeneficiaryType { get; set; }
        public string CampaignMonth { get; set; }
        public string DonationDate { get; set; }

        public ClassB(string fullName, Decimal amount, string beneficiaryType, string campaignMonth, string donationDate)
        {
            FullName = fullName;
            Amount = amount;
            BeneficiaryType = beneficiaryType;
            CampaignMonth = campaignMonth;
            DonationDate = donationDate;
        }
    }
}
