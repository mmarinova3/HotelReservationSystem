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
            checkBox1.Text = "Shared";
            infoLabel.Text = string.Empty;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
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

                string isShared = checkBox1.Checked ? "True" : "False";

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
            if (selectedBathroom != null)
            {
                selectedBathroom.Id = int.Parse(bathroomIdBox.Text);
                selectedBathroom.Floor = int.Parse(floorBox.Text);
                selectedBathroom.IsShared = checkBox1.Checked ? "True" : "False";

                if (bathroomController.UpdateBathroom(selectedBathroom.Id, selectedBathroom))
                {
                    MessageBox.Show("Bathroom updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DisplayData();
                }
                else
                {
                    MessageBox.Show("Failed to update Bathroom.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("Please select a Bathroom to edit.", "No Room Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (selectedBathroom == null)
            {
                infoLabel.Text = "Please select a Bathroom to delete.";
                return;
            }

            if (bathroomController.DeleteBathroom(selectedBathroom.Id))
            {
                infoLabel.Text = "Bathroom deleted successfully.";
                DisplayData();
            }
            else
            {
                infoLabel.Text = "Failed to delete Bathroom.";
            }
        }
        private void searchButton_Click(object sender, EventArgs e)
        {
            string bathroomNumberText = bathroomIdBox.Text.Trim();

            if (string.IsNullOrWhiteSpace(bathroomNumberText))
            {
                infoLabel.Text = "Bathroom Number cannot be empty.";
                return;
            }

            if (!int.TryParse(bathroomNumberText, out int bathroomNumber))
            {
                infoLabel.Text = "Invalid bathroom number format.";
                return;
            }

            Bathroom bathroom = bathroomController.SearchBathroomById(bathroomNumber);

            if (bathroom != null)
            {
                infoLabel.Text = $"Bathroom found: {bathroom.Id}";
                selectedBathroom = bathroom;

                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (Convert.ToInt32(row.Cells["Id"].Value) == bathroom.Id)
                    {
                        row.Selected = true;
                        dataGridView1.CurrentCell = row.Cells[0];
                        break;
                    }
                }
            }
            else
            {
                infoLabel.Text = "Bathroom not found.";
            }
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
                        checkBox1.Checked = selectedBathroom.IsShared.Equals("True", StringComparison.OrdinalIgnoreCase);
                    }
                }
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (selectedBathroom != null)
            {
                selectedBathroom.IsShared = checkBox1.Checked ? "True" : "False";
            }
        }

    }
}
