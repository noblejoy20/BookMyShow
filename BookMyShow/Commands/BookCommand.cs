using BookMyShow.Models;
using System;

namespace BookMyShow.Commands
{
    public class BookCommand
    {
        public BookCommand(Guid userId, Screen screen, int seatNo)
        {
            UserId = userId;
            ScreenInfo = screen;
            SeatNumber = seatNo;
        }

        public Guid UserId { get; set; }
        public Screen ScreenInfo { get; set; }
        public int SeatNumber { get; set; }
    }
}