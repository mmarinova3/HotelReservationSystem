using HotelReservationSystem.Entity;
using HotelReservationSystem.EntityCRUD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelReservationSystem.Controller
{
    public class EmployeeController
    {
        EmployeeCRUD employeeCRUD;
        public EmployeeController() 
        {
            employeeCRUD = new EmployeeCRUD();
        }

        public List<Employee> GetEmployees()
        {
            List<Employee> list = (List<Employee>)employeeCRUD.GetAll();
            return list;
        }

        public bool Save(Employee employee)
        {
            try
            {
                employeeCRUD.Create(employee);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error saving Employee: {ex.Message}");
                return false;
            }
        }

        public bool Update(int id, Employee updatedEmployee)
        {
            try
            {
                employeeCRUD.Update(id, updatedEmployee);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error updating Employee: {ex.Message}");
                return false;
            }
        }

        public bool Delete(int id)
        {
            try
            {
                employeeCRUD.Delete(id);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error deleting Employee: {ex.Message}");
                return false;
            }
        }



        public Employee GetById(int id)
        {
            return employeeCRUD.GetById(id);
        }
    }
}
