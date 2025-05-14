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

namespace DBFinalProject.Reports.VolunteerTask
{
    public partial class ComboVolunteerName : Form
    {
        public ComboVolunteerName()
        {
            InitializeComponent();
            LoadVolunteerNames();
        }
        private void LoadVolunteerNames()
        {
            DataTable volunteers = VolunteerDL.GetAllVolunteerNames();
            comboBox1.Items.Clear();
            foreach (DataRow row in volunteers.Rows)
            {
                comboBox1.Items.Add(row["FullName"].ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string fullName = comboBox1.SelectedItem.ToString();
            this.Hide();
            FormV form=new FormV(fullName);
            form.ShowDialog();
        }

        private void ComboVolunteerName_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            ReportMenu reportMenu = new ReportMenu();
            reportMenu.Show();
        }
    }
}
