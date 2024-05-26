using HotelReservationSystem.Controller;
using HotelReservationSystem.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelReservationSystem.Forms
{
    public partial class EmployeeForm : Form
    {
        private readonly EmployeeController employeeController;
        private Employee selectedEmployee;

        public EmployeeForm()
        {
            employeeController = new EmployeeController();
            InitializeComponent();
            DisplayData();
        }

        private void EmployeeForm_Load(object sender, EventArgs e)
        {
            insertButton.Text = "Insert";
            editButton.Text = "Edit";
            deleteButton.Text = "Delete";
            searchButton.Text = "Search";
            infoLabel.Text = string.Empty;
        }


        public void DisplayData()
        {
            if (employeeController != null)
            {
                var employees = employeeController.GetEmployees();
                dataGridView1.Columns.Clear();
                dataGridView1.Columns.Add("Id", "Id");
                dataGridView1.Columns.Add("Name", "Name");
                dataGridView1.Columns.Add("EGN", "EGN");
                dataGridView1.Columns.Add("MobileNumber", "Mobile Number");

                foreach (var employee in employees)
                {
                    dataGridView1.Rows.Add(employee.Id,employee.Name,employee.EGN,employee.MobileNumber);
                }
                dataGridView1.Columns["Id"].Visible = false;
            }
            else
            {
                Console.WriteLine("EmployeeController is null.");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dataGridView1.Rows.Count)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                int employeeId;
                if (int.TryParse(row.Cells["Id"].Value.ToString(), out employeeId))
                {
                    selectedEmployee = employeeController.GetById(employeeId);
                    if (selectedEmployee != null)
                    {
                        nameBox.Text = selectedEmployee.Name;
                        phoneBox.Text = selectedEmployee.MobileNumber.ToString();
                    }
                }
            }
        }

        private void ClearInputs()
        {
            nameBox.Text = string.Empty;
            phoneBox.Text = string.Empty;
        }

        private void insertButton_Click(object sender, EventArgs e)
        {
            try
            {
                string employeeName = nameBox.Text;
                string mobilePhone = phoneBox.Text;

                if (string.IsNullOrEmpty(employeeName) || string.IsNullOrEmpty(mobilePhone))
                {
                    infoLabel.Text = "Fields cannot be empty";
                    return;
                }

                if (!Regex.IsMatch(employeeName, @"^[a-zA-Z\s]+$"))
                {
                    infoLabel.Text = "Name should contain only letters.";
                    return;
                }

                if (!Regex.IsMatch(mobilePhone, @"^\d{10}$"))
                {
                    infoLabel.Text = "Mobile number should be 10 digits long and contain only digits.";
                    return;
                }

                Employee employee = new Employee
                {
                    Name = employeeName,
                    MobileNumber = mobilePhone
                };

                if (employeeController.Save(employee))
                {
                    infoLabel.Text = "Employee inserted successfully.";
                    DisplayData();
                    ClearInputs();
                }
                else
                {
                    infoLabel.Text = "Failed to insert employee.";
                }
            }
            catch (Exception ex)
            {
                infoLabel.Text = $"Error: {ex.Message}";
            }
        }


        private void editButton_Click(object sender, EventArgs e)
        {
            if (selectedEmployee != null)
            {
                try
                {
                    string employeeName = nameBox.Text;
                    string mobilePhone = phoneBox.Text;

                    if (string.IsNullOrEmpty(employeeName) || string.IsNullOrEmpty(mobilePhone))
                    {
                        infoLabel.Text = "Fields cannot be empty";
                        return;
                    }

                    if (!Regex.IsMatch(employeeName, @"^[a-zA-Z\s]+$"))
                    {
                        infoLabel.Text = "Name should contain only letters.";
                        return;
                    }

                    if (!Regex.IsMatch(mobilePhone, @"^\d{10}$"))
                    {
                        infoLabel.Text = "Mobile number should be 10 digits long and contain only digits.";
                        return;
                    }

                    selectedEmployee.Name = employeeName;
                    selectedEmployee.MobileNumber = mobilePhone;

                    if (employeeController.Update(selectedEmployee.Id, selectedEmployee))
                    {
                        infoLabel.Text = "Employee updated successfully.";
                        DisplayData();
                    }
                    else
                    {
                        infoLabel.Text = "Failed to update employee.";
                    }
                }
                catch (Exception ex)
                {
                    infoLabel.Text = $"Error: {ex.Message}";
                }
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (selectedEmployee != null)
            {
                try
                {
                    if (employeeController.Delete(selectedEmployee.Id))
                    {
                        infoLabel.Text = "Employee deleted successfully.";
                        DisplayData();
                        ClearInputs();
                    }
                    else
                    {
                        infoLabel.Text = "Failed to delete employee.";
                    }
                }
                catch (Exception ex)
                {
                    infoLabel.Text = $"Error: {ex.Message}";
                }
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            string searchText = nameBox.Text.Trim();

            if (string.IsNullOrEmpty(searchText))
            {
                infoLabel.Text = "Please enter a name to search.";
                return;
            }

            Employee foundEmployee = employeeController.GetEmployees().FirstOrDefault(emp => emp.Name.Equals(searchText, StringComparison.OrdinalIgnoreCase));

            if (foundEmployee != null)
            {
                int rowIndex = -1;
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (row.Cells["Name"].Value != null && row.Cells["Name"].Value.ToString().Equals(searchText, StringComparison.OrdinalIgnoreCase))
                    {
                        rowIndex = row.Index;
                        break;
                    }
                }

                if (rowIndex != -1)
                {
                    dataGridView1.ClearSelection();
                    dataGridView1.Rows[rowIndex].Selected = true;
                    dataGridView1.CurrentCell = dataGridView1.Rows[rowIndex].Cells[2];
                    dataGridView1.FirstDisplayedScrollingRowIndex = rowIndex;
                    infoLabel.Text = "Employee found and selected in the list.";
                }
                else
                {
                    infoLabel.Text = "Employee found but not visible in the list.";
                }
            }
            else
            {
                infoLabel.Text = "Employee not found.";
            }
        }


    }
}
