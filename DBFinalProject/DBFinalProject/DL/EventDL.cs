using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBFinalProject.bl;

namespace DBFinalProject.DL
{
    public class EventDL
    {
        public static void AddEvent(EventBL events)
        {
            string query = $"Insert into Event (EventName, EventDate, EditionID, Location, CategoryID) Values('{events.EventName}','{events.EventDate}','{events.EditionID}','{events.Location}','{events.CategoryID}') ;";
            SQL_Helper.ExecuteQuery(query);
        }

        public static void DeleteEvent(string eventName)
        {
            string query = $"DELETE FROM Event WHERE EventName = {eventName};";
            SQL_Helper.ExecuteQuery(query);
        }

        public static void UpdateEvent(EventBL events)
        {
            string query = $"UPDATE Event SET EventDate = '{events.EventDate}',EditionID = '{events.EditionID}',Location = '{events.Location}',CategoryID = '{events.CategoryID}' WHERE EventName = '{events.EventName}';";
            SQL_Helper.ExecuteQuery(query);
        }
        public static DataTable ShowAllEvents()
        {
            string query = "Select * from Event";
            DataTable dt = SQL_Helper.view(query);
            return dt;
        }
    }
}
