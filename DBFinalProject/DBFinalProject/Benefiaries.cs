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
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Select a row to delete.");
                return;
            }

            DialogResult result = MessageBox.Show("Are you sure you want to delete this beneficiary?", "Confirm Delete", MessageBoxButtons.YesNo);
            if (result == DialogResult.No) return;

            int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["BeneficiaryID"].Value);
            BeneficiaryDL.DeleteBeneficiary(id);
            MessageBox.Show("Beneficiary deleted.");
            LoadGrid();

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

        private void button13_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a beneficiary to update.");
                return;
            }

            DataGridViewRow row = dataGridView1.SelectedRows[0];
            int id = Convert.ToInt32(row.Cells["BeneficiaryID"].Value);
            string name = row.Cells["FullName"].Value.ToString();
            DateTime dob = Convert.ToDateTime(row.Cells["DOB"].Value);
            string gender = row.Cells["Gender"].Value.ToString();
            string phone = row.Cells["Phone"].Value.ToString();
            string address = row.Cells["Address"].Value.ToString();
            UpdateDonationBeneficiaries updateForm = new UpdateDonationBeneficiaries(id, name, dob, gender, phone, address);
            updateForm.ShowDialog();
            LoadGrid();

        }
    }
}
