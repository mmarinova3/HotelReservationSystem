using System;
using System.Collections.Generic;
using System.Linq;
using HotelReservationSystem.Entity;
using HotelReservationSystem.EntityCRUD;

namespace HotelReservationSystem.Controller
{
    public class CityController
    {
        private readonly CityCRUD cityCRUD;

        public CityController()
        {
            cityCRUD = new CityCRUD();
        }

        public List<City> GetCities()
        {
            List<City> list = (List<City>)cityCRUD.GetAll();
            return list;
        }

        public bool SaveCity(City city)
        {
            try
            {
                if (CityExists(city.CityName))
                {
                    Console.WriteLine("City with the same name already exists in the database.");
                    return false;
                }

                cityCRUD.Create(city);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error saving city: {ex.Message}");
                return false;
            }
        }

        public bool UpdateCity(int cityId, City updatedCity)
        {
            try
            {
                cityCRUD.Update(cityId, updatedCity);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error updating city: {ex.Message}");
                return false;
            }
        }

        public bool DeleteCity(int cityId)
        {
            try
            {
                cityCRUD.Delete(cityId);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error deleting city: {ex.Message}");
                return false;
            }
        }

        public City SearchCityByName(string cityName)
        {
            try
            {
                List<City> cities = GetCities();
                return cities.FirstOrDefault(c => c.CityName.Equals(cityName, StringComparison.OrdinalIgnoreCase));
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error searching city by name: {ex.Message}");
                return null;
            }
        }


        private bool CityExists(string cityName)
        {
            List<City> cities = GetCities();
            return cities.Any(c => c.CityName.Equals(cityName, StringComparison.OrdinalIgnoreCase));
        }

        
    }
}
