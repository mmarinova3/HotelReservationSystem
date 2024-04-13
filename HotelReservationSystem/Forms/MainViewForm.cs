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
    public partial class MainViewForm : Form
    {
        public MainViewForm()
        {
            InitializeComponent();
        }

        private void MainViewForm_Load(object sender, EventArgs e)
        {

        }

        private void cityToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CityForm cityForm = new CityForm();
            cityForm.Show();
        }

        private void bathroomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BathroomForm bathroomForm = new BathroomForm();
            bathroomForm.Show();
        }

        private void roomCategoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RoomCategoryForm roomCategoryForm = new RoomCategoryForm();
            roomCategoryForm.Show();
        }

        private void employeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EmployeeForm employeeForm = new EmployeeForm();
            employeeForm.Show();
        }

        private void guestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GuestForm guestForm = new GuestForm();
            guestForm.Show();
        }

        private void reservationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReservationForm reservationForm = new ReservationForm();
            reservationForm.Show();
        }

        private void reservedRoomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReservedRoomForm reservedRoomForm = new ReservedRoomForm();
            reservedRoomForm.Show();
        }

        private void roomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RoomForm roomForm = new RoomForm();
            roomForm.Show();
        }

        private void userToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserForm userForm = new UserForm();
            userForm.Show();
        }
    }
}
