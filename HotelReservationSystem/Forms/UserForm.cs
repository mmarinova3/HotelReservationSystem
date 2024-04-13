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
    public partial class UserForm : Form
    {
        UserController userController = new UserController();
        User selectedUser;

        public UserForm()
        {
            selectedUser = new User();
            InitializeComponent();
            DisplayData();
        }

        private void UserForm_Load(object sender, EventArgs e)
        {
            insertButton.Text = "Insert";
            editButton.Text = "Edit";
            deleteButton.Text = "Delete";
            searchButton.Text = "Search";
            infoLabel.Text = string.Empty;
        }


        public void DisplayData()
        {
            dataGridView1.DataSource = userController.GetUsers();

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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
