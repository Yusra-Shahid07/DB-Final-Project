using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBFinalProject.bl;
namespace DBFinalProject.DL
{
    public class ExpensesDL
    {
        public static void AddExpense(ExpensesBL expense)
        {
            string query = $"INSERT INTO Expense (ExpenseCategory, Amount, PaidTo, PaymentDate, Description, EventID) VALUES ('{expense.ExpenseCategory}', '{expense.Amount}', '{expense.PaidTo}', '{expense.PaymentDate:yyyy-MM-dd}', '{expense.Description}', '{expense.EventID}');";
            SQL_Helper.ExecuteQuery(query);
        }

        public static void DeleteExpense(int eventID)
        {
            string query = $"DELETE FROM Expense WHERE EventID = {eventID};";
            SQL_Helper.ExecuteQuery(query);
        }

        public static void UpdateExpense(ExpensesBL expense)
        {
            string query = $"UPDATE Expense SET Amount = '{expense.Amount}',PaidTo = '{expense.PaidTo}',PaymentDate = '{expense.PaymentDate}',Description = '{expense.Description}' WHERE EventID = '{expense.EventID}';";
            SQL_Helper.ExecuteQuery(query);
        }
        public static DataTable ShowAllExpenses()
        {
            string query = "Select * from Expense";
            DataTable dt = SQL_Helper.view(query);
            return dt;
        }
    }
}
