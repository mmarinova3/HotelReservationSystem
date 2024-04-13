using HotelReservationSystem.Controller;
using HotelReservationSystem.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelReservationSystem.Forms
{
    public partial class GuestForm : Form
    {
        private readonly GuestController guestController;
        private Guest selectedGuest;

        public GuestForm()
        {
            selectedGuest = new Guest();
            InitializeComponent();
            DisplayData();
        }

        private void GuestForm_Load(object sender, EventArgs e)
        {
            insertButton.Text = "Insert";
            editButton.Text = "Edit";
            deleteButton.Text = "Delete";
            searchButton.Text = "Search";
            infoLabel.Text = string.Empty;
        }

        public void DisplayData()
        {
            dataGridView1.DataSource = guestController.GetGuests();
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dataGridView1.Rows.Count)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                int guestId;
                if (int.TryParse(row.Cells["Id"].Value.ToString(), out guestId))
                {
                    selectedGuest = guestController.GetById(guestId);
                    if (selectedGuest != null)
                    {
                        egnBox.Text = selectedGuest.EGN;
                        nameBox.Text = selectedGuest.Name;
                        //   cityComboBox.Text = selectedGuest.City;
                        addressBox.Text = selectedGuest.Address;
                        phoneBox.Text = selectedGuest.MobileNumber;
                    }
                }
            }
        }

        private void insertButton_Click(object sender, EventArgs e)
        {

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

       
    }
}
