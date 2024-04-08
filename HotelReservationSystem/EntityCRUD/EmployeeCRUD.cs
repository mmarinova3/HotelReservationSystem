using HotelReservationSystem.Entity;
using HotelReservationSystem.Utils;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;

namespace HotelReservationSystem.EntityCRUD
{
    public class EmployeeCRUD : ICRUD<Employee>
    {
        public void Create(Employee item)
        {
            string query = "INSERT INTO Employee (Name, MobileNumber) VALUES (:name, :mobileNumber)";
            OracleParameter[] parameters = {
                new OracleParameter(":name", OracleDbType.Varchar2) { Value = item.Name },
                new OracleParameter(":mobileNumber", OracleDbType.Varchar2) { Value = item.MobileNumber }
            };

            DBConnection.ExecuteQuery(query, parameters);
        }

        public void Delete(int id)
        {
            string query = "DELETE FROM Employee WHERE Id = :id";
            OracleParameter[] parameters = {
                new OracleParameter(":id", OracleDbType.Int32) { Value = id }
            };

            DBConnection.ExecuteQuery(query, parameters);
        }

        public IEnumerable<Employee> GetAll()
        {
            string query = "SELECT * FROM Employee";
            DataTable dataTable = DBConnection.GetData(query);
            List<Employee> employees = new List<Employee>();

            foreach (DataRow row in dataTable.Rows)
            {
                employees.Add(new Employee
                {
                    Id = Convert.ToInt32(row["Id"]),
                    Name = Convert.ToString(row["Name"]),
                    MobileNumber = Convert.ToString(row["MobileNumber"])
                });
            }

            return employees;
        }

        public Employee GetById(int id)
        {
            string query = "SELECT * FROM Employee WHERE Id = :id";
            OracleParameter[] parameters = {
                new OracleParameter(":id", OracleDbType.Int32) { Value = id }
            };

            DataTable dataTable = DBConnection.GetData(query, parameters);

            if (dataTable.Rows.Count > 0)
            {
                DataRow row = dataTable.Rows[0];
                return new Employee
                {
                    Id = Convert.ToInt32(row["Id"]),
                    Name = Convert.ToString(row["Name"]),
                    MobileNumber = Convert.ToString(row["MobileNumber"])
                };
            }
            else
            {
                return null;
            }
        }

        public void Update(int id, Employee updatedItem)
        {
            string query = "UPDATE Employee SET Name = :name, MobileNumber = :mobileNumber WHERE Id = :id";
            OracleParameter[] parameters = {
                new OracleParameter(":name", OracleDbType.Varchar2) { Value = updatedItem.Name },
                new OracleParameter(":mobileNumber", OracleDbType.Varchar2) { Value = updatedItem.MobileNumber },
                new OracleParameter(":id", OracleDbType.Int32) { Value = id }
            };

            DBConnection.ExecuteQuery(query, parameters);
        }
    }
}