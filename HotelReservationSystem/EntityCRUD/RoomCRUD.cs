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
            string query = "INSERT INTO Room (RoomId,Floor, CategoryId, BathroomId) VALUES (:roomId, :floor, :roomCategoryId, :bathroomId)";
            OracleParameter[] parameters = {
                new OracleParameter(":roomId", OracleDbType.Int32) { Value = item.Id },
                new OracleParameter(":floor", OracleDbType.Int32) { Value = item.Floor },
                new OracleParameter(":roomCategoryId", OracleDbType.Int32) { Value = item.RoomCategory.Id },
                new OracleParameter(":bathroomId", OracleDbType.Int32) { Value = item.Bathroom.Id }
            };

            DBConnection.ExecuteQuery(query, parameters);
        }

        public void Delete(int id)
        {
            string query = "DELETE FROM Room WHERE RoomId = :id";
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
                    Id = Convert.ToInt32(row["RoomId"]),
                    Floor = Convert.ToInt32(row["Floor"]),
                    RoomCategory = new RoomCategory { Id = Convert.ToInt32(row["CategoryId"]) },
                    Bathroom = new Bathroom { Id = Convert.ToInt32(row["BathroomId"]) }
                });
            }

            return rooms;
        }

        public Room GetById(int id)
        {
            string query = "SELECT * FROM Room WHERE RoomId = :id";
            OracleParameter[] parameters = {
                new OracleParameter(":id", OracleDbType.Int32) { Value = id }
            };

            DataTable dataTable = DBConnection.GetData(query, parameters);

            if (dataTable.Rows.Count > 0)
            {
                DataRow row = dataTable.Rows[0];
                return new Room
                {
                    Id = Convert.ToInt32(row["RoomId"]),
                    Floor = Convert.ToInt32(row["Floor"]),
                    RoomCategory = new RoomCategory { Id = Convert.ToInt32(row["CategoryId"]) },
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
            string query = "UPDATE Room SET Floor = :floor, CategoryId = :roomCategoryId, BathroomId = :bathroomId WHERE RoomId = :id";
            OracleParameter[] parameters = {
                new OracleParameter(":floor", OracleDbType.Int32) { Value = updatedItem.Floor },
                new OracleParameter(":roomCategoryId", OracleDbType.Int32) { Value = updatedItem.RoomCategory.Id },
                new OracleParameter(":bathroomId", OracleDbType.Int32) { Value = updatedItem.Bathroom.Id },
                new OracleParameter(":id", OracleDbType.Int32) { Value = id }
            };

            DBConnection.ExecuteQuery(query, parameters);
        }

        public List<Room> GetAvailableRooms(DateTime startDate, DateTime endDate, int roomCategoryId, string isShared)
        {
        string ConnectionString = @"Data Source=localhost:1521/xe;Persist Security Info=True;User ID=TSPHotel;Password=12345";

        List<Room> availableRooms = new List<Room>();

            try
            {
                using (OracleConnection connection = new OracleConnection(ConnectionString))
                {
                    using (OracleCommand command = new OracleCommand("GetAvailableRooms", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.Add("startDate", OracleDbType.Date).Value = startDate.Date;
                        command.Parameters.Add("endDate", OracleDbType.Date).Value = endDate.Date;
                        command.Parameters.Add("roomCategoryId", OracleDbType.Int32).Value = roomCategoryId;
                        command.Parameters.Add("isShared", OracleDbType.Varchar2).Value = isShared;
                        command.Parameters.Add("availableRooms", OracleDbType.RefCursor).Direction = ParameterDirection.Output;

                        connection.Open();

                        using (OracleDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                availableRooms.Add(new Room
                                {
                                    Id = Convert.ToInt32(reader["RoomId"]),
                                    Floor = Convert.ToInt32(reader["Floor"]),
                                    RoomCategory = new RoomCategory { Name = reader["CategoryName"].ToString() },
                                    Bathroom = new Bathroom { IsShared = reader["IsShared"].ToString() }
                                });
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }

            return availableRooms;
        }

        public List<Room> GetAvailableRoomsForPeriod(DateTime startDate, DateTime endDate)
        {
            string ConnectionString = @"Data Source=localhost:1521/xe;Persist Security Info=True;User ID=TSPHotel;Password=12345";

            List<Room> availableRooms = new List<Room>();

            try
            {
                using (OracleConnection connection = new OracleConnection(ConnectionString))
                {
                    using (OracleCommand command = new OracleCommand("GetAvailableRoomsForPeriod", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.Add("startDate", OracleDbType.Date).Value = startDate.Date;
                        command.Parameters.Add("endDate", OracleDbType.Date).Value = endDate.Date;
                        command.Parameters.Add("availableRooms", OracleDbType.RefCursor).Direction = ParameterDirection.Output;

                        connection.Open();

                        using (OracleDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                availableRooms.Add(new Room
                                {
                                    Id = Convert.ToInt32(reader["RoomId"]),
                                    Floor = Convert.ToInt32(reader["Floor"]),
                                    RoomCategory = new RoomCategory { Name = reader["CategoryName"].ToString() },
                                    Bathroom = new Bathroom { IsShared = reader["IsShared"].ToString() }
                                });
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }

            return availableRooms;
        }

    }
}