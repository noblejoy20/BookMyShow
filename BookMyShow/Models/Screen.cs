using BookMyShow.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookMyShow.Models
{
    public class Screen
    {
        public Screen(Guid theatreId,string moviename,MovieType movietype,MovieLang lang)
        {
            TheatreId = theatreId;
            MovieName = moviename;
            Genrie = movietype;
            Language = lang ;
            ScreenId = Guid.NewGuid();
            Seats = new List<Seat>(50);
        }
        public Guid ScreenId { get; set; }
        public string MovieName { get; set; }
        public Guid TheatreId { get; set; }
        public MovieType Genrie { get; set; }
        public MovieLang Language { get; set; }
        public List<Seat> Seats { get; set; }
    }
}
