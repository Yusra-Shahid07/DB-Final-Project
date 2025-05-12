using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBFinalProject.bl
{
    public class FeedbackBL
    {
        public int FeedbackID { get; set; }
        public string SubmittedByRole { get; set; } 
        public int SubmittedByID { get; set; }
        public int CampaignCycleID { get; set; }
        public int UserID { get; set; }
        public string FeedbackText { get; set; }
        public int Rating { get; set; }
        public string SubmissionDate { get; set; }

      

        public FeedbackBL(string submittedByRole, int submittedByID, int campaignCycleID, int rating,string feedbackText,string submissionDate)
        {
            SubmittedByRole = submittedByRole;
            SubmittedByID = submittedByID;
            CampaignCycleID = campaignCycleID;
            FeedbackText = feedbackText;
            Rating = rating;
            SubmissionDate = submissionDate;
        }
    }
}
