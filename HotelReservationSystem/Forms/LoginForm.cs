using HotelReservationSystem.Controller;
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
    public partial class LoginForm : Form
    {
        private UserController userController;

        public LoginForm()
        {
            InitializeComponent();
            userController = new UserController();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            label1.Text = "HOTEL RESERVATION SYSTEM";
            infoLabel.Text = string.Empty;
            loginButton.Text = "LogIn";
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string username = usernameBox.Text;
            string password = passwordBox.Text;

            bool isValidLogin = userController.ValidateLogin(username, password);

            if (isValidLogin)
            {
                infoLabel.Text = "Login successful!";
            }
            else
            {
                infoLabel.Text = "Invalid username or password. Please try again.";
            }
        }
    }
}