using HotelReservationSystem.Controller;
using HotelReservationSystem.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace HotelReservationSystem.Forms
{
    public partial class MainViewForm : Form
    {
        private readonly GuestController guestController;
        private readonly CityController cityController;
        private readonly RoomController roomController;
        private readonly ReservationController reservationController;
        private readonly EmployeeController employeeController;
        private readonly ReservedRoomController reservedRoomController;
        private readonly RoomCategoryController roomCategoryController;

        public MainViewForm()
        {
            guestController = new GuestController();
            cityController = new CityController();
            roomController = new RoomController();
            reservationController = new ReservationController();
            employeeController = new EmployeeController();
            reservedRoomController = new ReservedRoomController();
            roomCategoryController = new RoomCategoryController();
            InitializeComponent();
        }

        private void MainViewForm_Load(object sender, EventArgs e)
        {
            FillCityComboBox();
            FillEmployeeComboBox();
            FillRoomCategoryComboBox();
            FillRoomComboBox();
            FillReservationIDComboBox();
            DisplayAvailableRoomsData();
            bathroomCheckBox.CheckedChanged += bathroomCheckBox_CheckedChanged;
            adultsNumTextBox.Text = "0";
            childNumTextBox.Text = "0";
        }

        private void cityToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenForm(new CityForm());
        }

        private void bathroomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenForm(new BathroomForm());
        }

        private void roomCategoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenForm(new RoomCategoryForm());
        }

        private void employeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenForm(new EmployeeForm());
        }

        private void guestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenForm(new GuestForm());
        }

        private void reservationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenForm(new ReservationForm());
        }

        private void reservedRoomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenForm(new ReservedRoomForm());
        }

        private void roomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenForm(new RoomForm());
        }

        private void userToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenForm(new UserForm());
        }

        private void checkEGNButton_Click(object sender, EventArgs e)
        {
            CheckEGN();
        }

        private void makeReservationButton_Click(object sender, EventArgs e)
        {
            MakeReservation();
        }

        private void reserveRoomButton_Click(object sender, EventArgs e)
        {
            Reservation selectedReservation = (Reservation)reservationIDComboBox.SelectedItem;
            Room selectedRoom = (Room)roomNumberComboBox.SelectedItem;

            DateTime startDate = roomResStartDateTimePicker.Value;
            DateTime endDate = roomResEndDateTimePicker.Value;

            if (startDate >= endDate)
            {
                infoLabel2.Text = "Start date must be before end date.";
                return;
            }

            ReservedRoom newReservedRoom = new ReservedRoom
            {
                Reservation = selectedReservation,
                Room = selectedRoom,
                StartDate = startDate,
                EndDate = endDate
            };

            if (reservedRoomController.Save(newReservedRoom))
            {
                infoLabel2.Text = "ReservedRoom saved successfully.";
            }
            else
            {
                infoLabel2.Text = "Failed to save ReservedRoom.";
            }
        }


        private void bathroomCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            DisplayAvailableRoomsData();
        }

        private void roomCategoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            DisplayAvailableRoomsData();
        }

        private void referenceEndDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            DisplayAvailableRoomsData();
        }

        private void referenceStartDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            DisplayAvailableRoomsData();
        }

        private void OpenForm(Form form)
        {
            form.Show();
        }

        private void FillCityComboBox()
        {
            List<City> cities = cityController.GetCities();
            cityComboBox.DataSource = cities;
            cityComboBox.DisplayMember = "CityName";
            cityComboBox.ValueMember = "Id";
        }

        private void FillEmployeeComboBox()
        {
            List<Employee> employees = employeeController.GetEmployees();
            employeeComboBox.DataSource = employees;
            employeeComboBox.DisplayMember = "Name";
            employeeComboBox.ValueMember = "Id";
        }

        private void FillRoomCategoryComboBox()
        {
            List<RoomCategory> categories = roomCategoryController.GetCategories();
            roomCategoryComboBox.DataSource = categories;
            roomCategoryComboBox.DisplayMember = "Name";
            roomCategoryComboBox.ValueMember = "Id";
        }

        private void FillRoomComboBox()
        {
            List<Room> rooms = roomController.GetRooms();
            roomNumberComboBox.DataSource = rooms;
            roomNumberComboBox.DisplayMember = "Id";
            roomNumberComboBox.ValueMember = "Id";
        }

        private void FillReservationIDComboBox()
        {
            List<Reservation> reservations = reservationController.GetReservations();
            reservationIDComboBox.DataSource = reservations;
            reservationIDComboBox.DisplayMember = "Id";
            reservationIDComboBox.ValueMember = "Id";
        }

        private void DisplayAvailableRoomsData()
        {
            RoomCategory selectedCategory = (RoomCategory)roomCategoryComboBox.SelectedItem;
            DateTime startDate = referenceStartDateTimePicker.Value.Date;
            DateTime endDate = referenceEndDateTimePicker.Value.Date;
            int roomCategoryId = selectedCategory?.Id ?? 0;
            string isShared = bathroomCheckBox.Checked ? "True" : "False";

            if (roomController != null)
            {
                var rooms = roomController.GetAvailableRooms(startDate, endDate, roomCategoryId, isShared);
                roomReferenceDataGridView.Columns.Clear();
                roomReferenceDataGridView.Columns.Add("Id", "Room Number");
                roomReferenceDataGridView.Columns.Add("Floor", "Floor");
                roomReferenceDataGridView.Columns.Add("CategoryId", "Category");
                roomReferenceDataGridView.Columns.Add("BathroomId", "Bathroom (shared?)");

                foreach (var room in rooms)
                {
                    roomReferenceDataGridView.Rows.Add(room.Id, room.Floor, room.RoomCategory.Name, room.Bathroom.IsShared);
                }
            }
            else
            {
                Console.WriteLine("RoomController is null.");
            }
        }

        private void CheckEGN()
        {
            string egn = reservationEGNTextBox.Text;

            if (string.IsNullOrEmpty(egn))
            {
                infoLabel.Text = "Please write EGN to check.";
                return;
            }
            else if (!Regex.IsMatch(egn, @"^\d{10}$"))
            {
                infoLabel.Text = "Invalid EGN.";
                return;
            }

            Guest guest = guestController.GetById(egn);

            if (guest == null)
            {
                infoLabel.Text = $"No registered guest with EGN: {egn}";
                return;
            }
            else
            {
                nameTextBox.Text = guest.Name;
                if (guest.City != null)
                {
                    cityComboBox.SelectedValue = guest.City.Id;
                }
                addressTextBox.Text = guest.Address;
                phoneTextBox.Text = guest.MobileNumber;
                infoLabel.Text = string.Empty;
            }
        }

        private void MakeReservation()
        {
            string egn = reservationEGNTextBox.Text;
            Guest guest = guestController.GetById(egn);


            if (guest == null)
            {
                if (ValidateGuestInfo())
                {
                    guest = CreateNewGuest();
                    if (!guestController.Save(guest))
                    {
                        infoLabel.Text = "Failed to save guest.";
                        return;
                    }
                    infoLabel.Text = "Guest saved successfully.";
                }
                else
                {
                    infoLabel.Text = "Invalid guest information.";
                    return;
                }
            }

            Reservation newReservation = CreateNewReservation(guest);
            if (reservationController.Save(newReservation))
            {
                infoLabel.Text = "Reservation saved successfully.";
            }
            else
            {
                infoLabel.Text = "Failed to save reservation.";
            }

        }

        private Guest CreateNewGuest()
        {
            City selectedCity = (City)cityComboBox.SelectedItem;
            return new Guest
            {
                EGN = reservationEGNTextBox.Text,
                Name = nameTextBox.Text,
                City = selectedCity,
                Address = addressTextBox.Text,
                MobileNumber = phoneTextBox.Text
            };
        }

        private Reservation CreateNewReservation(Guest guest)
        {
            Employee selectedEmployee = (Employee)employeeComboBox.SelectedItem;
            return new Reservation
            {
                Guest = guest,
                Employee = selectedEmployee,
                ReservationDate = reservationDateTimePicker.Value,
                AdultsNumber = int.Parse(adultsNumTextBox.Text),
                ChildrenNumber = int.Parse(childNumTextBox.Text),
                Note = noteRichTextBox.Text
            };
        }

        private bool ValidateGuestInfo()
        {
            if (reservationEGNTextBox.Text.Length != 10 || !reservationEGNTextBox.Text.All(char.IsDigit))
            {
                infoLabel.Text = "Invalid EGN.";
                return false;
            }

            string namePattern = @"^[A-Z][a-z]*(?:[ -][A-Z][a-z]*)*$";
            if (string.IsNullOrWhiteSpace(nameTextBox.Text) || !Regex.IsMatch(nameTextBox.Text, namePattern))
            {
                infoLabel.Text = "Name must start with an uppercase letter, contain only letters, spaces or hyphens, and each word must start with an uppercase letter.";
                return false;
            }

            if (string.IsNullOrWhiteSpace(phoneTextBox.Text) || phoneTextBox.Text.Length != 10 || !phoneTextBox.Text.All(char.IsDigit))
            {
                infoLabel.Text = "Invalid Mobile Number.";
                return false;
            }

            return true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenForm(new ReservationRoomGuest());
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string message = "Hotel Reservation System (HRS)\n" +
                             "Developing a reservation system for a hotel. The hotel has rooms available for guests. It also has a limited number of bathrooms. Rooms are categorized into singles, doubles, and family rooms. Each room type has specific occupancy rules.";

            string caption = "About HRS";
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            MessageBoxIcon icon = MessageBoxIcon.Information;

            MessageBox.Show(message, caption, buttons, icon);
        }

    }
}
