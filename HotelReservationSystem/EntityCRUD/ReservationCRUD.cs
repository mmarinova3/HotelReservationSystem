using HotelReservationSystem.Entity;
using HotelReservationSystem.Utils;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;

namespace HotelReservationSystem.EntityCRUD
{
    public class ReservationCRUD : CRUD<Reservation>
    {
        public void Create(Reservation item)
        {
            string query = "INSERT INTO Reservation (GuestId, EmployeeId, ReservationDate, GuestNumber) VALUES (:guestId, :employeeId, :reservationDate, :guestNumber)";
            OracleParameter[] parameters = {
                new OracleParameter(":guestId", OracleDbType.Varchar2) { Value = item.Guest.EGN },
                new OracleParameter(":employeeId", OracleDbType.Int32) { Value = item.Employee.Id },
                new OracleParameter(":reservationDate", OracleDbType.Date) { Value = item.ReservationDate },
                new OracleParameter(":guestNumber", OracleDbType.Int32) { Value = item.GuestNumber }
            };

            DBConnection.ExecuteQuery(query, parameters);
        }

        public void Delete(int id)
        {
            string query = "DELETE FROM Reservation WHERE Id = :id";
            OracleParameter[] parameters = {
                new OracleParameter(":id", OracleDbType.Int32) { Value = id }
            };

            DBConnection.ExecuteQuery(query, parameters);
        }

        public IEnumerable<Reservation> GetAll()
        {
            string query = "SELECT * FROM Reservation";
            DataTable dataTable = DBConnection.GetData(query);
            List<Reservation> reservations = new List<Reservation>();

            foreach (DataRow row in dataTable.Rows)
            {
                reservations.Add(new Reservation
                {
                    Id = Convert.ToInt32(row["Id"]),
                    Guest = new Guest { EGN = Convert.ToString(row["GuestId"]) },
                    Employee = new Employee { Id = Convert.ToInt32(row["EmployeeId"]) },
                    ReservationDate = Convert.ToDateTime(row["ReservationDate"]),
                    GuestNumber = Convert.ToInt32(row["GuestNumber"])
                });
            }

            return reservations;
        }

        public Reservation GetById(int id)
        {
            string query = "SELECT * FROM Reservation WHERE Id = :id";
            OracleParameter[] parameters = {
                new OracleParameter(":id", OracleDbType.Int32) { Value = id }
            };

            DataTable dataTable = DBConnection.GetData(query, parameters);

            if (dataTable.Rows.Count > 0)
            {
                DataRow row = dataTable.Rows[0];
                return new Reservation
                {
                    Id = Convert.ToInt32(row["Id"]),
                    Guest = new Guest { EGN = Convert.ToString(row["GuestId"]) },
                    Employee = new Employee { Id = Convert.ToInt32(row["EmployeeId"]) },
                    ReservationDate = Convert.ToDateTime(row["ReservationDate"]),
                    GuestNumber = Convert.ToInt32(row["GuestNumber"])
                };
            }
            else
            {
                return null;
            }
        }

        public void Update(int id, Reservation updatedItem)
        {
            string query = "UPDATE Reservation SET GuestId = :guestId, EmployeeId = :employeeId, ReservationDate = :reservationDate, GuestNumber = :guestNumber WHERE Id = :id";
            OracleParameter[] parameters = {
                new OracleParameter(":guestId", OracleDbType.Varchar2) { Value = updatedItem.Guest.EGN },
                new OracleParameter(":employeeId", OracleDbType.Int32) { Value = updatedItem.Employee.Id },
                new OracleParameter(":reservationDate", OracleDbType.Date) { Value = updatedItem.ReservationDate },
                new OracleParameter(":guestNumber", OracleDbType.Int32) { Value = updatedItem.GuestNumber },
                new OracleParameter(":id", OracleDbType.Int32) { Value = id }
            };

            DBConnection.ExecuteQuery(query, parameters);
        }
    }
}