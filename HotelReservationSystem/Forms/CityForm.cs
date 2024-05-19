using HotelReservationSystem.Controller;
using HotelReservationSystem.Entity;
using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace HotelReservationSystem.Forms
{
    public partial class CityForm : Form
    {
        private readonly CityController cityController;
        private City selectedCity;

        public CityForm()
        {
            cityController = new CityController();
            InitializeComponent();
            DisplayData();
        }

        private void CityForm_Load(object sender, EventArgs e)
        {
            insertButton.Text = "Insert";
            editButton.Text = "Edit";
            deleteButton.Text = "Delete";
            searchButton.Text = "Search";
            infoLabel.Text = string.Empty;
        }

        public void DisplayData()
        {
            dataGridView1.DataSource = cityController.GetCities();

        }

        private void InsertButton_Click(object sender, EventArgs e)
        {
            string cityName = cityNameBox.Text.Trim();

            if (string.IsNullOrWhiteSpace(cityName))
            {
                infoLabel.Text = "City name cannot be empty.";
                return;
            }

            if (!Regex.IsMatch(cityName, @"^[a-zA-Z\s]+$"))
            {
                infoLabel.Text = "City name should contain only letters.";
                return;
            }

            City city = new City { CityName = cityName };

            if (cityController.SaveCity(city))
            {
                infoLabel.Text = "City inserted successfully.";
                DisplayData();
            }
            else
            {
                infoLabel.Text = "Failed to insert city.";
            }
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            if (selectedCity == null)
            {
                infoLabel.Text = "Please select a city to edit.";
                return;
            }

            string newCityName = cityNameBox.Text.Trim();

            if (string.IsNullOrWhiteSpace(newCityName))
            {
                infoLabel.Text = "City name cannot be empty.";
                return;
            }

            if (!Regex.IsMatch(newCityName, @"^[a-zA-Z\s]+$"))
            {
                infoLabel.Text = "City name should contain only letters.";
                return;
            }

            selectedCity.CityName = newCityName;

            if (cityController.UpdateCity(selectedCity.Id, selectedCity))
            {
                infoLabel.Text = "City updated successfully.";
                DisplayData();
            }
            else
            {
                infoLabel.Text = "Failed to update city.";
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (selectedCity == null)
            {
                infoLabel.Text = "Please select a city to delete.";
                return;
            }

            if (cityController.DeleteCity(selectedCity.Id))
            {
                infoLabel.Text = "City deleted successfully.";
                DisplayData();
            }
            else
            {
                infoLabel.Text = "Failed to delete city.";
            }
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            string cityName = cityNameBox.Text.Trim();

            if (string.IsNullOrWhiteSpace(cityName))
            {
                infoLabel.Text = "City name cannot be empty.";
                return;
            }

            City city = cityController.SearchCityByName(cityName);

            if (city != null)
            {
                infoLabel.Text = $"City found: {city.CityName}";
                cityNameBox.Text = city.CityName;
                selectedCity = city;

                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if ((int)row.Cells["Id"].Value == city.Id)
                    {
                        row.Selected = true;
                        dataGridView1.CurrentCell = row.Cells[0];
                        break;
                    }
                }
            }
            else
            {
                infoLabel.Text = "City not found.";
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dataGridView1.Rows.Count)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                int cityId = (int)row.Cells["Id"].Value;
                selectedCity = cityController.GetCities().Find(c => c.Id == cityId);
                if (selectedCity != null)
                {
                    cityNameBox.Text = selectedCity.CityName;
                }
            }
        }
    }
}
