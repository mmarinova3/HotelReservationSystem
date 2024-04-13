using HotelReservationSystem.Entity;
using HotelReservationSystem.EntityCRUD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelReservationSystem.Controller
{
    public class UserController
    {
        private readonly UserCRUD userCRUD;

        public UserController()
        {
            userCRUD = new UserCRUD();
        }

        public List<User> GetUsers()
        {
            List<User> list = (List<User>)userCRUD.GetAll();
            return list;
        }

        public bool Save(User user)
        {
            try
            {
                if (UserExists(user.Username))
                {
                    return false;
                }

                userCRUD.Create(user);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error saving user: {ex.Message}");
                return false;
            }
        }


        public bool Update(string username, User updatedUser)
        {
            try
            {
                userCRUD.Update(username, updatedUser);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool Delete(string username)
        {
            try
            {
                userCRUD.Delete(username);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public User SearchByName(string username)
        {
            try
            {
                List<User> users = GetUsers();
                return users.FirstOrDefault(c => c.Username.Equals(username, StringComparison.OrdinalIgnoreCase));
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error searching city by name: {ex.Message}");
                return null;
            }
        }


        private bool UserExists(string username)
        {
            List<User> users = GetUsers();
            return users.Any(c => c.Username.Equals(username, StringComparison.OrdinalIgnoreCase));
        }

        public bool ValidateLogin(string username, string password)
        {
            User user = userCRUD.GetById(username);

            if (user != null && user.Password == password)
            {
                return true;
            }

            return false;
        }
    }
}