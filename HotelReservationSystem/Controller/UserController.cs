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
        private UserCRUD userCRUD;

        public UserController()
        {
            userCRUD = new UserCRUD();
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