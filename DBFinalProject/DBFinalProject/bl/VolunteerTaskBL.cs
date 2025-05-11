using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBFinalProject.bl
{
    public class VolunteerTaskBL
    {
        public int TaskID { get; set; }
        public int VolunteerID { get; set; }
        public int AssignedBy { get; set; }
        public string TaskTitle { get; set; }
        public string TaskDescription { get; set; }
        public string Status { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime Deadline { get; set; }

        public VolunteerTaskBL(int taskID, int volunteerID, int assignedBy, string taskTitle, string taskDescription, string status, DateTime startDate, DateTime deadline)
        {
            TaskID = taskID;
            VolunteerID = volunteerID;
            AssignedBy = assignedBy;
            TaskTitle = taskTitle;
            TaskDescription = taskDescription;
            Status = status;
            StartDate = startDate;
            Deadline = deadline;
        }
        public VolunteerTaskBL(int volunteerID, int assignedBy, string taskTitle, string taskDescription, DateTime deadline)
        {
            VolunteerID = volunteerID;
            AssignedBy = assignedBy;
            TaskTitle = taskTitle;
            TaskDescription = taskDescription;
            
            Deadline = deadline;
        }
    }
}
