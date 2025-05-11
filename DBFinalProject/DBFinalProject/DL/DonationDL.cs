using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBFinalProject.bl;

namespace DBFinalProject.DL
{
    public class DonationDL
    {
        public static void AddDonation(DonationBL donation)
        {
            string query = $"Insert into Donation (DonorID, Amount, Donation_Date, CampaignCycleID) Values ('{donation.DonorID}','{donation.Amount}','{donation.DonationDate}','{donation.CampaignCycleID}') ;";
            SQL_Helper.ExecuteQuery(query);
        }

        public static DataTable ShowAllDonations()
        {
            string query = "Select * from Donation";
            DataTable dt = SQL_Helper.view(query);
            return dt;
        }
    }
}
