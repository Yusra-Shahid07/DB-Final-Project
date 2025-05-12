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
using DBFinalProject.bl;
namespace DBFinalProject
{
    public partial class RegisterMember : Form
    {
        public RegisterMember()
        {
            InitializeComponent();
        }
        private void LoadEligibleUserIds()
        {
            DataTable users = UserDL.GetEligibleUserIds(); 
            UserID.Items.Clear();
            foreach (DataRow row in users.Rows)
            {
                UserID.Items.Add(row["UserID"].ToString());
            }
        }
        private void button8_Click(object sender, EventArgs e)
        {
            string fullName = Fullname.Text.Trim();
            DateTime joinDateStr = dateTimePicker1.Value.Date;
            string userIdStr = UserID.Text.Trim();
            string dobFormatted = joinDateStr.ToString("yyyy-MM-dd");
            if (string.IsNullOrEmpty(fullName) || string.IsNullOrEmpty(userIdStr))
            {
                MessageBox.Show("Please fill all fields.");
                return;
            }

            if (!VolunteerBL.IsAllAlphabetsOrSpace(fullName))
            {
                MessageBox.Show("Full name must contain only alphabets and spaces.");
                return;
            }

            if (!DateTime.TryParse(dobFormatted, out DateTime joinDate))
            {
                MessageBox.Show("Invalid join date.");
                return;
            }

            if (!int.TryParse(userIdStr, out int userId))
            {
                MessageBox.Show("Invalid user ID.");
                return;
            }

            VolunteerBL volunteer = new VolunteerBL(fullName, dobFormatted, userId);
            VolunteerDL.AddVolunteer(volunteer);
            MessageBox.Show("Volunteer registered successfully with status 'Pending'");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Member_Dashboard member_Dashboard = new Member_Dashboard();
            member_Dashboard.Show();
            this.Hide();
        }

        private void RegisterMember_Load(object sender, EventArgs e)
        {
            LoadEligibleUserIds();
        }
    }
    
}
