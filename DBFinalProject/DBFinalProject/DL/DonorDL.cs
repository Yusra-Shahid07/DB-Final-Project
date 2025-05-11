using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBFinalProject.bl;

namespace DBFinalProject.DL
{
    public class DonorDL
    {
        public static bool AddDonor(DonorBL donor)
        {
            string query = $"INSERT INTO Donor (DonorName) VALUES ('{donor.DonorName}');";
            int rowsAffected = SQL_Helper.ExecuteNonQuery(query); 

            return rowsAffected > 0;
        }

        public static DataTable ShowAllDonors()
        {
            string query = "Select * from Donor";
            DataTable dt = SQL_Helper.view(query);
            return dt;
        }
    }
}
