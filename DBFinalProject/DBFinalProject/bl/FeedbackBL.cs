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
        public string SubmittedByRole { get; set; }  // Can also be replaced with an enum
        public int SubmittedByID { get; set; }
        public int CampaignCycleID { get; set; }
        public int UserID { get; set; }
        public string FeedbackText { get; set; }
        public int Rating { get; set; }
        public DateTime SubmissionDate { get; set; }

        public FeedbackBL(int feedbackID, string submittedByRole, int submittedByID, int campaignCycleID, int userID, string feedbackText, int rating, DateTime submissionDate)
        {
            FeedbackID = feedbackID;
            SubmittedByRole = submittedByRole;
            SubmittedByID = submittedByID;
            CampaignCycleID = campaignCycleID;
            UserID = userID;
            FeedbackText = feedbackText;
            Rating = rating;
            SubmissionDate = submissionDate;
        }
        public FeedbackBL(string submittedByRole, int submittedByID, int campaignCycleID, int userID, string feedbackText, int rating, DateTime submissionDate)
        {
            SubmittedByRole = submittedByRole;
            SubmittedByID = submittedByID;
            CampaignCycleID = campaignCycleID;
            UserID = userID;
            FeedbackText = feedbackText;
            Rating = rating;
            SubmissionDate = submissionDate;
        }
    }
}
