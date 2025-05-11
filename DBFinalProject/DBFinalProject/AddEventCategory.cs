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
    public partial class AddEventCategory : Form
    {
        public AddEventCategory()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            string categoryName = CategoryName.Text.Trim();
            string description = Description.Text.Trim();
            bool check = EventCategoryBL.IsAllAlphabetsOrSpace(categoryName);
            EventCategoryBL newCategory = new EventCategoryBL(categoryName, description);
            if (check)
            {
                EventCategoryDL.AddEventCategory(newCategory);
                MessageBox.Show("Event category added successfully!");
            }
            else
            {
                MessageBox.Show("Category name must contain only alphabets and spaces.");
            }

        }

        private void AddEventCategory_Load(object sender, EventArgs e)
        {

        }
    }
}
