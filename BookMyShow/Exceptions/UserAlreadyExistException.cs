using System;
using System.Collections.Generic;
using System.Text;

namespace BookMyShow.Exceptions
{
    public class UserAlreadyExistException: Exception
    {
        public UserAlreadyExistException(string message):base(message)
        {

        }
    }
}
