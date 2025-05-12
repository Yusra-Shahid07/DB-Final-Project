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
    public partial class UpdateExpense : Form
    {
        int expenseId;
        public UpdateExpense()
        {
            InitializeComponent();

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
        public UpdateExpense(int expenseId, string category,decimal amount,string paidTo,DateTime date,string desc,string eventName)
        {
            InitializeComponent();
            EventName.Text = eventName;
            ExpenseCategory.Text = category;
            PaidTo.Text = paidTo;
            Description.Text = desc;
            Amount.Text = amount.ToString();
            dateTimePicker2.Value = date;
            this.expenseId = expenseId; 
        }
        private void UpdateExpense_Load(object sender, EventArgs e)
        {
            LoadEvents();
        }

        private void button7_Click(object sender, EventArgs e)
        {
    
            string eventName = EventName.Text.Trim();
            string category = ExpenseCategory.Text.Trim();
            string paidTo = PaidTo.Text.Trim();
            string description = Description.Text.Trim();
            string amountStr = Amount.Text.Trim();
            DateTime paymentDate = dateTimePicker2.Value;

            if (string.IsNullOrWhiteSpace(eventName) || string.IsNullOrWhiteSpace(category) ||
                string.IsNullOrWhiteSpace(paidTo) || string.IsNullOrWhiteSpace(amountStr))
            {
                MessageBox.Show("Please fill all fields.");
                return;
            }

            if (!decimal.TryParse(amountStr, out decimal amount) || amount <= 0)
            {
                MessageBox.Show("Invalid amount.");
                return;
            }

            int eventId = EventDL.GetEventIdByName(eventName);
            if (eventId == -1)
            {
                MessageBox.Show("Event not found.");
                return;
            }

            ExpensesBL updated = new ExpensesBL(category, amount, paidTo, paymentDate, description, eventId);
            ExpensesDL.UpdateExpense(expenseId, updated);

            MessageBox.Show("Expense updated successfully!");
            
        
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.Hide();
            ExpenseForm expenseForm = new ExpenseForm();
            expenseForm.ShowDialog();
        }
    }
}
