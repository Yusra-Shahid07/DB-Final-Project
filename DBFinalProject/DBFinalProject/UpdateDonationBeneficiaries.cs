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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DBFinalProject
{
    public partial class UpdateDonationBeneficiaries : Form
    {
        public UpdateDonationBeneficiaries()
        {
            InitializeComponent();
        }
        int beneficiaryId;

        public UpdateDonationBeneficiaries(int id, string fullName, DateTime dob, string gender, string phone, string address)
        {
            InitializeComponent();

            beneficiaryId = id;
            FullName.Text = fullName;
            dateTimePicker1.Value = dob;
            Gender.SelectedItem = gender;
            Phone.Text = phone;
            textBox1.Text = address;
            beneficiaryId= id;
        }
        private void UpdateDonationBeneficiaries_Load(object sender, EventArgs e)
        {

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
            BeneficiaryDL.UpdateBeneficiary(beneficiaryId, b);
            MessageBox.Show("Beneficiary updated successfully!");
        }
    }
}

