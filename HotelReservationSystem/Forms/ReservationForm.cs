using HotelReservationSystem.Controller;
using HotelReservationSystem.Entity;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace HotelReservationSystem.Forms
{
    public partial class ReservationForm : Form
    {
        private readonly ReservationController reservationController;
        private readonly GuestController guestController;
        private readonly EmployeeController employeeController;


        private Reservation selectedReservation;

        public ReservationForm()
        {
            reservationController = new ReservationController();
            guestController = new GuestController();
            employeeController = new EmployeeController();
            InitializeComponent();
            DisplayData();
            FillGuestComboBox();
            FillEmployeeComboBox();
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

        private void FillGuestComboBox()
        {
            List<Guest> guests = guestController.GetGuests();
            egnComboBox.DataSource = guests;
            egnComboBox.DisplayMember = "Name";
            egnComboBox.ValueMember = "EGN";
        }

        private void FillEmployeeComboBox()
        {
            List<Employee> employees = employeeController.GetEmployees();
            employeeComboBox.DataSource = employees;
            employeeComboBox.DisplayMember = "Name";
            employeeComboBox.ValueMember = "Id";
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
                        egnComboBox.SelectedValue = selectedReservation.Guest.EGN;
                        employeeComboBox.SelectedValue = selectedReservation.Employee.Id;
                        dateTimePicker1.Value = selectedReservation.ReservationDate;
                        guestNumberBox.Text = selectedReservation.AdultsNumber.ToString();
                    }
                }
            }
        }

        private void insertButton_Click(object sender, EventArgs e)
        { 
            Guest selectedGuest = (Guest)egnComboBox.SelectedItem;
            Employee selectedEmployee = (Employee)employeeComboBox.SelectedItem;
               
            Reservation newReservation = new Reservation
            {
                Guest = selectedGuest,
                Employee = selectedEmployee,
                ReservationDate = dateTimePicker1.Value,
                AdultsNumber = int.Parse(guestNumberBox.Text)
            };

            if (reservationController.Save(newReservation))
            {
                infoLabel.Text = "Reservation saved successfully.";
                DisplayData();
            }
            else
            {
                infoLabel.Text = "Failed to save reservation.";
            }
            
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            if (selectedReservation != null)
            {
                selectedReservation.Guest = (Guest)egnComboBox.SelectedItem;
                selectedReservation.Employee = (Employee)employeeComboBox.SelectedItem;
                selectedReservation.ReservationDate = dateTimePicker1.Value;
                selectedReservation.AdultsNumber = int.Parse(guestNumberBox.Text);

                if (reservationController.Update(selectedReservation.Id, selectedReservation))
                {
                    infoLabel.Text = "Reservation updated successfully.";
                    DisplayData();
                }
                else
                {
                    infoLabel.Text = "Failed to update reservation.";
                }
            }
            else
            {
                MessageBox.Show("Please select a reservation to edit.", "No Reservation Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (selectedReservation != null)
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete this reservation?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    if (reservationController.Delete(selectedReservation.Id))
                    {
                        infoLabel.Text = "Reservation deleted successfully.";
                        DisplayData();
                    }
                    else
                    {
                        infoLabel.Text = "Failed to delete reservation.";
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a reservation to delete.", "No Reservation Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void searchButton_Click(object sender, EventArgs e)
        {

        }

      
    }
}
