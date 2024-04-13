using HotelReservationSystem.Entity;
using HotelReservationSystem.EntityCRUD;
using System;
using System.Collections.Generic;

namespace HotelReservationSystem.Controller
{
    public class GuestController
    {
        ReservationCRUD guestCRUD;
        public GuestController()
        {
            guestCRUD = new ReservationCRUD();
        }

        public List<Reservation> GetGuests()
        {
            List<Reservation> list = (List<Reservation>)guestCRUD.GetAll();
            return list;
        }

        public bool Save(Reservation guest)
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

        public bool Update(int id, Reservation updatedGuest)
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

        public Reservation GetById(int id)
        {
            return guestCRUD.GetById(id);
        }
    }
}
