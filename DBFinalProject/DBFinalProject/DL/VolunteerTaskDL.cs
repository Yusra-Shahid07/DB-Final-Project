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
        public static void AddVolunteerTask(VolunteerTaskBL volunteerTask)
        {
            string query = $"Insert into VolunteerTask(VolunteerID, AssignedBy, TaskTitle, TaskDescription, Status, StartDate, Deadline) Values('{volunteerTask.VolunteerID}','{volunteerTask.AssignedBy}','{volunteerTask.TaskTitle}','{volunteerTask.TaskDescription}','{volunteerTask.Status}','{volunteerTask.StartDate}','{volunteerTask.Deadline}') ;";
            SQL_Helper.ExecuteQuery(query);
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
