using System;
using System.Collections.Generic;
using System.Text;

namespace BookMyShow.Commands
{
    public class ScreenFilterCommand
    {
        public ScreenFilterCommand(string movie)
        {
            MovieName = movie;
        }

        public string MovieName { get; set; }
    }
}
