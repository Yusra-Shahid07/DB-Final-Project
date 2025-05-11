using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBFinalProject.bl
{
    public class UserBL
    {
        public int UserID { get; set; }
        public string Username { get; set; }
        public string Phone { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Role { get; set; }  // Can also be replaced with an enum for Role

        public UserBL(int userID, string username, string phone, string password, string email, string role)
        {
            UserID = userID;
            Username = username;
            Phone = phone;
            Password = password;
            Email = email;
            Role = role;
        }
        public UserBL(string username, string phone, string password, string email, string role)
        {
            Username = username;
            Phone = phone;
            Password = password;
            Email = email;
            Role = role;
        }
        public static bool IsAllAlphabetsOrSpace(string input)
        {
            foreach (char c in input)
            {
                if (!((c >= 'a' && c <= 'z') || (c >= 'A' && c <= 'Z') || c == ' '))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
