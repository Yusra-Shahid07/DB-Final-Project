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
        public static void AddEdition(EditionsBL edition)
        {
            string query = $"Insert into Edition (Year, Description) Values ('{edition.Year}','{edition.Description}') ;";
            SQL_Helper.ExecuteQuery(query);
        }

        public static DataTable ShowAllEditions()
        {
            string query = "Select * from Edition";
            DataTable dt = SQL_Helper.view(query);
            return dt;
        }
    }
}
