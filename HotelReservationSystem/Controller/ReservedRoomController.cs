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

        public bool Update(int id, ReservedRoom updatedReservedRoom)
        {
            try
            {
                reservedRoomCRUD.Update(id, updatedReservedRoom);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error updating Reserved Room: {ex.Message}");
                return false;
            }
        }

        public bool Delete(int id)
        {
            try
            {
                reservedRoomCRUD.Delete(id);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error deleting Reserved Room: {ex.Message}");
                return false;
            }
        }

        public ReservedRoom GetById(int id)
        {
            return reservedRoomCRUD.GetById(id);
        }
    }
}
