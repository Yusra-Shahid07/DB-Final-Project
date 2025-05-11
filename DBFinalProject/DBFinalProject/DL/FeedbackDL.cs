using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBFinalProject.bl;

namespace DBFinalProject.DL
{
    public class FeedbackDL
    {
        public static void AddFeedback(FeedbackBL feedback)
        {
            string query = $"Insert into Feedback (SubmittedByRole, CampaignCycleID, UserID, FeedbackText, Rating, SubmissionDate) Values('{feedback.SubmittedByRole}','{feedback.CampaignCycleID}','{feedback.UserID}','{feedback.FeedbackText}','{feedback.Rating}','{feedback.SubmissionDate}') ;";
            SQL_Helper.ExecuteQuery(query);
        }

        public static DataTable ShowAllFeedbacks()
        {
            string query = "Select * from Feedback";
            DataTable dt = SQL_Helper.view(query);
            return dt;
        }
    }
}
