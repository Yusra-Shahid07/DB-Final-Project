using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBFinalProject
{
    public partial class signin : Form
    {
        public signin()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = Username.Text.Trim();
            string password = Password.Text.Trim();
            string role = UserID.Text.Trim(); 
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(role))
            {
                MessageBox.Show("Please enter username, password, and role.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string query = $"SELECT COUNT(*) FROM users WHERE Username = '{username}' AND Password = '{password}' AND Role = '{role}'";

            object result = SQL_Helper.ExecuteScalor(query);
            int count = Convert.ToInt32(result);

            if (count == 1)
            {
                MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if(role=="Head")
                {
                    this.Hide();
                    HeadDashboard head = new HeadDashboard();
                    head.Show();
                }
                else if(role=="Lead")
                {
                    this.Hide();
                    LeadDashboard lead = new LeadDashboard();
                    lead.Show();
                }
                else if(role=="Member")
                {
                    this.Hide();
                    Member_Dashboard member = new Member_Dashboard();
                    member.Show();
                }
            }
            else
            {
                MessageBox.Show("Invalid credentials or role.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            signup signup = new signup();
            signup.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddDonar donar = new AddDonar();
            donar.Show();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            ForgotPassword forgotPassword = new ForgotPassword();
            forgotPassword.Show();
        }
    }
}
