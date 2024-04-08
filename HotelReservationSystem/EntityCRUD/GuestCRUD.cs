using HotelReservationSystem.Entity;
using HotelReservationSystem.Utils;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;

namespace HotelReservationSystem.EntityCRUD
{
    public class GuestCRUD : ICRUD<Guest>
    {
        public void Create(Guest item)
        {
            string query = "INSERT INTO Guest (EGN, Name, CityId, Address, MobileNumber) VALUES (:egn, :name, :cityId, :address, :mobileNumber)";
            OracleParameter[] parameters = {
                new OracleParameter(":egn", OracleDbType.Varchar2) { Value = item.EGN },
                new OracleParameter(":name", OracleDbType.Varchar2) { Value = item.Name },
                new OracleParameter(":cityId", OracleDbType.Int32) { Value = item.City.Id },
                new OracleParameter(":address", OracleDbType.Varchar2) { Value = item.Address },
                new OracleParameter(":mobileNumber", OracleDbType.Varchar2) { Value = item.MobileNumber }
            };

            DBConnection.ExecuteQuery(query, parameters);
        }

        public void Delete(int id)
        {
            string query = "DELETE FROM Guest WHERE Id = :id";
            OracleParameter[] parameters = {
                new OracleParameter(":id", OracleDbType.Int32) { Value = id }
            };

            DBConnection.ExecuteQuery(query, parameters);
        }

        public IEnumerable<Guest> GetAll()
        {
            string query = "SELECT * FROM Guest";
            DataTable dataTable = DBConnection.GetData(query);
            List<Guest> guests = new List<Guest>();

            foreach (DataRow row in dataTable.Rows)
            {
                guests.Add(new Guest
                {
                    EGN = Convert.ToString(row["EGN"]),
                    Name = Convert.ToString(row["Name"]),
                    City = new City { Id = Convert.ToInt32(row["CityId"]) },
                    Address = Convert.ToString(row["Address"]),
                    MobileNumber = Convert.ToString(row["MobileNumber"])
                });
            }

            return guests;
        }

        public Guest GetById(int id)
        {
            string query = "SELECT * FROM Guest WHERE Id = :id";
            OracleParameter[] parameters = {
                new OracleParameter(":id", OracleDbType.Int32) { Value = id }
            };

            DataTable dataTable = DBConnection.GetData(query, parameters);

            if (dataTable.Rows.Count > 0)
            {
                DataRow row = dataTable.Rows[0];
                return new Guest
                {
                    EGN = Convert.ToString(row["EGN"]),
                    Name = Convert.ToString(row["Name"]),
                    City = new City { Id = Convert.ToInt32(row["CityId"]) },
                    Address = Convert.ToString(row["Address"]),
                    MobileNumber = Convert.ToString(row["MobileNumber"])
                };
            }
            else
            {
                return null;
            }
        }

        public void Update(int id, Guest updatedItem)
        {
            string query = "UPDATE Guest SET EGN = :egn, Name = :name, CityId = :cityId, Address = :address, MobileNumber = :mobileNumber WHERE Id = :id";
            OracleParameter[] parameters = {
                new OracleParameter(":egn", OracleDbType.Varchar2) { Value = updatedItem.EGN },
                new OracleParameter(":name", OracleDbType.Varchar2) { Value = updatedItem.Name },
                new OracleParameter(":cityId", OracleDbType.Int32) { Value = updatedItem.City.Id },
                new OracleParameter(":address", OracleDbType.Varchar2) { Value = updatedItem.Address },
                new OracleParameter(":mobileNumber", OracleDbType.Varchar2) { Value = updatedItem.MobileNumber },
                new OracleParameter(":id", OracleDbType.Int32) { Value = id }
            };

            DBConnection.ExecuteQuery(query, parameters);
        }
    }
}