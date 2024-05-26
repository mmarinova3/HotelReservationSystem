using HotelReservationSystem.Controller;
using HotelReservationSystem.Entity;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace HotelReservationSystem.Forms
{
    public partial class RoomForm : Form
    {
        private readonly RoomController roomController;
        private readonly RoomCategoryController roomCategoryController;
        private readonly BathroomController bathroomController;

        private Room selectedRoom;
        public RoomForm()
        {
            roomController = new RoomController();
            roomCategoryController = new RoomCategoryController();
            bathroomController = new BathroomController();
            InitializeComponent();
            DisplayData();
            FillRoomCategoryComboBox();
            FillBathroomComboBox();
        }

        private void RoomForm_Load(object sender, EventArgs e)
        {
            insertButton.Text = "Insert";
            deleteButton.Text = "Delete";
            searchButton.Text = "Search";
            infoLabel.Text = string.Empty;
        }

        private void FillRoomCategoryComboBox()
        {
            List<RoomCategory> categories = roomCategoryController.GetCategories();
            categoryComboBox.DataSource = categories;
            categoryComboBox.DisplayMember = "Name";
            categoryComboBox.ValueMember = "Id";
        }

        private void FillBathroomComboBox()
        {
            List<Bathroom> bathrooms = bathroomController.GetBathrooms();
            bathroomComboBox.DataSource = bathrooms;
            bathroomComboBox.DisplayMember = "Id";
            bathroomComboBox.ValueMember = "Id";
        }


        public void DisplayData()
        {
            if (roomController != null)
            {
                var rooms = roomController.GetRooms();
                dataGridView1.Rows.Clear();
                dataGridView1.Columns.Clear();
                dataGridView1.Columns.Add("Id", "Room Number");
                dataGridView1.Columns.Add("Floor", "Floor");
                dataGridView1.Columns.Add("RoomCategory", "Category Type");
                dataGridView1.Columns.Add("Bathroom", "Bathroom (is shared?)");

                foreach (var room in rooms)
                {
                    dataGridView1.Rows.Add(room.Id, room.Floor, room.RoomCategory.Name, room.Bathroom.IsShared);
                }
            }
            else
            {
                Console.WriteLine("RoomController is null.");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dataGridView1.Rows.Count)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                int roomId;
                if (int.TryParse(row.Cells["Id"].Value.ToString(), out roomId))
                {
                    selectedRoom = roomController.GetById(roomId);
                    if (selectedRoom != null)
                    {
                        roomTextBox.Text=selectedRoom.Id.ToString();
                        floorTextBox.Text=selectedRoom.Floor.ToString();
                        categoryComboBox.SelectedValue= selectedRoom.RoomCategory.Id;
                        bathroomComboBox.SelectedValue=selectedRoom.Bathroom.Id;
                    }
                }
            }
        }

        private void insertButton_Click(object sender, EventArgs e)
        {
            RoomCategory selectedRoomCategory = (RoomCategory)categoryComboBox.SelectedItem;
            Bathroom selectedBathroom = (Bathroom)bathroomComboBox.SelectedItem;

            Room newRoom = new Room
            {
                Id = int.Parse(roomTextBox.Text),
                Floor = int.Parse(floorTextBox.Text),
                RoomCategory = selectedRoomCategory,
                Bathroom = selectedBathroom
            };

            if (roomController.Save(newRoom))
            {
                infoLabel.Text = "Room saved successfully.";
                DisplayData();
            }
            else
            {
                infoLabel.Text = "Failed to save room.";
            }
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            if (selectedRoom != null)
            {
                selectedRoom.Id = int.Parse(roomTextBox.Text);
                selectedRoom.Floor = int.Parse(floorTextBox.Text);
                selectedRoom.RoomCategory = (RoomCategory)categoryComboBox.SelectedItem;
                selectedRoom.Bathroom = (Bathroom)bathroomComboBox.SelectedItem;

                if (roomController.Update(selectedRoom.Id, selectedRoom))
                {
                    MessageBox.Show("Room updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DisplayData();
                }
                else
                {
                    MessageBox.Show("Failed to update room.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
            else
            {
                MessageBox.Show("Please select a room to edit.", "No Room Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (selectedRoom != null)
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete this room?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    if (roomController.Delete(selectedRoom.Id))
                    {
                        MessageBox.Show("Room deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        DisplayData();
                    }
                    else
                    {
                        MessageBox.Show("Failed to delete room.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a room to delete.", "No Room Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {

        }

        
    }
}
