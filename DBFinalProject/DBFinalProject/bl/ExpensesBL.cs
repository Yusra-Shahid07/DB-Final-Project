using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBFinalProject.bl
{
    public class ExpensesBL
    {
        public int ExpenseID { get; set; }
        public string ExpenseCategory { get; set; }
        public decimal Amount { get; set; }
        public string PaidTo { get; set; }
        public DateTime PaymentDate { get; set; }
        public string Description { get; set; }

        public ExpensesBL(int expenseID, string expenseCategory, decimal amount, string paidTo, DateTime paymentDate, string description)
        {
            ExpenseID = expenseID;
            ExpenseCategory = expenseCategory;
            Amount = amount;
            PaidTo = paidTo;
            PaymentDate = paymentDate;
            Description = description;
        }
        public ExpensesBL(string expenseCategory, decimal amount, string paidTo, DateTime paymentDate, string description)
        {
            ExpenseCategory = expenseCategory;
            Amount = amount;
            PaidTo = paidTo;
            PaymentDate = paymentDate;
            Description = description;
        }
    }
}
