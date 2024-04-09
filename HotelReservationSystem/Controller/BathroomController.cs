using HotelReservationSystem.Entity;
using HotelReservationSystem.EntityCRUD;
using System;
using System.Collections.Generic;
using System.Linq;

namespace HotelReservationSystem.Controller
{
    public class BathroomController
    {
        private readonly BathroomCRUD bathroomCRUD;

        public BathroomController()
        {
            bathroomCRUD = new BathroomCRUD();
        }

        public List<Bathroom> GetBathrooms()
        {
            List<Bathroom> list = (List<Bathroom>)bathroomCRUD.GetAll();
            return list;
        }

        public bool SaveBathroom(Bathroom bathroom)
        {
            try
            {
                bathroomCRUD.Create(bathroom);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error saving bathroom: {ex.Message}");
                return false;
            }
        }

        public bool UpdateBathroom(int bathroomId, Bathroom updatedBathroom)
        {
            try
            {
                bathroomCRUD.Update(bathroomId, updatedBathroom);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error updating bathroom: {ex.Message}");
                return false;
            }
        }

        public bool DeleteBathroom(int bathroomId)
        {
            try
            {
                bathroomCRUD.Delete(bathroomId);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error deleting bathroom: {ex.Message}");
                return false;
            }
        }

        public Bathroom SearchBathroomById(int bathroomId)
        {
            try
            {
                return bathroomCRUD.GetById(bathroomId);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error searching bathroom by ID: {ex.Message}");
                return null;
            }
        }

        private bool BathroomExistsById(int id)
        {
            List<Bathroom> bathrooms = GetBathrooms();
            return bathrooms.Any(b => b.Id.Equals(id));
        }
    }
}
