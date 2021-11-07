using BookMyShow.CommandHandlers;
using BookMyShow.Commands;
using BookMyShow.Interfaces;
using BookMyShow.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookMyShow.Services
{
    public class ScreenService
    {
        private readonly IScreenSetCommand _screenSetCommand;

        public ScreenService()
        {
            _screenSetCommand = new ScreenCommandHandler();
        }
        public void SetScreens(Screen screen)
        {
            try
            {
                _screenSetCommand.SetScreens(new ScreenSetCommand(screen));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }          
        }

        public void SeatAvailability(Guid ScreenId)
        {
            try
            {
                _screenSetCommand.IsSeatAvailable(new SeatCheckCommand(ScreenId));
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
        }

        public List<Screen> FilterScreens(string MovieName)
        {
            try
            {
                return _screenSetCommand.FilterScreens(new ScreenFilterCommand(MovieName));
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
            return null;
        }

    }
}
