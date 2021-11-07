using System;
using System.Collections.Generic;
using System.Text;

namespace BookMyShow.Models
{
    public class Theatre
    {
        public Theatre(string address)
        {
            TheatreId = Guid.NewGuid();
            Address = address;
            Screens = new List<Screen>();

        }
        public Guid TheatreId { get; set; }
        public string Address { get; set; }
        public List<Screen> Screens { get; set; }
    }
}
