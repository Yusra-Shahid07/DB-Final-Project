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
    public partial class signup : Form
    {
        public signup()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = Username.Text.Trim();
            string email = Email.Text.Trim();
            string phone = Phone.Text.Trim();
            string password = Password.Text.Trim();
            string role = Role.Text.Trim();

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(email) ||
                string.IsNullOrWhiteSpace(phone) || string.IsNullOrWhiteSpace(password) ||
                string.IsNullOrWhiteSpace(role))
            {
                MessageBox.Show("All fields are required.");
                return;
            }

            UserBL user = new UserBL(username, phone, password, email, role);

            if (!user.IsValidEmail(email))
            {
                MessageBox.Show("Invalid email format.");
                return;
            }

            if (!user.IsValidPassword(password))
            {
                MessageBox.Show("Password must be at least 8 characters and include a number and a letter.");
                return;
            }

            if (!user.IsValidPhone(phone))
            {
                MessageBox.Show("Phone must be in format 03xx-xxxxxxx.");
                return;
            }

            try
            {
                UserDL.AddUser(user);
                MessageBox.Show("User registered successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database error: " + ex.Message);
            }
        }
    }
}
