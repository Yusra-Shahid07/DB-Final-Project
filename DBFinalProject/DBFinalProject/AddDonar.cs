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
using System.Xml.Linq;
using DBFinalProject.DL;

namespace DBFinalProject
{
    public partial class AddDonar : Form
    {
        public AddDonar()
        {
            InitializeComponent();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            string name = fullname.Text.Trim();
            string email = Email.Text.Trim();
            string phone = Phone.Text.Trim();
            DateTime date = dateTimePicker1.Value;
            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(phone))
            {
                MessageBox.Show("Please fill all fields.");
                return;
            }
            if (!email.Contains("@") || !email.Contains("."))
            {
                MessageBox.Show("Invalid email format.");
                return;
            }
            if (!phone.All(char.IsDigit) || phone.Length != 11)
            {
                MessageBox.Show("Phone must be 11 digits and numeric.");
                return;
            }
            DonorBL donor = new DonorBL(name,email,phone,date);
            bool isInserted = DonorDL.AddDonor(donor);
            if (isInserted)
            {
                MessageBox.Show("Donor added successfully!");
            }
            else
            {
                MessageBox.Show("Failed to add donor.");
            }
        }

        private void AddDonar_Load(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            signin s=new signin();
            s.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            addDonation addDonation = new addDonation();
            addDonation.Show();
        }
    }
}
