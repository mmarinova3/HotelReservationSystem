using HotelReservationSystem.Entity;
using HotelReservationSystem.EntityCRUD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelReservationSystem.Controller
{
    public class RoomCategoryController
    {
        RoomCategoryCRUD roomCategoryCRUD;
        public RoomCategoryController()
        {
            roomCategoryCRUD = new RoomCategoryCRUD();
        }

        public List<RoomCategory> GetCategories()
        {
            List<RoomCategory> list = (List<RoomCategory>)roomCategoryCRUD.GetAll();
            return list;
        }



        public bool Save(RoomCategory roomCategory)
        {
            try
            {
                if (CategoryExists(roomCategory.Name))
                {
                    Console.WriteLine("Room category with the same name already exists in the database.");
                    return false;
                }

                roomCategoryCRUD.Create(roomCategory);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error saving room category: {ex.Message}");
                return false;
            }
        }

        public bool Update(int id, RoomCategory updatedCategory)
        {
            try
            {
                roomCategoryCRUD.Update(id, updatedCategory);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error updating room category: {ex.Message}");
                return false;
            }
        }

        public bool Delete(int id)
        {
            try
            {
                roomCategoryCRUD.Delete(id);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error deleting city: {ex.Message}");
                return false;
            }
        }


        private bool CategoryExists(string categoryName)
        {
            List<RoomCategory> categories = GetCategories();
            return categories.Any(c => c.Name.Equals(categoryName, StringComparison.OrdinalIgnoreCase));
        }

        public RoomCategory GetById (int id)
        {
            return roomCategoryCRUD.GetById(id);
        } 
    }
}
