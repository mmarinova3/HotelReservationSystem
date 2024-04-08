using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelReservationSystem.Entity
{
    public class Guest
    {
        public string EGN { get; set; }
        public string Name { get; set; }
        public City City { get; set; }
        public string Address { get; set; }
        public string MobileNumber { get; set; }
    }
}