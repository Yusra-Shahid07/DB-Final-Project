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
                return -1; // Not found
            }
        }
        public static bool UpdatePassword(int userId, string newPassword)
        {
            string query = $"UPDATE users SET Password = '{newPassword}' WHERE UserID = {userId}";
            int rows = SQL_Helper.ExecuteNonQuery(query);

            return rows > 0; // true if updated, false if not
        }
        public static DataTable GetEligibleUserIds()
        {
            string query = "SELECT UserID FROM Users WHERE Role = 'lead' OR Role = 'member'";
            return SQL_Helper.view(query);
        }
    }
}
