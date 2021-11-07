using BookMyShow.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookMyShow.Commands
{
    public class ScreenSetCommand
    {
        public ScreenSetCommand(Screen screen)
        {
            ScreenSet = screen;
        }
        public Screen ScreenSet { get; set; }
    }
}
