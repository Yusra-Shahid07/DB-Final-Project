using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBFinalProject.bl;

namespace DBFinalProject.DL
{
    public class DonationBeneficiariesDL
    {
        public static void AddDonationBeneficiary(DonationBeneficiariesBL donationBeneficiary)
        {
            string query = $"Insert into DonationBeneficiary (BeneficiaryID, DonationDate, Amount, BeneficiaryType, CampaignCycleID) Values('{donationBeneficiary.DonationBeneficiaryID}','{donationBeneficiary.DonationDate}','{donationBeneficiary.Amount}','{donationBeneficiary.BeneficiaryType}''{donationBeneficiary.CampaignCycleID}') ;";
            SQL_Helper.ExecuteQuery(query);
        }

        public static DataTable ShowAllDonationBeneficiaries()
        {
            string query = "Select * from DonationBeneficiary";
            DataTable dt = SQL_Helper.view(query);
            return dt;
        }
    }
}
