using System;
using System.Collections.Generic;
using System.Text;

namespace BookMyShow.Models
{
    public class Seat
    {
        private static int counter = 1;
        public Seat()
        {
            SeatNo = counter;
            IsBooked = false;
        }
        public int SeatNo { get; set; }
        public bool IsBooked { get; set; }
    }
}
