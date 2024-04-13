using HotelReservationSystem.Entity;
using HotelReservationSystem.EntityCRUD;
using System;
using System.Collections.Generic;


namespace HotelReservationSystem.Controller
{
    public class RoomController
    {
            RoomCRUD roomCRUD;
            public RoomController()
            {
                roomCRUD = new RoomCRUD();
            }

            public List<Room> GetRooms()
            {
                List<Room> list = (List<Room>)roomCRUD.GetAll();
                return list;
            }

            public bool Save(Room room)
            {
                try
                {
                    roomCRUD.Create(room);
                    return true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error saving Room: {ex.Message}");
                    return false;
                }
            }

            public bool Update(int id, Room updatedRoom)
            {
                try
                {
                    roomCRUD.Update(id, updatedRoom);
                    return true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error updating Room: {ex.Message}");
                    return false;
                }
            }

            public bool Delete(int id)
            {
                try
                {
                    roomCRUD.Delete(id);
                    return true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error deleting Room: {ex.Message}");
                    return false;
                }
            }



            public Room GetById(int id)
            {
                return roomCRUD.GetById(id);
            }
        }
}
