using HotelReservationSystem.Entity;
using HotelReservationSystem.EntityCRUD;
using System;
using System.Collections.Generic;

namespace HotelReservationSystem.Controller
{
    public class ReservationController
    {
        ReservationCRUD reservationCRUD;

        public ReservationController()
        {
            reservationCRUD = new ReservationCRUD();
        }

        public List<Reservation> GetReservations()
        {
            List<Reservation> list = (List<Reservation>)reservationCRUD.GetAll();
            return list;
        }

        public bool Save(Reservation reservation)
        {
            try
            {
                reservationCRUD.Create(reservation);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error saving Reservation: {ex.Message}");
                return false;
            }
        }

        public bool Update(int id, Reservation updatedReservation)
        {
            try
            {
                reservationCRUD.Update(id, updatedReservation);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error updating Reservation: {ex.Message}");
                return false;
            }
        }

        public bool Delete(int id)
        {
            try
            {
                reservationCRUD.Delete(id);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error deleting Reservation: {ex.Message}");
                return false;
            }
        }

        public Reservation GetById(int id)
        {
            return reservationCRUD.GetById(id);
        }

        public Reservation GetLastAddedReservation()
        {
            return reservationCRUD.GetLastAddedReservation();
        }
    }
}
