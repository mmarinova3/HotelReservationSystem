using HotelReservationSystem.Controller;
using HotelReservationSystem.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace HotelReservationSystem.Forms
{
    public partial class RoomCategoryForm : Form
    {
        private readonly RoomCategoryController roomCategoryController;
        private RoomCategory selectedRoom;

        public RoomCategoryForm()
        {
            roomCategoryController = new RoomCategoryController();
            InitializeComponent();
            DisplayData();
        }
      

        private void RoomCategoryForm_Load(object sender, EventArgs e)
        {
            insertButton.Text = "Insert";
            editButton.Text = "Edit";
            deleteButton.Text = "Delete";
            infoLabel.Text = string.Empty;
        }


        public void DisplayData()
        {
            dataGridView1.DataSource = roomCategoryController.GetCategories();

        }

        private void insertButton_Click(object sender, EventArgs e)
        {
            try
            {
                string categoryName = nameBox.Text;

                if (string.IsNullOrEmpty(categoryName) || string.IsNullOrEmpty(capacityBox.Text))
                {
                    infoLabel.Text = "Fields cannot be empty";
                    return;
                }

                if (!Regex.IsMatch(categoryName, @"^[a-zA-Z\s]+$"))
                {
                    infoLabel.Text = "Category name should contain only letters.";
                    return;
                }

                int maxCapacity;

                if (!int.TryParse(capacityBox.Text, out maxCapacity))
                {
                    infoLabel.Text = "Invalid capacity value.";
                    return;
                }

                RoomCategory roomCategory = new RoomCategory
                {
                    Id =1,
                    Name = categoryName,
                    MaxCapacity = maxCapacity
                };


                if (roomCategoryController.Save(roomCategory))
                {
                    infoLabel.Text = "Room category inserted successfully.";
                    DisplayData();
                    ClearInputs();
                }
                else
                {
                    infoLabel.Text = "Failed to insert room category.";
                }
            }
            catch (Exception ex)
            {
                infoLabel.Text = $"Error: {ex.Message}";
            }
        }

        

        private void editButton_Click(object sender, EventArgs e)
        {
            if (selectedRoom != null)
            {
                try
                {
                    string categoryName = nameBox.Text;

                    if (string.IsNullOrEmpty(categoryName) || string.IsNullOrEmpty(capacityBox.Text))
                    {
                        infoLabel.Text = "Fields cannot be empty";
                        return;
                    }

                    if (!Regex.IsMatch(categoryName, @"^[a-zA-Z\s]+$"))
                    {
                        infoLabel.Text = "Category name should contain only letters.";
                        return;
                    }

                    int maxCapacity;

                    if (!int.TryParse(capacityBox.Text, out maxCapacity))
                    {
                        infoLabel.Text = "Invalid capacity value.";
                        return;
                    }

                    selectedRoom.Name = categoryName;
                    selectedRoom.MaxCapacity = maxCapacity;

                    if (roomCategoryController.Update(selectedRoom.Id, selectedRoom))
                    {
                        infoLabel.Text = "Room category updated successfully.";
                        DisplayData();
                    }
                    else
                    {
                        infoLabel.Text = "Failed to update room category.";
                    }
                }
                catch (Exception ex)
                {
                    infoLabel.Text = $"Error: {ex.Message}";
                }
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (selectedRoom != null)
            {
                try
                {
                    if (roomCategoryController.Delete(selectedRoom.Id))
                    {
                        infoLabel.Text = "Room category deleted successfully.";
                        DisplayData();
                        ClearInputs();
                    }
                    else
                    {
                        infoLabel.Text = "Failed to delete room category.";
                    }
                }
                catch (Exception ex)
                {
                    infoLabel.Text = $"Error: {ex.Message}";
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dataGridView1.Rows.Count)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                int categoryId;
                if (int.TryParse(row.Cells["Id"].Value.ToString(), out categoryId))
                {
                    selectedRoom = roomCategoryController.GetById(categoryId);
                    if (selectedRoom != null)
                    {
                        nameBox.Text = selectedRoom.Name;
                        capacityBox.Text = selectedRoom.MaxCapacity.ToString();
                    }
                }
            }
        }

        private void ClearInputs()
        {
            nameBox.Text = string.Empty;
            capacityBox.Text = string.Empty;
        }

    }
}
