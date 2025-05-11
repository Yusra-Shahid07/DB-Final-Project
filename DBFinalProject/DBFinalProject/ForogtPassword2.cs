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
    public partial class ForogtPassword2 : Form
    {
        int userid;
        public ForogtPassword2(int userid)
        {
            InitializeComponent();
            this.userid = userid;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string newPassword =Password.Text.Trim();
            string confirmPassword = ConfirmPassword.Text.Trim();

            if (newPassword == confirmPassword)
            {
                bool updated = UserDL.UpdatePassword(userid, newPassword);

                if (updated)
                {
                    MessageBox.Show("Password successfully updated!");
                    this.Close(); // or go to login form
                }
                else
                {
                    MessageBox.Show("Failed to update password.");
                }
            }
            else
            {
                MessageBox.Show("Passwords do not match.");
            }
        }
    }
}
