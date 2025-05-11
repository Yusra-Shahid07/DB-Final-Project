using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBFinalProject.bl;

namespace DBFinalProject.DL
{
    public class EventCategoryDL
    {
        public static void AddEventCategory(EventCategoryBL eventCategory)
        {
            string query = $"Insert into EventCategory(CategoryName, Description) Values('{eventCategory.CategoryName}','{eventCategory.Description}') ;";
            SQL_Helper.ExecuteQuery(query);
        }

        public static void DeleteEventCategory(string categoryName)
        {
            string query = $"DELETE FROM EventCategory WHERE CategoryName = {categoryName};";
            SQL_Helper.ExecuteQuery(query);
        }

        public static void UpdateEventCategory(EventCategoryBL eventCategory)
        {
            string query = $"UPDATE EventCategory SET Description = '{eventCategory.Description}' WHERE CategoryName = '{eventCategory.CategoryName}';";
            SQL_Helper.ExecuteQuery(query);
        }
        public static DataTable GetAllCategories()
        {
            string query = "SELECT * FROM EventCategory";
            return SQL_Helper.view(query);
        }

        public static int GetCategoryIdByName(string name)
        {
            string query = $"SELECT CategoryID FROM EventCategory WHERE CategoryName = '{name}'";
            DataTable dt = SQL_Helper.view(query);
            if (dt.Rows.Count > 0)
            {
                return Convert.ToInt32(dt.Rows[0]["CategoryID"]);
            }
            return -1;
        }
    }
}
