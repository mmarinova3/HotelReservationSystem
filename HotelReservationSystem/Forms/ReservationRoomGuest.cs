using HotelReservationSystem.Controller;
using HotelReservationSystem.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace HotelReservationSystem.Forms
{
    public partial class ReservationRoomGuest : Form
    {
        private readonly GuestController guestController;
        private readonly CityController cityController;
        private readonly RoomController roomController;
        private readonly ReservationController reservationController;
        private readonly EmployeeController employeeController;
        private readonly ReservedRoomController reservedRoomController;
        private readonly RoomCategoryController roomCategoryController;

        private int initialSingleValue;
        private int initialDoubleValue;
        private int initialFamilyValue;

        public ReservationRoomGuest()
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

        private void ReservationRoomGuest_Load(object sender, EventArgs e)
        {
            FillCityComboBox();
            FillEmployeeComboBox();
            FillRoomCategoryComboBox();
            FillBathroomComboBox();

            adultsTextBox.Text = "1";
            childrenTextBox.Text = "0";
            singleTextBox.Text = "0";
            doubleTextBox.Text = "0";
            familyTextBox.Text = "0";

            checkAvailability();

            initialSingleValue = int.Parse(singleLabel.Text);
            initialDoubleValue = int.Parse(doubleLabel.Text);
            initialFamilyValue = int.Parse(familyLabel.Text);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoginForm l = new LoginForm();
            l.Show();
        }

        private void roomCategoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            checkAvailability();
        }

        private void bathroomComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            checkAvailability();
        }

        private void checkInDatePicker_ValueChanged(object sender, EventArgs e)
        {
            checkAvailability();
        }

        private void checkOutDatePicker_ValueChanged(object sender, EventArgs e)
        {
            checkAvailability();
        }

        private void offerRoomsButton_Click(object sender, EventArgs e)
        {
            giveSuggestions();
        }

        private void adultsMinusButton_Click(object sender, EventArgs e)
        {
            int value = int.Parse(adultsTextBox.Text);
            if (value > 1) value--;
            adultsTextBox.Text = value.ToString();
        }

        private void adultsPlusButton_Click(object sender, EventArgs e)
        {
            int value = int.Parse(adultsTextBox.Text);
            if (value < 10) value++;
            adultsTextBox.Text = value.ToString();
        }

        private void childrenMinusButton_Click(object sender, EventArgs e)
        {
            int value = int.Parse(childrenTextBox.Text);
            if (value > 0) value--;
            childrenTextBox.Text = value.ToString();
        }

        private void childrenPlusButton_Click(object sender, EventArgs e)
        {
            int value = int.Parse(childrenTextBox.Text);
            if (value < 10) value++;
            childrenTextBox.Text = value.ToString();
        }

        private void singleMinusButton_Click(object sender, EventArgs e)
        {
            int value = int.Parse(singleTextBox.Text);
            if (value > 0) value--;
            singleTextBox.Text = value.ToString();
        }

        private void singlePlusButton_Click(object sender, EventArgs e)
        {
            int value = int.Parse(singleTextBox.Text);
            if (value < initialSingleValue) value++;
            singleTextBox.Text = value.ToString();
        }

        private void doubleMinusButton_Click(object sender, EventArgs e)
        {
            int value = int.Parse(doubleTextBox.Text);
            if (value > 0) value--;
            doubleTextBox.Text = value.ToString();
        }

        private void doublePlusButton_Click(object sender, EventArgs e)
        {
            int value = int.Parse(doubleTextBox.Text);
            if (value < initialDoubleValue) value++;
            doubleTextBox.Text = value.ToString();
        }

        private void familyMinusButton_Click(object sender, EventArgs e)
        {
            int value = int.Parse(familyTextBox.Text);
            if (value > 0) value--;
            familyTextBox.Text = value.ToString();
        }

        private void familyPlusButton_Click(object sender, EventArgs e)
        {
            int value = int.Parse(familyTextBox.Text);
            if (value < initialFamilyValue) value++;
            familyTextBox.Text = value.ToString();
        }

        private void checkEGNButton_Click(object sender, EventArgs e)
        {
            CheckEGN();
        }

        private void makeReservationButton_Click(object sender, EventArgs e)
        {
            MakeReservation();
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

            RoomCategory allCategory = new RoomCategory { Id = 0, Name = "All" };
            categories.Insert(0, allCategory);

            roomCategoryComboBox.DataSource = categories;
            roomCategoryComboBox.DisplayMember = "Name";
            roomCategoryComboBox.ValueMember = "Id";
            roomCategoryComboBox.SelectedIndex = 0;
        }

        private void FillBathroomComboBox()
        {
            bathroomComboBox.Items.Clear();

            bathroomComboBox.Items.Add("Shared");
            bathroomComboBox.Items.Add("Not Shared");
            bathroomComboBox.Items.Add("All");

            bathroomComboBox.SelectedIndex = 0;
        }

        private void checkAvailability()
        {
            int roomCategoryId;
            RoomCategory selectedCategory = (RoomCategory)roomCategoryComboBox.SelectedItem;

            if (selectedCategory == null || selectedCategory.Id == 0)
            {
                roomCategoryId = 0;
            }
            else
            {
                roomCategoryId = selectedCategory.Id;
            }

            string bathroomType = null;

            string selectedBathroomOption = bathroomComboBox.SelectedItem?.ToString();

            if (selectedBathroomOption == "Not Shared")
            {
                bathroomType = "False";
            }
            else if (selectedBathroomOption == "Shared")
            {
                bathroomType = "True";
            }

            DateTime checkInDate = checkInDatePicker.Value.Date;
            DateTime checkOutDate = checkOutDatePicker.Value.Date;

            int singleRooms = 0;
            int doubleRooms = 0;
            int familyRooms = 0;

            List<Room> classifiedRooms = roomController.GetAvailableRooms(checkInDate, checkOutDate, roomCategoryId, bathroomType);

            foreach (var room in classifiedRooms)
            {
                if (room.RoomCategory.Name == "Single") { singleRooms++; }
                if (room.RoomCategory.Name == "Double") { doubleRooms++; }
                if (room.RoomCategory.Name == "Family") { familyRooms++; }
            }

            singleLabel.Text = singleRooms.ToString();
            doubleLabel.Text = doubleRooms.ToString();
            familyLabel.Text = familyRooms.ToString();
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
            if (!checkBeforeReserve())
            {
                return;
            }

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
                Reservation r = reservationController.GetLastAddedReservation();
                infoLabel.Text = "Reservation saved successfully.";
                reservationNumberText.Text = "Reservation Id #" + r.Id;
            }
            else
            {
                infoLabel.Text = "Failed to save reservation.";
            }

            AutoReserveRoom(reservationController.GetLastAddedReservation());
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
                ReservationDate = DateTime.Now.Date,
                AdultsNumber = int.Parse(adultsTextBox.Text),
                ChildrenNumber = int.Parse(childrenTextBox.Text),
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

        private void AutoReserveRoom(Reservation reservation)
        {
            DateTime startDate = checkInDatePicker.Value;
            DateTime endDate = checkOutDatePicker.Value;
            int roomCategoryId;
            RoomCategory selectedCategory = (RoomCategory)roomCategoryComboBox.SelectedItem;

            if (selectedCategory == null || selectedCategory.Id == 0)
            {
                roomCategoryId = 0;
            }
            else
            {
                roomCategoryId = selectedCategory.Id;
            }

            string bathroomType = null;

            string selectedBathroomOption = bathroomComboBox.SelectedItem?.ToString();

            if (selectedBathroomOption == "Not Shared")
            {
                bathroomType = "False";
            }
            else if (selectedBathroomOption == "Shared")
            {
                bathroomType = "True";
            }

            if (startDate >= endDate)
            {
                infoLabel2.Text = "Start date must be before end date.";
                return;
            }

            int totalAdults = int.Parse(adultsTextBox.Text);
            int totalChildren = int.Parse(childrenTextBox.Text);
            int totalGuests = totalAdults + totalChildren;

            Room selectedRoom = null;
            for (int i = 0; i < int.Parse(singleTextBox.Text); i++)
            {
                selectedRoom = roomController.GetAvailableRooms(startDate, endDate, 1, bathroomType).FirstOrDefault();
                CreateReservedRoom(selectedRoom, reservation);
            }
            for (int i = 0; i < int.Parse(doubleTextBox.Text); i++)
            {
                selectedRoom = roomController.GetAvailableRooms(startDate, endDate, 2, bathroomType).FirstOrDefault();
                CreateReservedRoom(selectedRoom, reservation);
            }
            for (int i = 0; i < int.Parse(familyTextBox.Text); i++)
            {
                selectedRoom = roomController.GetAvailableRooms(startDate, endDate, 3, bathroomType).FirstOrDefault();
                CreateReservedRoom(selectedRoom, reservation);
            }
        }

        private void CreateReservedRoom(Room selectedRoom, Reservation reservation)
        {
            DateTime startDate = checkInDatePicker.Value;
            DateTime endDate = checkOutDatePicker.Value;

            if (selectedRoom == null)
            {
                infoLabel2.Text = "No suitable room available.";
                return;
            }

            ReservedRoom newReservedRoom = new ReservedRoom
            {
                Reservation = reservation,
                Room = selectedRoom,
                StartDate = startDate,
                EndDate = endDate
            };

            if (reservedRoomController.Save(newReservedRoom))
            {
                infoLabel2.Text = "Room reserved successfully.";
            }
            else
            {
                infoLabel2.Text = "Failed to reserve the room.";
            }
        }

        private void giveSuggestions()
        {
            int adults;
            if (!int.TryParse(adultsTextBox.Text, out adults))
            {
                adults = 1;
            }

            int children;
            if (!int.TryParse(childrenTextBox.Text, out children))
            {
                children = 0;
            }

            int singleRooms = 0;
            int doubleRooms = 0;
            int familyRooms = 0;

            while (adults > 0 || children > 0)
            {
                if (adults >= 2 && children >= 2)
                {
                    familyRooms++;
                    adults -= 2;
                    children -= 2;
                }
                else if (adults == 1 && children >= 2)
                {
                    familyRooms++;
                    adults -= 1;
                    children -= 2;
                }
                else if (adults == 2 && children == 1)
                {
                    familyRooms++;
                    adults -= 2;
                    children -= 1;
                }
                else if (adults == 2 && children == 0)
                {
                    doubleRooms++;
                    adults -= 2;
                }
                else if (adults == 1 && children == 1)
                {
                    doubleRooms++;
                    adults -= 1;
                    children -= 1;
                }
                else if (adults == 1 && children == 0)
                {
                    singleRooms++;
                    adults -= 1;
                }
                else if (adults == 0 && children > 0)
                {
                    if (children >= 2)
                    {
                        familyRooms++;
                        children -= 2;
                    }
                    else if (children == 1)
                    {
                        doubleRooms++;
                        children -= 1;
                    }
                }
                else if (adults > 0 && children == 0)
                {
                    if (adults == 1)
                    {
                        singleRooms++;
                        adults -= 1;
                    }
                    else if (adults >= 2)
                    {
                        doubleRooms++;
                        adults -= 2;
                    }
                }
            }

            singleTextBox.Text = singleRooms.ToString();
            doubleTextBox.Text = doubleRooms.ToString();
            familyTextBox.Text = familyRooms.ToString();
        }

        private bool checkBeforeReserve()
        {
            int totalGuests = int.Parse(adultsTextBox.Text) + int.Parse(childrenTextBox.Text);
            int singleRooms = int.Parse(singleTextBox.Text);
            int doubleRooms = int.Parse(doubleTextBox.Text);
            int familyRooms = int.Parse(familyTextBox.Text);

            int totalCapacity = (singleRooms * 1) + (doubleRooms * 2) + (familyRooms * 4);

            if (totalGuests > totalCapacity)
            {
                infoLabel.Text = "Total number of guests exceeds room capacity.";
                return false;
            }

            if (totalGuests < totalCapacity)
            {
                infoLabel.Text = "There are rooms which shouldn't be reserved.";
                return false;
            }


            return true;
        }

        
    }
}
