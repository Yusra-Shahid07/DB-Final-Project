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
    public partial class Events : Form
    {
        public Events()
        {
            InitializeComponent();
            LoadGrid(); 
        }
        public void LoadGrid()
        {
            dataGridView1.DataSource = EventDL.ShowAllEvents();
        }
        private void Events_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddEvent addEvent = new AddEvent();
           
            addEvent.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
         
            //if (dataGridView1.SelectedRows.Count == 0)
            //{
            //    MessageBox.Show("Please select an event from the grid.");
            //    return;
            //}

            //DataGridViewRow row = dataGridView1.SelectedRows[0];
            //int eventId = Convert.ToInt32(row.Cells["EventID"].Value);
            //string name = row.Cells["EventName"].Value.ToString();
            //DateTime date = Convert.ToDateTime(row.Cells["EventDate"].Value);
            //string location = row.Cells["Location"].Value.ToString();
            //int editionId = Convert.ToInt32(row.Cells["EditionID"].Value);
            //int categoryId = Convert.ToInt32(row.Cells["CategoryID"].Value);

            //// Open AddEvent form in update mode with selected data
            //AddEvent updateForm = new UpdateEvent(eventId, name, date, location, editionId, categoryId);
            //updateForm.ShowDialog();

            //// Optional: reload grid after update
            //LoadGrid();
      
        }

        private void button7_Click(object sender, EventArgs e)
        {

            this.Hide();
            LeadDashboard lead=new LeadDashboard();
            lead.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select an event to delete.");
                return;
            }

            DialogResult result = MessageBox.Show("Are you sure you want to delete this event?", "Confirm", MessageBoxButtons.YesNo);
            if (result == DialogResult.No) return;

            int eventId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["EventId"].Value);
            EventDL.DeleteEvent(eventId);
            MessageBox.Show("Event deleted successfully.");
            LoadGrid(); // Refresh grid

        }
    }
}
