using System;
using System.Collections.Generic;
using System.Text;

namespace BookMyShow.Exceptions
{
    public class InvalidSeatException:Exception
    {
        public InvalidSeatException(string message):base(message)
        {

        }
    }
}
