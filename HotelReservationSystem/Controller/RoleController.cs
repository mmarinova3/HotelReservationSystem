using HotelReservationSystem.Entity;
using HotelReservationSystem.EntityCRUD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelReservationSystem.Controller
{
    public class RoleController
    {
        private readonly RoleCRUD roleCRUD;

        public RoleController()
        {
           roleCRUD = new RoleCRUD();
        }


        public List<Role> GetRoles()
        {
            List<Role> list = (List<Role>)roleCRUD.GetAll();
            return list;
        }
    }
}
