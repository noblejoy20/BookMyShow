using BookMyShow.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookMyShow.Models
{
    public class Booking
    {
        public Guid UserId { get; set; }
        public Guid ScreenId { get; set; }
        public string MovieName { get; set; }
        public Guid TheatreId { get; set; }
        public MovieType Genrie { get; set; }
        public MovieLang Language { get; set; }
        public double Price { get; set; }
        public int SeatNumber { get; set; }
    }
}
