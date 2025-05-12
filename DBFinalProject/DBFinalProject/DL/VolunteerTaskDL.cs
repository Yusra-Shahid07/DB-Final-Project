using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBFinalProject.bl;
namespace DBFinalProject.DL
{
    public class VolunteerTaskDL
    {
        public static bool AddVolunteerTask(VolunteerTaskBL task)
        {
            string query = $@"INSERT INTO VolunteerTask (VolunteerID, AssignedBy, TaskTitle, TaskDescription, Deadline) VALUES ({task.VolunteerID}, {task.AssignedBy}, '{task.TaskTitle}', '{task.TaskDescription}', '{task.Deadline:yyyy-MM-dd}');";
            int rowsAffected = SQL_Helper.ExecuteNonQuery(query);
            return rowsAffected > 0;
        }

        //public static DataTable GetHeadLeadList()
        //{
        //    string query = @"SELECT U.UserID, U.Username FROM Users U WHERE U.Role = 'Head' OR (U.Role = 'Lead' AND EXISTS ( SELECT 1 FROM Volunteer V WHERE V.UserID = U.UserID AND V.Status = 'Accepted'));";
        //    DataTable dt = SQL_Helper.view(query);
        //    return dt;
        //}
        public static DataTable GetHeadLeadList()
        {
            string query = "SELECT Username FROM Users WHERE Role = 'Head' OR Role = 'Lead'";
            return SQL_Helper.view(query);
        }

        public static DataTable ShowAllVolunteerTasks()
        {
            string query = "Select * from VolunteerTask";
            DataTable dt = SQL_Helper.view(query);
            return dt;
        }
        public static void UpdateVolunteerStatus(int id, string newStatus)
        {
            string query = $"UPDATE Volunteer SET Status = '{newStatus}' WHERE VolunteerID = {id}";
            SQL_Helper.ExecuteNonQuery(query);
        }
    }
}
