using BookMyShow.Commands;
using BookMyShow.DbFactory;
using BookMyShow.Exceptions;
using BookMyShow.Interfaces;
using BookMyShow.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BookMyShow.CommandHandlers
{
    public class ScreenCommandHandler : MovieBookingBaseFactory, IScreenSetCommand
    {
        private readonly List<Screen> _registeredScreens;

        public ScreenCommandHandler()
        {
            _registeredScreens = GetScreens();
        }

        public List<Screen> FilterScreens(ScreenFilterCommand filterCmd)
        {
            var screenList = _registeredScreens.Where(f => f.MovieName == filterCmd.MovieName).ToList();
            if (screenList != null)
            {
                Console.WriteLine("These are the screens showing the movie:");
                foreach (var screens in screenList)
                {
                    Console.WriteLine($"{screens.ScreenId}");
                }
                return screenList;
            }
            else
            {
                throw new ScreenNotAvailableException("Screens for particular movie doesn't exist");
            }
        }

        public bool IsSeatAvailable(SeatCheckCommand seatCmd)
        {
            if (_registeredScreens.Any(x => x.ScreenId == seatCmd.ScreenId))
            {
                var answer = _registeredScreens.Where(x => x.ScreenId == seatCmd.ScreenId).FirstOrDefault().Seats.Any(s => !s.IsBooked);
                if (answer)
                {
                    Console.WriteLine("Seats are available.");
                    return true;
                }
                else
                {
                    throw new SeatNotAvailableException("Housefull.");
                }
            }
            return false;

        }

        public void SetScreens(ScreenSetCommand screenCmd)
        {
            if (_registeredScreens.Any(s => s.ScreenId == screenCmd.ScreenSet.ScreenId))
            {
                _registeredScreens.Add(screenCmd.ScreenSet);
                Console.WriteLine($"Successfully Registered Screen for {screenCmd.ScreenSet.MovieName} with Id {screenCmd.ScreenSet.ScreenId}");
            }
            else
            {
                throw new ScreenAlreadyExistException("Screen is already available for use.");
            }
        }
    }
}
