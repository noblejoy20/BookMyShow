using BookMyShow.Commands;
using BookMyShow.Models;

namespace BookMyShow.Interfaces
{
    public interface IBookingCommand
    {
        Booking BookTicket(BookCommand bookCmd);
        bool CancelTicket(CancelCommand bookCmd);
    }
}