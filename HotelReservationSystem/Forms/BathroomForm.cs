using HotelReservationSystem.Controller;
using HotelReservationSystem.Entity;
using System;
using System.Linq;
using System.Windows.Forms;

namespace HotelReservationSystem.Forms
{
    public partial class BathroomForm : Form
    {

        private readonly BathroomController bathroomController;
        private Bathroom selectedBathroom; 

        public BathroomForm()
        {
            bathroomController = new BathroomController();
            InitializeComponent();
            DisplayData();
        }


        private void BathroomForm_Load(object sender, EventArgs e)
        {
            insertButton.Text = "Insert";
            editButton.Text = "Edit";
            deleteButton.Text = "Delete";
            searchButton.Text = "Search";
            infoLabel.Text = string.Empty;

            isSharedComboBox.Items.Add("Yes");
            isSharedComboBox.Items.Add("No");
        }

        public void DisplayData()
        {
            dataGridView1.DataSource = bathroomController.GetBathrooms();

        }

        private void insertButton_Click(object sender, EventArgs e)
        {
            try
            {
                int id;
                if (!int.TryParse(bathroomIdBox.Text, out id))
                {
                    infoLabel.Text = "Invalid bathroom number.";
                    return;
                }

                if (bathroomController.GetBathrooms().Any(b => b.Id == id))
                {
                    infoLabel.Text = "Bathroom is already in the system.";
                    return;
                }

                int floor;
                if (!int.TryParse(floorBox.Text, out floor))
                {
                    infoLabel.Text = "Invalid floor value.";
                    return;
                }

                bool isShared = isSharedComboBox.SelectedItem?.ToString().ToLower() == "yes";

                Bathroom bathroom = new Bathroom
                {
                    Id = id,
                    Floor = floor,
                    IsShared = isShared
                };

                if (bathroomController.SaveBathroom(bathroom))
                {
                    infoLabel.Text = "Bathroom inserted successfully.";
                    DisplayData();
                }
                else
                {
                    infoLabel.Text = "Failed to insert bathroom.";
                }
            }
            catch (Exception ex)
            {
                infoLabel.Text = $"Error: {ex.Message}";
            }
        }







        private void editButton_Click(object sender, EventArgs e)
        {

        }

        private void deleteButton_Click(object sender, EventArgs e)
        {

        }

        private void searchButton_Click(object sender, EventArgs e)
        {

        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dataGridView1.Rows.Count)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                int id;
                if (int.TryParse(row.Cells["Id"].Value.ToString(), out id))
                {
                    selectedBathroom = bathroomController.GetBathrooms().Find(c => c.Id == id);
                    if (selectedBathroom != null)
                    {
                        bathroomIdBox.Text = selectedBathroom.Id.ToString();
                        floorBox.Text = selectedBathroom.Floor.ToString();
                        isSharedComboBox.SelectedItem = selectedBathroom.IsShared ? "Yes" : "No";
                    }
                }
            }
        }

    }
}
