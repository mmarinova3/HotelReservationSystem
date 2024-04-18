using HotelReservationSystem.Entity;
using HotelReservationSystem.EntityCRUD;
using System;
using System.Collections.Generic;

namespace HotelReservationSystem.Controller
{
    public class ReservedRoomController
    {
        ReservedRoomCRUD reservedRoomCRUD;

        public ReservedRoomController()
        {
            reservedRoomCRUD = new ReservedRoomCRUD();
        }

        public List<ReservedRoom> GetReservedRooms()
        {
            List<ReservedRoom> list = (List<ReservedRoom>)reservedRoomCRUD.GetAll();
            return list;
        }

        public bool Save(ReservedRoom reservedRoom)
        {
            try
            {
                reservedRoomCRUD.Create(reservedRoom);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error saving Reserved Room: {ex.Message}");
                return false;
            }
        }


        public bool Delete(int reservationId, int roomId)
        {
            try
            {
                reservedRoomCRUD.Delete(reservationId, roomId);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error deleting Reserved Room: {ex.Message}");
                return false;
            }
        }

        public ReservedRoom GetById(int reservationId, int roomId)
        {
            return reservedRoomCRUD.GetById(reservationId, roomId);
        }
    }
}
