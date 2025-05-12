using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBFinalProject.bl;
using MySql.Data.MySqlClient;

namespace DBFinalProject.DL
{
    public class UserDL
    {
        public static void AddUser(UserBL user)
        {
            string query = $"Insert into Users(Username, Phone, Password,Email, Role) Values('{user.Username}','{user.Phone}','{user.Password}','{user.Email}','{user.Role}') ;";
            SQL_Helper.ExecuteQuery(query);
        }
        public static DataTable GetAllUserIDs()
        {
            string query = "SELECT UserID, UserName FROM users;";
            return SQL_Helper.view(query);
        }
        public static int GetUserIdByUsername(string username)
        {
            string query = $"SELECT UserID FROM users WHERE Username = '{username}'";
            object result = SQL_Helper.ExecuteScalor(query);
            if (result != null && int.TryParse(result.ToString(), out int id))
            {
                return id;
            }
            return -1;
        }
        public static int GetUserIdByEmail(string email)
        {
            string query = $"SELECT UserID FROM users WHERE Email = '{email}'";
            DataTable dt = SQL_Helper.view(query);

            if (dt.Rows.Count > 0)
            {
                return Convert.ToInt32(dt.Rows[0]["UserID"]);
            }
            else
            {
                return -1; 
            }
        }
        public static bool UpdatePassword(int userId, string newPassword)
        {
            string query = $"UPDATE users SET Password = '{newPassword}' WHERE UserID = {userId}";
            int rows = SQL_Helper.ExecuteNonQuery(query);

            return rows > 0; 
        }
        public static DataTable GetEligibleUserIds()
        {
            string query = "SELECT UserID FROM Users WHERE Role = 'lead' OR Role = 'member'";
            return SQL_Helper.view(query);
        }
    }
}
