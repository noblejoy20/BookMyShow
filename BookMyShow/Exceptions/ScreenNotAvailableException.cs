using System;
using System.Collections.Generic;
using System.Text;

namespace BookMyShow.Exceptions
{
    public class ScreenNotAvailableException:Exception
    {
        public ScreenNotAvailableException(string message):base(message)
        {

        }
    }
}
