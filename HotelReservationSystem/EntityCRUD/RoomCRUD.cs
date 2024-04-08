using HotelReservationSystem.Entity;
using HotelReservationSystem.Utils;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;

namespace HotelReservationSystem.EntityCRUD
{
    public class RoomCRUD : ICRUD<Room>
    {
        public void Create(Room item)
        {
            string query = "INSERT INTO Room (Floor, RoomCategoryId, BathroomId) VALUES (:floor, :roomCategoryId, :bathroomId)";
            OracleParameter[] parameters = {
                new OracleParameter(":floor", OracleDbType.Int32) { Value = item.Floor },
                new OracleParameter(":roomCategoryId", OracleDbType.Int32) { Value = item.RoomCategory.Id },
                new OracleParameter(":bathroomId", OracleDbType.Int32) { Value = item.Bathroom.Id }
            };

            DBConnection.ExecuteQuery(query, parameters);
        }

        public void Delete(int id)
        {
            string query = "DELETE FROM Room WHERE Id = :id";
            OracleParameter[] parameters = {
                new OracleParameter(":id", OracleDbType.Int32) { Value = id }
            };

            DBConnection.ExecuteQuery(query, parameters);
        }

        public IEnumerable<Room> GetAll()
        {
            string query = "SELECT * FROM Room";
            DataTable dataTable = DBConnection.GetData(query);
            List<Room> rooms = new List<Room>();

            foreach (DataRow row in dataTable.Rows)
            {
                rooms.Add(new Room
                {
                    Id = Convert.ToInt32(row["Id"]),
                    Floor = Convert.ToInt32(row["Floor"]),
                    RoomCategory = new RoomCategory { Id = Convert.ToInt32(row["RoomCategoryId"]) },
                    Bathroom = new Bathroom { Id = Convert.ToInt32(row["BathroomId"]) }
                });
            }

            return rooms;
        }

        public Room GetById(int id)
        {
            string query = "SELECT * FROM Room WHERE Id = :id";
            OracleParameter[] parameters = {
                new OracleParameter(":id", OracleDbType.Int32) { Value = id }
            };

            DataTable dataTable = DBConnection.GetData(query, parameters);

            if (dataTable.Rows.Count > 0)
            {
                DataRow row = dataTable.Rows[0];
                return new Room
                {
                    Id = Convert.ToInt32(row["Id"]),
                    Floor = Convert.ToInt32(row["Floor"]),
                    RoomCategory = new RoomCategory { Id = Convert.ToInt32(row["RoomCategoryId"]) },
                    Bathroom = new Bathroom { Id = Convert.ToInt32(row["BathroomId"]) }
                };
            }
            else
            {
                return null;
            }
        }

        public void Update(int id, Room updatedItem)
        {
            string query = "UPDATE Room SET Floor = :floor, RoomCategoryId = :roomCategoryId, BathroomId = :bathroomId WHERE Id = :id";
            OracleParameter[] parameters = {
                new OracleParameter(":floor", OracleDbType.Int32) { Value = updatedItem.Floor },
                new OracleParameter(":roomCategoryId", OracleDbType.Int32) { Value = updatedItem.RoomCategory.Id },
                new OracleParameter(":bathroomId", OracleDbType.Int32) { Value = updatedItem.Bathroom.Id },
                new OracleParameter(":id", OracleDbType.Int32) { Value = id }
            };

            DBConnection.ExecuteQuery(query, parameters);
        }
    }
}