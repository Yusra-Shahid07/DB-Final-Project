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
    public partial class ForgotPassword : Form
    {
        public ForgotPassword()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string email = Email.Text.Trim();
            int userId = UserDL.GetUserIdByEmail(email);

            if (userId != -1)
            {
                MessageBox.Show("Email exists! UserID is: " + userId);
                this.Hide();
                ForogtPassword2 password2 = new ForogtPassword2(userId);
                password2.ShowDialog();
            }
            else
            {
                MessageBox.Show("Email not found.");
            }
        }

        private void ForgotPassword_Load(object sender, EventArgs e)
        {

        }
    }
}
