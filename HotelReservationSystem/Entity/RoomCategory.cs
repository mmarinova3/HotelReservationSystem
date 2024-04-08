using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelReservationSystem.Entity
{
    public class RoomCategory
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int MaxCapacity { get; set; }
    }
}
