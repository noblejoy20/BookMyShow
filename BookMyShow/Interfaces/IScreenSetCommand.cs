using BookMyShow.Commands;
using BookMyShow.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookMyShow.Interfaces
{
    public interface IScreenSetCommand
    {
        void SetScreens(ScreenSetCommand screenCmd);
        bool IsSeatAvailable(SeatCheckCommand seatCmd);
        List<Screen> FilterScreens(ScreenFilterCommand filterCmd);
    }
}
