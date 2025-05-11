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
    public partial class AssignTasks : Form
    {
        public AssignTasks()
        {
            InitializeComponent();
            
        }
        private void LoadVolunteerCombo()
        {
            DataTable dt = VolunteerDL.GetAllVolunteerIDs();
            VolunteerID.Items.Clear();
            foreach (DataRow row in dt.Rows)
            {
                VolunteerID.Items.Add($"{row["VolunteerID"]} - {row["FullName"]}");
            }
        }

        private void LoadAssignedByCombo()
        {
            DataTable dt = VolunteerTaskDL.GetHeadLeadList();
            AssignedByCombo.Items.Clear();
            foreach (DataRow row in dt.Rows)
            {
                AssignedByCombo.Items.Add($"{row["UserID"]} - {row["Username"]}");
            }
        }
        private void button8_Click(object sender, EventArgs e)
        {
            string volunteerStr = VolunteerID.Text.Trim();
            string assignedByStr = AssignedByCombo.Text.Trim();
            string title = TaskTitle.Text.Trim();
            string description = TaskDescription.Text.Trim();
            string deadlineStr = Deadline.Text.Trim();
            if (string.IsNullOrEmpty(volunteerStr) || string.IsNullOrEmpty(assignedByStr) ||
                string.IsNullOrEmpty(title) || string.IsNullOrEmpty(description))
            {
                MessageBox.Show("Please fill all fields.");
                return;
            }

            if (!DateTime.TryParse(deadlineStr, out DateTime deadline))
            {
                MessageBox.Show("Invalid deadline.");
                return;
            }

            int volunteerId = int.Parse(volunteerStr.Split('-')[0].Trim());
            int assignedById = int.Parse(assignedByStr.Split('-')[0].Trim());
            VolunteerTaskBL volunteer = new VolunteerTaskBL(volunteerId, assignedById, title, description, deadline);
            bool valid = VolunteerTaskDL.AddVolunteerTask(volunteer);
            if (valid)
            {
                MessageBox.Show("Task Assigned Successfully!");
            }
            else
            {
                MessageBox.Show("Failed to assign task.");
            }
        }

        private void AssignTasks_Load(object sender, EventArgs e)
        {
            LoadVolunteerCombo();
            LoadAssignedByCombo();
        }
    }
}
