using System;

namespace BookMyShow.Commands
{
    public class SeatCheckCommand
    {
        public SeatCheckCommand(Guid guid)
        {
            ScreenId = guid;
        }

        public Guid ScreenId { get; set; }
    }
}