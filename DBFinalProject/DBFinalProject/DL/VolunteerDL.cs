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
            string query = $"Insert into Volunteer(FullName, JoinDate, UserID) Values('{volunteer.FullName}','{volunteer.JoinDate}','{volunteer.UserID}') ;";
            SQL_Helper.ExecuteQuery(query);
        }
  
        public static DataTable ShowAllVolunteers()
        {
            string query = "Select * from Volunteer";
            DataTable dt = SQL_Helper.view(query);
            return dt;
        }
        public static DataTable GetAllVolunteerNames()
        {
            string query = "SELECT FullName FROM Volunteer"; 
            return SQL_Helper.view(query);
        }
        public static DataTable GetAllVolunteerIDs()
        {
            string query = "SELECT VolunteerID FROM Volunteer"; 
            return SQL_Helper.view(query);
        }
        public static void UpdateVolunteerStatus(int id, string newStatus)
        {
            string query = $"UPDATE Volunteer SET RequestStatus = '{newStatus}' WHERE VolunteerID = {id}";
            SQL_Helper.ExecuteNonQuery(query);
        }
        public static int GetVolunteerIdByName(string name)
        {
            string query = $"SELECT VolunteerID FROM volunteer WHERE FullName = '{name}'";
            object result = SQL_Helper.ExecuteScalor(query);
            if (result != null && int.TryParse(result.ToString(), out int id))
            {
                return id;
            }
            return -1;
        }
    }
}
