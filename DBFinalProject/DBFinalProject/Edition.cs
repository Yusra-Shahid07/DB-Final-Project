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
    public partial class Edition : Form
    {
        public Edition()
        {
            InitializeComponent();
        }

        private void Edition_Load(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            string yearStr = Year.Text.Trim();
            string description = Description.Text.Trim();

            // Validation
            if (string.IsNullOrEmpty(yearStr) || string.IsNullOrEmpty(description))
            {
                MessageBox.Show("Please fill in both Year and Description.");
                return;
            }

            if (!int.TryParse(yearStr, out int year) || year < 2000 || year > DateTime.Now.Year + 5)
            {
                MessageBox.Show("Please enter a valid year.");
                return;
            }

            EditionsBL edition = new EditionsBL(year, description);
            bool success = EditionsDL.AddEdition(edition);

            if (success)
            {
                MessageBox.Show("Edition added successfully!");
                Year.Clear();
                Description.Clear();
            }
            else
            {
                MessageBox.Show("Failed to add edition.");
            }
        }
    }
}
