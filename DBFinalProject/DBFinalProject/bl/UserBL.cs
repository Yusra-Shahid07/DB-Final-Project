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
        public bool IsValidPassword(string password)
        {
            if (password.Length < 8)
                return false;

            bool hasLetter = false;
            bool hasDigit = false;

            foreach (char c in password)
            {
                if (char.IsLetter(c)) hasLetter = true;
                if (char.IsDigit(c)) hasDigit = true;
            }

            return hasLetter && hasDigit;
        }
        public bool IsValidPhone(string phone)
        {
            if (phone.Length != 12)
                return false;

            if (!(phone.StartsWith("03") && phone[4] == '-'))
                return false;

            for (int i = 0; i < phone.Length; i++)
            {
                if (i == 4) continue; // skip dash
                if (!char.IsDigit(phone[i])) return false;
            }

            return true;
        }

        public bool IsValidEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email) || !email.Contains("@") || !email.Contains("."))
            {
                return false;
            }

            int atIndex = email.IndexOf('@');
            int dotIndex = email.LastIndexOf('.');

            if (atIndex < 1 || dotIndex < atIndex + 2 || dotIndex >= email.Length - 1)
            {
                return false;
            }

            return true;
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
