using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DBFinalProject.DL;

namespace DBFinalProject
{
    public partial class Benefiaries : Form
    {
        public Benefiaries()
        {
            InitializeComponent();
            LoadGrid();
        }
        public void LoadGrid()
        {
            dataGridView1.DataSource = BeneficiaryDL.ShowAllBeneficiaries();
        }
        private void Benefiaries_Load(object sender, EventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    int beneficiaryID = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
                    DialogResult result = MessageBox.Show("Are you sure you want to delete this row?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        BeneficiaryDL.DeleteBeneficiary(beneficiaryID);
                        MessageBox.Show("Row deleted successfully.");
                        dataGridView1.DataSource = null;
                        dataGridView1.DataSource = BeneficiaryDL.ShowAllBeneficiaries();
                    }
                }
                else
                {
                    MessageBox.Show("Please select the row to delete.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManageBeneficiaries manageBeneficiaries = new ManageBeneficiaries();
            manageBeneficiaries.Show();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddBeneficiary addBeneficiary = new AddBeneficiary();
            addBeneficiary.Show();
        }
    }
}
