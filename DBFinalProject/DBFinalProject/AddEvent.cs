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
    public partial class AddEvent : Form
    {
        public AddEvent()
        {
            InitializeComponent();
            LoadEditionIds();
            LoadCategories();
        }
        private void LoadEditionIds()
        {
            DataTable sellers = EditionsDL.GetAllSellerIds();
            EditionId.Items.Clear();
            foreach (DataRow row in sellers.Rows)
            {
                EditionId.Items.Add(row["SellerId"].ToString());
            }
        }
        private void LoadCategories()
        {
            DataTable categories = EventCategoryDL.GetAllCategories(); 
            CategoryID.Items.Clear();
            foreach (DataRow row in categories.Rows)
            {
                CategoryID.Items.Add(row["CategoryName"].ToString());
            }
        }
        private void button8_Click(object sender, EventArgs e)
        {
            bool check1 = false;
            string name = EventName.Text.Trim();
            string dateStr = dateTimePicker1.Text.Trim();
            string location = Location.Text.Trim();
            string categoryName = CategoryID.Text.Trim();

            string editionIdStr = EditionId.Text.Trim();
            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(location) || string.IsNullOrEmpty(categoryName))
            {
                MessageBox.Show("Please fill all fields.");
                return;
            }
            check1 = EventBL.IsAllAlphabetsOrSpace(name);
            if (!check1)
            {
                MessageBox.Show("Event name must contain only alphabets and spaces.");
                return;
            }
            if (!DateTime.TryParse(dateStr, out DateTime date))
            {
                MessageBox.Show("Invalid date format.");
                return;
            }
            if (!int.TryParse(editionIdStr, out int editionId))
            {
                MessageBox.Show("Invalid Edition ID.");
                return;
            }
            int categoryId = EventCategoryDL.GetCategoryIdByName(categoryName); // You’ll define this function
            if (categoryId == -1)
            {
                MessageBox.Show("Category not found.");
                return;
            }
            if (editionId == -1 || categoryId == -1)
            {
                MessageBox.Show("Invalid Edition or Campaign ID.");
                return;
            }
            EventBL Event=new EventBL(name,date,editionId,location,categoryId);
            EventDL.AddEvent(Event);
            MessageBox.Show("Event added successfully!");
        }

        private void AddEvent_Load(object sender, EventArgs e)
        {

        }
    }
}