using HotelReservationSystem.Controller;
using HotelReservationSystem.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace HotelReservationSystem.Forms
{
    public partial class GuestForm : Form
    {
        private readonly GuestController guestController;
        private readonly CityController cityController;
        private Guest selectedGuest;

        public GuestForm()
        {
            guestController = new GuestController();
            cityController = new CityController();
            InitializeComponent();
            DisplayData();
            FillCityComboBox();
        }

        private void GuestForm_Load(object sender, EventArgs e)
        {
            insertButton.Text = "Insert";
            editButton.Text = "Edit";
            deleteButton.Text = "Delete";
            searchButton.Text = "Search";
            infoLabel.Text = string.Empty;

        }

        private void FillCityComboBox()
        {
            List<City> cities = cityController.GetCities();
            cityComboBox.DataSource = cities;
            cityComboBox.DisplayMember = "CityName"; 
            cityComboBox.ValueMember = "Id"; 
        }


        public void DisplayData()
        {
            var guests = guestController.GetGuests(); 

            dataGridView1.Columns.Clear();

    
            dataGridView1.Columns.Add("EGN", "EGN");
            dataGridView1.Columns.Add("Name", "Name");
            dataGridView1.Columns.Add("CityName", "City");
            dataGridView1.Columns.Add("Address", "Address");
            dataGridView1.Columns.Add("MobileNumber", "Mobile Number");

            foreach (var guest in guests)
            {
                dataGridView1.Rows.Add(guest.EGN, guest.Name, guest.City.CityName, guest.Address, guest.MobileNumber);
            }
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dataGridView1.Rows.Count)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                string guestId = row.Cells["EGN"].Value.ToString(); 
                selectedGuest = guestController.GetById(guestId);
                if (selectedGuest != null)
                {
                    egnBox.Text = selectedGuest.EGN;
                    nameBox.Text = selectedGuest.Name;
                    cityComboBox.SelectedValue = selectedGuest.City.Id;
                    addressBox.Text = selectedGuest.Address;
                    phoneBox.Text = selectedGuest.MobileNumber;
                }
            }
        }

        private bool ValidateGuestInfo()
        {
            if (egnBox.Text.Length != 10 || !egnBox.Text.All(char.IsDigit))
            {
                infoLabel.Text = "Invalid EGN";
                return false;
            }

            if (!string.IsNullOrWhiteSpace(nameBox.Text))
            {
                string namePattern = @"^[A-Z][a-z]*(?:[ -][A-Z][a-z]*)*$";
                if (string.IsNullOrWhiteSpace(nameBox.Text) || !Regex.IsMatch(nameBox.Text, namePattern))
                {
                    infoLabel.Text = "Name must start with an uppercase letter, contain only letters, spaces or hyphens, and each word must start with an uppercase letter.";
                    return false;
                }
            }
            else
            {
                MessageBox.Show("Name cannot be empty.", "Invalid Name", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (string.IsNullOrWhiteSpace(phoneBox.Text) || phoneBox.Text.Length != 10 || !phoneBox.Text.All(char.IsDigit))
            {
                infoLabel.Text = "Invalid Mobile Number";
                return false;
            }

            return true;
        }

        private void insertButton_Click(object sender, EventArgs e)
        {
            if (guestController.GetById(egnBox.Text) != null)
            {
                infoLabel.Text = "The guest is already in the system";
                return;
            }

            if (ValidateGuestInfo())
            {
                City selectedCity = (City)cityComboBox.SelectedItem;

                Guest newGuest = new Guest
                {
                    EGN = egnBox.Text,
                    Name = nameBox.Text,
                    City = selectedCity,
                    Address = addressBox.Text,
                    MobileNumber = phoneBox.Text
                };

                if (guestController.Save(newGuest))
                {
                    infoLabel.Text = "Guest saved successfully.";
                    DisplayData();
                }
                else
                {
                    infoLabel.Text = "Failed to save guest.";
                }
            }
        }


        private void editButton_Click(object sender, EventArgs e)
        {
            if (selectedGuest != null)
            {
                if (ValidateGuestInfo())
                {
                    selectedGuest.EGN = egnBox.Text;
                    selectedGuest.Name = nameBox.Text;
                    selectedGuest.City = (City)cityComboBox.SelectedItem;
                    selectedGuest.Address = addressBox.Text;
                    selectedGuest.MobileNumber = phoneBox.Text;

                    if (guestController.Update(selectedGuest.EGN, selectedGuest))
                    {
                        MessageBox.Show("Guest updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        DisplayData();
                    }
                    else
                    {
                        MessageBox.Show("Failed to update guest.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a guest to edit.", "No Guest Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (selectedGuest != null)
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete this guest?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    if (guestController.Delete(selectedGuest.EGN))
                    {
                        MessageBox.Show("Guest deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        DisplayData();
                    }
                    else
                    {
                        MessageBox.Show("Failed to delete guest.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a guest to delete.", "No Guest Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void searchButton_Click(object sender, EventArgs e)
        {

        }

       
    }
}
