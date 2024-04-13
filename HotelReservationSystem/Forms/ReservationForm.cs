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
    public partial class ReservationForm : Form
    {
        private readonly ReservationController reservationController;
        private Reservation selectedReservation;

        public ReservationForm()
        {
            selectedReservation = new Reservation();
            InitializeComponent();
            DisplayData();
        }

       
        private void ReservationForm_Load(object sender, EventArgs e)
        {
            insertButton.Text = "Insert";
            editButton.Text = "Edit";
            deleteButton.Text = "Delete";
            searchButton.Text = "Search";
            infoLabel.Text = string.Empty;
        }

        public void DisplayData()
        {
            dataGridView1.DataSource = reservationController.GetReservations();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dataGridView1.Rows.Count)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                int reservationId;
                if (int.TryParse(row.Cells["Id"].Value.ToString(), out reservationId))
                {
                    selectedReservation = reservationController.GetById(reservationId);
                    if (selectedReservation != null)
                    {
                        //egnComboBox.Text = selectedReservation.Guest;
                        //employeeComboBox.Text = selectedReservation.Employee;
                        // cityComboBox.Text = selectedGuest.City;
                        // dateTimePicker1.Text = selectedReservation.ReservationDate;
                        guestNumberBox.Text = selectedReservation.GuestNumber.ToString();
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
