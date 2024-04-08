using HotelReservationSystem.Utils;
using HotelReservationSystem.Entity;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;

namespace HotelReservationSystem.EntityCRUD
{
    public class RoomCategoryCRUD : CRUD<RoomCategory>
    {
        public void Create(RoomCategory item)
        {
            string query = "INSERT INTO RoomCategory (Name, MaxCapacity) VALUES (:name, :maxCapacity)";
            OracleParameter[] parameters = {
                new OracleParameter(":name", OracleDbType.Varchar2) { Value = item.Name },
                new OracleParameter(":maxCapacity", OracleDbType.Int32) { Value = item.MaxCapacity }
            };
            DBConnection.ExecuteQuery(query, parameters);
        }

        public void Delete(int id)
        {
            string query = "DELETE FROM RoomCategory WHERE Id = :id";
            OracleParameter[] parameters = {
                new OracleParameter(":id", OracleDbType.Int32) { Value = id }
            };
            DBConnection.ExecuteQuery(query, parameters);
        }

        public IEnumerable<RoomCategory> GetAll()
        {
            string query = "SELECT * FROM RoomCategory";
            DataTable dataTable = DBConnection.GetData(query);
            List<RoomCategory> roomCategories = new List<RoomCategory>();

            foreach (DataRow row in dataTable.Rows)
            {
                roomCategories.Add(new RoomCategory
                {
                    Id = int.Parse(row["Id"].ToString()),
                    Name = row["Name"].ToString(),
                    MaxCapacity = int.Parse(row["MaxCapacity"].ToString())
                });
            }

            return roomCategories;
        }

        public RoomCategory GetById(int id)
        {
            string query = "SELECT * FROM RoomCategory WHERE Id = :id";
            OracleParameter[] parameters = {
                new OracleParameter(":id", OracleDbType.Int32) { Value = id }
            };

            DataTable dataTable = DBConnection.GetData(query, parameters);

            if (dataTable.Rows.Count > 0)
            {
                DataRow row = dataTable.Rows[0];
                return new RoomCategory
                {
                    Id = int.Parse(row["Id"].ToString()),
                    Name = row["Name"].ToString(),
                    MaxCapacity = int.Parse(row["MaxCapacity"].ToString())
                };
            }
            else
            {
                return null;
            }
        }

        public void Update(int id, RoomCategory updatedItem)
        {
            string query = "UPDATE RoomCategory SET Name = :name, MaxCapacity = :maxCapacity WHERE Id = :id";
            OracleParameter[] parameters = {
                new OracleParameter(":name", OracleDbType.Varchar2) { Value = updatedItem.Name },
                new OracleParameter(":maxCapacity", OracleDbType.Int32) { Value = updatedItem.MaxCapacity },
                new OracleParameter(":id", OracleDbType.Int32) { Value = id }
            };
            DBConnection.ExecuteQuery(query, parameters);
        }
    }
}