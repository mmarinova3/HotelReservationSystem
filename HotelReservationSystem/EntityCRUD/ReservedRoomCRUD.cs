using HotelReservationSystem.Entity;
using HotelReservationSystem.Utils;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;

namespace HotelReservationSystem.EntityCRUD
{
    public class ReservedRoomCRUD : CRUD<ReservedRoom>
    {
        public void Create(ReservedRoom item)
        {
            string query = "INSERT INTO ReservedRoom (RoomId, StartDate, EndDate) VALUES (:roomId, :startDate, :endDate)";
            OracleParameter[] parameters = {
                new OracleParameter(":roomId", OracleDbType.Int32) { Value = item.Room.Id },
                new OracleParameter(":startDate", OracleDbType.Date) { Value = item.StartDate },
                new OracleParameter(":endDate", OracleDbType.Date) { Value = item.EndDate }
            };

            DBConnection.ExecuteQuery(query, parameters);
        }

        public void Delete(int id)
        {
            string query = "DELETE FROM ReservedRoom WHERE Id = :id";
            OracleParameter[] parameters = {
                new OracleParameter(":id", OracleDbType.Int32) { Value = id }
            };

            DBConnection.ExecuteQuery(query, parameters);
        }

        public IEnumerable<ReservedRoom> GetAll()
        {
            string query = "SELECT * FROM ReservedRoom";
            DataTable dataTable = DBConnection.GetData(query);
            List<ReservedRoom> reservedRooms = new List<ReservedRoom>();

            foreach (DataRow row in dataTable.Rows)
            {
                reservedRooms.Add(new ReservedRoom
                {
                    Id = Convert.ToInt32(row["Id"]),
                    Room = new Room { Id = Convert.ToInt32(row["RoomId"]) },
                    StartDate = Convert.ToDateTime(row["StartDate"]),
                    EndDate = Convert.ToDateTime(row["EndDate"])
                });
            }

            return reservedRooms;
        }

        public ReservedRoom GetById(int id)
        {
            string query = "SELECT * FROM ReservedRoom WHERE Id = :id";
            OracleParameter[] parameters = {
                new OracleParameter(":id", OracleDbType.Int32) { Value = id }
            };

            DataTable dataTable = DBConnection.GetData(query, parameters);

            if (dataTable.Rows.Count > 0)
            {
                DataRow row = dataTable.Rows[0];
                return new ReservedRoom
                {
                    Id = Convert.ToInt32(row["Id"]),
                    Room = new Room { Id = Convert.ToInt32(row["RoomId"]) },
                    StartDate = Convert.ToDateTime(row["StartDate"]),
                    EndDate = Convert.ToDateTime(row["EndDate"])
                };
            }
            else
            {
                return null;
            }
        }

        public void Update(int id, ReservedRoom updatedItem)
        {
            string query = "UPDATE ReservedRoom SET RoomId = :roomId, StartDate = :startDate, EndDate = :endDate WHERE Id = :id";
            OracleParameter[] parameters = {
                new OracleParameter(":roomId", OracleDbType.Int32) { Value = updatedItem.Room.Id },
                new OracleParameter(":startDate", OracleDbType.Date) { Value = updatedItem.StartDate },
                new OracleParameter(":endDate", OracleDbType.Date) { Value = updatedItem.EndDate },
                new OracleParameter(":id", OracleDbType.Int32) { Value = id }
            };

            DBConnection.ExecuteQuery(query, parameters);
        }
    }
}