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

namespace DBFinalProject
{
    public partial class ViewFeedBack : Form
    {
        public ViewFeedBack()
        {
            InitializeComponent();
            LoadGrid();
        }
        public void LoadGrid()
        {
            dataGridView1.DataSource = FeedbackDL.ShowAllFeedbacks();
        }
        private void button11_Click(object sender, EventArgs e)
        {
            this.Hide();
            HeadDashboard h = new HeadDashboard();
            h.Show();
        }

        private void ViewFeedBack_Load(object sender, EventArgs e)
        {

        }
    }
}
