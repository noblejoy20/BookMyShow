using System;
using System.Collections.Generic;
using System.Text;

namespace BookMyShow.Exceptions
{
    public class ScreenAlreadyExistException : Exception
    {
        public ScreenAlreadyExistException(string message) : base(message)
        {

        }
    }
}
