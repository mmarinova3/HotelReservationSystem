using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelReservationSystem.Entity
{
    public class Bathroom
    {
        public int Id { get; set; }
        public int Floor { get; set; }
        public string IsShared { get; set; }

    }
}