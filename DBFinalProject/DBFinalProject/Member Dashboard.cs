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
    public partial class Member_Dashboard : Form
    {
        public Member_Dashboard()
        {
            InitializeComponent();
        }

        private void Member_Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegisterMember member = new RegisterMember();
            member.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
