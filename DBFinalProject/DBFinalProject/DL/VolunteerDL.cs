using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBFinalProject.bl;

namespace DBFinalProject.DL
{
    public class VolunteerDL
    {
        public static void AddVolunteer(VolunteerBL volunteer)
        {
            string query = $"Insert into Volunteer(FullName, JoinDate, UserID,  RequestStatus) Values('{volunteer.FullName}','{volunteer.JoinDate}','{volunteer.UserID}','{volunteer.RequestStatus}') ;";
            SQL_Helper.ExecuteQuery(query);
        }

        public static DataTable ShowAllVolunteers()
        {
            string query = "Select * from Volunteer";
            DataTable dt = SQL_Helper.view(query);
            return dt;
        }
        public static DataTable GetAllVolunteerIDs()
        {
            string query = "SELECT VolunteerID FROM Volunteer"; // replace Volunteer with your actual table name
            return SQL_Helper.view(query);
        }
        public static void UpdateVolunteerStatus(int id, string newStatus)
        {
            string query = $"UPDATE Volunteer SET Status = '{newStatus}' WHERE VolunteerID = {id}";
            SQL_Helper.ExecuteNonQuery(query);
        }
    }
}
