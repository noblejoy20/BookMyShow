using BookMyShow.Commands;
using BookMyShow.DbFactory;
using BookMyShow.Exceptions;
using BookMyShow.Interfaces;
using BookMyShow.Models;
using System.Collections.Generic;
using System.Linq;

namespace BookMyShow.CommandHandlers
{
    public class BookingCommandHandler : MovieBookingBaseFactory, IBookingCommand
    {
        private readonly List<User> _registeredUsers;
        private readonly List<Screen> _registeredScreens;
        public BookingCommandHandler()
        {
            _registeredUsers = _users;
            _registeredScreens = GetScreens();
        }

        public Booking BookTicket(BookCommand bookCmd)
        {
            
            if (!_registeredUsers.Any(r => r.UserId == bookCmd.UserId))
            {
                throw new InvalidUserException("Invalid User.");
            }
            if (bookCmd.SeatNumber > bookCmd.ScreenInfo.Seats.Count || bookCmd.SeatNumber < bookCmd.ScreenInfo.Seats.Count)
            {
                throw new InvalidSeatException("Invalid Seat");
            }
            if (bookCmd.ScreenInfo.Seats[bookCmd.SeatNumber].IsBooked)
            {
                throw new SeatNotAvailableException("Seat is already booked.");
            }
            var user = _registeredUsers.Where(r => r.UserId == bookCmd.UserId).FirstOrDefault();
            var newTicket = new Booking
            {
                UserId = bookCmd.UserId,
                TheatreId = bookCmd.ScreenInfo.TheatreId,
                ScreenId = bookCmd.ScreenInfo.ScreenId,
                MovieName = bookCmd.ScreenInfo.MovieName,
                Genrie = bookCmd.ScreenInfo.Genrie,
                Language = bookCmd.ScreenInfo.Language,
                Price = GetPricings(bookCmd.ScreenInfo.Language),
                SeatNumber = bookCmd.ScreenInfo.Seats[bookCmd.SeatNumber].SeatNo
            };
            user.TicketsBookingHistory.Add(newTicket);
            bookCmd.ScreenInfo.Seats[bookCmd.SeatNumber].IsBooked = true;
            _bookingHistory.Add(newTicket);
            return newTicket;
        }

        public bool CancelTicket(CancelCommand cmd)
        {
            var user = _registeredUsers.Where(r => r.UserId == cmd.UserId).FirstOrDefault();
            user.TicketsBookingHistory.Remove(user.TicketsBookingHistory.Where(x => x.SeatNumber == cmd.SeatNumber).FirstOrDefault());
            cmd.ScreenInfo.Seats[cmd.SeatNumber].IsBooked = false;
            return true;
        }
    }
}