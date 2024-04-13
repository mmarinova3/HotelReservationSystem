using HotelReservationSystem.Entity;
using HotelReservationSystem.EntityCRUD;
using System;
using System.Collections.Generic;

namespace HotelReservationSystem.Controller
{
    public class GuestController
    {
       GuestCRUD guestCRUD;
        public GuestController()
        {
            guestCRUD = new GuestCRUD();
        }

        public List<Guest> GetGuests()
        {
            List<Guest> list = (List<Guest>)guestCRUD.GetAll();
            return list;
        }

        public bool Save(Guest guest)
        {
            try
            {
                guestCRUD.Create(guest);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error saving Guest: {ex.Message}");
                return false;
            }
        }

        public bool Update(int id, Guest updatedGuest)
        {
            try
            {
                guestCRUD.Update(id, updatedGuest);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error updating Guest: {ex.Message}");
                return false;
            }
        }

        public bool Delete(int id)
        {
            try
            {
                guestCRUD.Delete(id);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error deleting Guest: {ex.Message}");
                return false;
            }
        }

        public Guest GetById(int id)
        {
            return guestCRUD.GetById(id);
        }
    }
}
