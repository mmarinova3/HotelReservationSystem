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
    }
}
