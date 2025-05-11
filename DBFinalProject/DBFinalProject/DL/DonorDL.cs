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
        public static int GetDonorIDByName(string donorName)
        {
            string query = $"SELECT DonorID FROM Donor WHERE DonorName = '{donorName}' LIMIT 1;";
            DataTable dt = SQL_Helper.view(query);
            if (dt.Rows.Count > 0)
            {
                return Convert.ToInt32(dt.Rows[0]["DonorID"]);
            }
            return -1;
        }
        public static DataTable GetAllDonorNames()
        {
            string query = "SELECT DonorName FROM Donor;";
            DataTable dt = SQL_Helper.view(query);
            return dt;
        }
        public static DataTable ShowAllDonors()
        {
            string query = "Select * from Donor";
            DataTable dt = SQL_Helper.view(query);
            return dt;
        }
    }
}
