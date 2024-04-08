using HotelReservationSystem.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelReservationSystem.Entity
{
    public class Room
    {
        public int Id { get; set; }
        public int Floor { get; set; }
        public RoomCategory RoomCategory { get; set; }
        public Bathroom Bathroom { get; set; }
    }
}