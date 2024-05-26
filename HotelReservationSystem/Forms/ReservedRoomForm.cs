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
    public partial class ReservedRoomForm : Form
    {
        private readonly ReservedRoomController reservedRoomController;
        private readonly RoomController roomController;
        private readonly ReservationController reservationController;

        private ReservedRoom selectedReservedRoom; 

        public ReservedRoomForm()
        {
            reservedRoomController = new ReservedRoomController();
            roomController = new RoomController();
            reservationController = new ReservationController();

            InitializeComponent();
            DisplayData();
            FillRoomComboBox();
            FillReservationComboBox();
        }

        private void ReservedRoomForm_Load(object sender, EventArgs e)
        {
            insertButton.Text = "Insert";
            deleteButton.Text = "Delete";
            searchButton.Text = "Search";
            infoLabel.Text = string.Empty;
        }

        private void FillRoomComboBox()
        {
            List<Room> rooms = roomController.GetRooms();
            roomComboBox.DataSource = rooms;
            roomComboBox.DisplayMember = "Id";
            roomComboBox.ValueMember = "Id";
        }

        private void FillReservationComboBox()
        {
            List<Reservation> reservations = reservationController.GetReservations();
            reservationComboBox.DataSource = reservations;
            reservationComboBox.DisplayMember = "Id";
            reservationComboBox.ValueMember = "Id";
        }

        public void DisplayData()
        {
            if (reservedRoomController != null)
            {
                var reservedRooms = reservedRoomController.GetReservedRooms();
                dataGridView1.Columns.Clear();
                dataGridView1.Columns.Add("Reservation", "Reservation ID");
                dataGridView1.Columns.Add("Room", "Room Number");
                dataGridView1.Columns.Add("StartDate", "Check-in");
                dataGridView1.Columns.Add("EndDate", "Check-out");

                foreach (var reservedRoom in reservedRooms)
                {
                    dataGridView1.Rows.Add(reservedRoom.Reservation.Id,reservedRoom.Room.Id,reservedRoom.StartDate,reservedRoom.EndDate);
                }
            }
            else
            {
                Console.WriteLine("ReservedRoomController is null.");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dataGridView1.Rows.Count)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                int reservationId;
                int roomId;

                if (int.TryParse(row.Cells["reservationId"].Value.ToString(), out reservationId) && int.TryParse(row.Cells["roomId"].Value.ToString(), out roomId))
                {
                    selectedReservedRoom = reservedRoomController.GetById(reservationId, roomId);
                    if (selectedReservedRoom != null)
                    {
                        reservationComboBox.SelectedValue = selectedReservedRoom.Reservation.Id;
                        roomComboBox.SelectedValue = selectedReservedRoom.Room.Id;
                        startDateTimePicker.Value = selectedReservedRoom.StartDate;
                        endDateTimePicker.Value = selectedReservedRoom.EndDate;
                    }
                }
            }
        }

        private void insertButton_Click(object sender, EventArgs e)
        {
            Reservation selectedReservation = (Reservation)reservationComboBox.SelectedItem;
            Room selectedRoom = (Room)roomComboBox.SelectedItem;

            ReservedRoom newReservedRoom = new ReservedRoom
            {
                Reservation = selectedReservation,
                Room = selectedRoom,
                StartDate = startDateTimePicker.Value,
                EndDate = endDateTimePicker.Value
            };

            if (reservedRoomController.Save(newReservedRoom))
            {
                infoLabel.Text = "ReservedRoom saved successfully.";
                DisplayData();
            }
            else
            {
                infoLabel.Text = "Failed to save ReservedRoom.";
            }
        }

      
        private void deleteButton_Click(object sender, EventArgs e)
        {

            if (selectedReservedRoom != null)
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete this ReservedRoom?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    if (reservedRoomController.Delete(selectedReservedRoom.Reservation.Id,selectedReservedRoom.Room.Id))
                    {
                        infoLabel.Text = "ReservedRoom deleted successfully.";
                        DisplayData();
                    }
                    else
                    {
                        infoLabel.Text = "Failed to delete ReservedRoom.";
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a ReservedRoom to delete.", "No ReservedRoom Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {

        }

       
    }
}
