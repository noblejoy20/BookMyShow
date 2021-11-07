using System;
using System.Collections.Generic;
using System.Text;

namespace BookMyShow.Exceptions
{
    public class SeatNotAvailableException:Exception
    {
        public SeatNotAvailableException(string message) : base(message)
        {

        }
    }
}
