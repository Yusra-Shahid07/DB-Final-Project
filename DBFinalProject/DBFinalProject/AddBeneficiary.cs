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
    public partial class AddBeneficiary : Form
    {
        public AddBeneficiary()
        {
            InitializeComponent();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            string fullName = FullName.Text.Trim();
            DateTime dob = dateTimePicker1.Value.Date;
            string gender = Gender.SelectedItem.ToString();
            string phone = Phone.Text.Trim();
            string address = textBox1.Text.Trim();
            string dobFormatted = dob.ToString("yyyy-MM-dd");
            if (string.IsNullOrEmpty(fullName) || string.IsNullOrEmpty(phone) || string.IsNullOrEmpty(address))
            {
                MessageBox.Show("Please fill in all required fields.");
                return;
            }
            if (!phone.All(char.IsDigit) || phone.Length != 11)
            {
                MessageBox.Show("Phone number must be 11 digits and contain only numbers.");
                return;
            }
            BeneficiaryBL b = new BeneficiaryBL(fullName, dobFormatted, gender, phone, address);
            BeneficiaryDL.AddBeneficiary(b);
            MessageBox.Show("Beneficiary added successfully!");
        }

        private void AddDonationBeneficiary_Load(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
