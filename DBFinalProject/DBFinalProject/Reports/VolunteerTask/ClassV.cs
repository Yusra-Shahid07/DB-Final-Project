using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBFinalProject.Reports.VolunteerTask
{
    public class ClassV
    {
        //FullName AS Volunteer, vt.TaskTitle, vt.TaskDescription, vt.Status, vt.StartDate, vt.Deadline, u.Username
        public string FullName {  get; set; }
        public string TaskTitle { get; set; }
        public string TaskDescription { get; set; }
        public string Status { get; set; }
        public string StartDate { get; set; }
        public string Deadline { get; set; }
        public string Username { get; set; }

        public ClassV(string fullName, string taskTitle, string taskDescription, string status, string startDate, string deadline, string username)
        {
            FullName = fullName;
            TaskTitle = taskTitle;
            TaskDescription = taskDescription;
            Status = status;
            StartDate = startDate;
            Deadline = deadline;
            Username = username;
        }
    }
}
