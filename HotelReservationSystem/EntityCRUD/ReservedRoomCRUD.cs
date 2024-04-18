using HotelReservationSystem.Entity;
using HotelReservationSystem.Utils;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;

namespace HotelReservationSystem.EntityCRUD
{
    public class ReservedRoomCRUD 
    {
        public void Create(ReservedRoom item)
        {
            string query = "INSERT INTO Reserved_Room (ReservationId, RoomId, StartDate, EndDate) VALUES (:reservationId, :roomId, :startDate, :endDate)";
            OracleParameter[] parameters = {
                new OracleParameter(":reservationId", OracleDbType.Int32) { Value = item.Reservation.Id },
                new OracleParameter(":roomId", OracleDbType.Int32) { Value = item.Room.Id },
                new OracleParameter(":startDate", OracleDbType.Date) { Value = item.StartDate },
                new OracleParameter(":endDate", OracleDbType.Date) { Value = item.EndDate }
            };

            DBConnection.ExecuteQuery(query, parameters);
        }

        public void Delete(int reservationId, int roomId)
        {
            string query = "DELETE FROM Reserved_Room WHERE ReservationId = :reservationId, RoomId = :roomId";
            OracleParameter[] parameters = {
                new OracleParameter(":reservationId", OracleDbType.Int32) { Value = reservationId },
                new OracleParameter(":roomId", OracleDbType.Int32) { Value = roomId }
            };

            DBConnection.ExecuteQuery(query, parameters);
        }

        public IEnumerable<ReservedRoom> GetAll()
        {
            string query = "SELECT * FROM Reserved_Room";
            DataTable dataTable = DBConnection.GetData(query);
            List<ReservedRoom> reservedRooms = new List<ReservedRoom>();

            foreach (DataRow row in dataTable.Rows)
            {
                reservedRooms.Add(new ReservedRoom
                {
                    Reservation = new Reservation { Id = Convert.ToInt32(row["ReservationId"]) },
                    Room = new Room { Id = Convert.ToInt32(row["RoomId"]) },
                    StartDate = Convert.ToDateTime(row["StartDate"]),
                    EndDate = Convert.ToDateTime(row["EndDate"])
                });
            }

            return reservedRooms;
        }

        public ReservedRoom GetById(int reservationId, int roomId)
        {
            string query = "SELECT * FROM Reserved_Room WHERE ReservationId = :reservationId, RoomId = :roomId";
            OracleParameter[] parameters = {
                new OracleParameter(":reservationId", OracleDbType.Int32) { Value = reservationId },
                new OracleParameter(":roomId", OracleDbType.Int32) { Value = roomId }
            };

            DataTable dataTable = DBConnection.GetData(query, parameters);

            if (dataTable.Rows.Count > 0)
            {
                DataRow row = dataTable.Rows[0];
                return new ReservedRoom
                {
                    Reservation = new Reservation { Id = Convert.ToInt32(row["ReservationId"]) },
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

    }
}