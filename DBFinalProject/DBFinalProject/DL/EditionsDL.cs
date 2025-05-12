using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBFinalProject.bl;

namespace DBFinalProject.DL
{
    public class EditionsDL
    {
        public static bool AddEdition(EditionsBL edition)
        {
            string query = $"Insert into Edition (Year, Description) Values ('{edition.Year}','{edition.Description}') ;";
            int rowsAffected = SQL_Helper.ExecuteNonQuery(query);
            return rowsAffected > 0;
        }
        public static DataTable GetAllEditionIDs()
        {
            string query = "SELECT EditionID FROM Edition;";
            DataTable dt = SQL_Helper.view(query);
            return dt;
        }

        public static DataTable GetAllEditionYears()
        {
            string query = "SELECT Year FROM Edition;";
            DataTable dt = SQL_Helper.view(query);
            return dt;
        }
        public static DataTable ShowAllEditions()
        {
            string query = "Select * from Edition";
            DataTable dt = SQL_Helper.view(query);
            return dt;
        }
        public static int GetEditionIdByYear(string year)
        {
            int editionId = -1;
            string query = $"SELECT EditionID FROM edition WHERE Year = '{year}'";

            object result = SQL_Helper.ExecuteScalor(query);
            if (result != null && int.TryParse(result.ToString(), out int id))
            {
                editionId = id;
            }

            return editionId;
        }
    }
}
