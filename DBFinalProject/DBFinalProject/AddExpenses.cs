using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DBFinalProject.bl;
using DBFinalProject.DL;

namespace DBFinalProject
{
    public partial class AddExpenses : Form
    {
        public AddExpenses()
        {
            InitializeComponent();
            LoadEvents();
        }
        private void LoadEvents()
        {
            DataTable events = EventDL.ShowAllEvents(); 
            EventName.Items.Clear();

            foreach (DataRow row in events.Rows)
            {
                EventName.Items.Add(row["EventName"].ToString());
            }
        }
        private void button7_Click(object sender, EventArgs e)
        {
            string eventName = EventName.Text.Trim();
            string category = ExpenseCategory.Text.Trim();
            string paidTo = PaidTo.Text.Trim();
            string description = Description.Text.Trim();
            string amountStr =Amount.Text.Trim();
            DateTime paymentDate = dateTimePicker2.Value;
            if (string.IsNullOrWhiteSpace(eventName) || string.IsNullOrWhiteSpace(category) ||string.IsNullOrWhiteSpace(paidTo) || string.IsNullOrWhiteSpace(amountStr))
            {
                MessageBox.Show("Please fill all fields.");
                return;
            }

            if (!decimal.TryParse(amountStr, out decimal amount) || amount <= 0)
            {
                MessageBox.Show("Amount must be a positive number.");
                return;
            }

            int eventId = EventDL.GetEventIdByName(eventName);
            if (eventId == -1)
            {
                MessageBox.Show("Selected event not found.");
                return;
            }

            // Create and add expense
            ExpensesBL expense = new ExpensesBL(category, amount, paidTo, paymentDate, description, eventId);
            ExpensesDL.AddExpense(expense);
            MessageBox.Show("Expense added successfully.");
         
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.Hide();
            ExpenseForm expense=new ExpenseForm();
            expense.ShowDialog();
        }

        private void AddExpenses_Load(object sender, EventArgs e)
        {

        }
    }
}
