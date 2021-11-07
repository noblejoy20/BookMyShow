using BookMyShow.CommandHandlers;
using BookMyShow.Commands;
using BookMyShow.Interfaces;
using BookMyShow.Models;
using System;

namespace BookMyShow.Services
{
    public class BookingService
    {
        private readonly IBookingCommand _bookingCommand;

        public BookingService()
        {
            _bookingCommand = new BookingCommandHandler();
        }

        public void BookSeat(Guid UserId, Screen show, int seatNo)
        {
            try
            {
                _bookingCommand.BookTicket(new BookCommand(UserId, show, seatNo));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void CancelSeat(Guid UserId, Screen show, int seatNo)
        {
            try
            {
                _bookingCommand.CancelTicket(new CancelCommand(UserId, show, seatNo));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}