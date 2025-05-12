using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBFinalProject.bl
{
    public class VolunteerBL
    {
        public int VolunteerID { get; set; }
        public string FullName { get; set; }
        public string JoinDate { get; set; }
        public int UserID { get; set; }
       
        public string RequestStatus { get; set; } 

        public VolunteerBL(int volunteerID, string fullName, string joinDate, int userID, string requestStatus)
        {
            VolunteerID = volunteerID;
            FullName = fullName;
            JoinDate = joinDate;
            UserID = userID;
            RequestStatus = requestStatus;
        }
        public VolunteerBL(string fullName, string joinDate, int userID)
        {
            FullName = fullName;
            JoinDate = joinDate;
            UserID = userID;
           
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
