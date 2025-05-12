using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DBFinalProject.DL;
using Mysqlx.Crud;

namespace DBFinalProject
{
    public partial class ExpenseForm : Form
    {
        public ExpenseForm()
        {
            InitializeComponent();
            LoadGrid();
        }
      

        public void LoadGrid()
        {
            dataGridView1.DataSource = ExpensesDL.ShowAllExpenses();
        }
        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddExpenses addExpenses = new AddExpenses();
            addExpenses.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.Hide();
            HeadDashboard h = new HeadDashboard();
            h.Show();
        }

        private void button12_Click(object sender, EventArgs e)
        {

            if (dataGridView1.SelectedRows.Count > 0)
            {
                int expenseId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["ExpenseID"].Value);
                string category = dataGridView1.SelectedRows[0].Cells["ExpenseCategory"].Value.ToString();
                string paidTo = dataGridView1.SelectedRows[0].Cells["PaidTo"].Value.ToString();
                string desc = dataGridView1.SelectedRows[0].Cells["Description"].Value.ToString();
                decimal amount = Convert.ToDecimal(dataGridView1.SelectedRows[0].Cells["Amount"].Value);
                DateTime date = Convert.ToDateTime(dataGridView1.SelectedRows[0].Cells["PaymentDate"].Value);

                int eventID = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["EventID"].Value.ToString());
                string eventName=EventDL.GetEventNameById(eventID);
                this.Hide();
                UpdateExpense editForm = new UpdateExpense(expenseId, category, amount, paidTo, date, desc, eventName);
                editForm.ShowDialog();

                LoadGrid(); // refresh after update
            }
            else
            {
                MessageBox.Show("Please select a row first.");
            }

        }

        private void button11_Click(object sender, EventArgs e)
        {
           
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select an expense to delete.");
                return;
            }

            DialogResult result = MessageBox.Show("Are you sure you want to delete this expense?", "Confirm Delete", MessageBoxButtons.YesNo);
            if (result == DialogResult.No)
                return;

            int expenseId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["ExpenseId"].Value);
            ExpensesDL.DeleteExpense(expenseId);
            MessageBox.Show("Expense deleted successfully.");
            LoadGrid(); 
   
        }

        private void ExpenseForm_Load(object sender, EventArgs e)
        {

        }
    }
}
