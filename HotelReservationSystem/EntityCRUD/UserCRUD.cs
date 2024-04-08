using HotelReservationSystem.Utils;
using HotelReservationSystem.Entity;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;

namespace HotelReservationSystem.EntityCRUD
{
    public class UserCRUD
    {
        public void Create(User item)
        {
            string query = "INSERT INTO Sysuser (Username, UserPassword) VALUES (:username, :password)";
            OracleParameter[] parameters = {
                new OracleParameter(":username", OracleDbType.Varchar2) { Value = item.Username },
                new OracleParameter(":password", OracleDbType.Varchar2) { Value = item.Password }
            };
            DBConnection.ExecuteQuery(query, parameters);
        }

        public void Delete(string username)
        {
            string query = "DELETE FROM Sysuser WHERE Username = :username";
            OracleParameter[] parameters = {
                new OracleParameter(":username", OracleDbType.Varchar2) { Value = username }
            };
            DBConnection.ExecuteQuery(query, parameters);
        }

        public IEnumerable<User> GetAll()
        {
            string query = "SELECT * FROM Sysuser";
            DataTable dataTable = DBConnection.GetData(query);
            List<User> users = new List<User>();

            foreach (DataRow row in dataTable.Rows)
            {
                users.Add(new User
                {
                    Username = row["Username"].ToString(),
                    Password = row["UserPassword"].ToString()
                    // Employee property should be populated if needed
                });
            }

            return users;
        }
        public User GetById(string username)
        {
            string query = "SELECT * FROM Sysuser WHERE Username = :username";
            OracleParameter[] parameters = {
               new OracleParameter(":username", OracleDbType.Varchar2) { Value = username }
             };

            DataTable dataTable = DBConnection.GetData(query, parameters);

            if (dataTable.Rows.Count > 0)
            {
                DataRow row = dataTable.Rows[0];

                int employeeId = Convert.ToInt32(row["EmployeeId"]);

                EmployeeCRUD employeeCRUD = new EmployeeCRUD();

                Employee employee = employeeCRUD.GetById(employeeId);

                return new User
                {
                    Username = row["Username"].ToString(),
                    Password = row["UserPassword"].ToString(),
                    Employee = employee
                };
            }
            else
            {
                return null;
            }
        }



        public void Update(string username, User updatedItem)
        {
            string query = "UPDATE Sysuser SET UserPassword = :password WHERE Username = :username";
            OracleParameter[] parameters = {
                new OracleParameter(":password", OracleDbType.Varchar2) { Value = updatedItem.Password },
                new OracleParameter(":username", OracleDbType.Varchar2) { Value = username }
            };
            DBConnection.ExecuteQuery(query, parameters);
        }
    }
}