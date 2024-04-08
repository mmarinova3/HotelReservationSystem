using HotelReservationSystem.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelReservationSystem.Entity
{
    public class Reservation
    {
        public int Id { get; set; }
        public Guest Guest { get; set; }
        public Employee Employee { get; set; }
        public DateTime ReservationDate { get; set; }
        public int GuestNumber { get; set; }
    }
}
