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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
namespace DBFinalProject
{
    public partial class AddEvent : Form
    {
        public AddEvent()
        {
            InitializeComponent();
            LoadEditionIds();
            LoadCompaignNames();
        }
        private void LoadEditionIds()
        {
            DataTable sellers = EditionDL.GetAllSellerIds();
            EditionId.Items.Clear();
            foreach (DataRow row in sellers.Rows)
            {
                EditionId.Items.Add(row["SellerId"].ToString());
            }
        }
        private void LoadCompaignNames()
        {
            DataTable sellers = CompaignDL.GetAllCompaignIds();
            EditionId.Items.Clear();
            foreach (DataRow row in sellers.Rows)
            {
                EditionId.Items.Add(row["SellerId"].ToString());
            }
        }
        private void button8_Click(object sender, EventArgs e)
        {
            bool check1 = false;
            string name = EventName.Text.Trim();
            string dateStr = dateTimePicker1.Text.Trim();
            string location = Location.Text.Trim();
            string compaignname = CompaignName.Text.Trim();
            string editionIdStr = EditionId.Text.Trim();
            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(location) || string.IsNullOrEmpty(compaignname))
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
            int compaignId = CompaignDL.GetCompaignIdByName(compaignname);
            if (compaignId == -1)
            {
                MessageBox.Show("Campaign not found.");
                return;
            }
            if (editionId == -1 || compaignId == -1)
            {
                MessageBox.Show("Invalid Edition or Campaign ID.");
                return;
            }
            EventDL.InsertEvent(name, date, location, compaignId, editionId);
            MessageBox.Show("Event added successfully!");
        }
    }
}