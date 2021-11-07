using BookMyShow.Enums;
using BookMyShow.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookMyShow.DbFactory
{
    public abstract class MovieBookingBaseFactory
    {
        protected static List<User> _users;
        protected static List<Screen> _screens;
        protected static List<Booking> _bookingHistory;

        public MovieBookingBaseFactory()
        {
            _users = new List<User>();
            _screens = new List<Screen>();
            _bookingHistory = new List<Booking>();
        }

        public List<Screen> GetScreens()
        {
            return _screens;
        }
        public List<Booking> GetBookings()
        {
            return _bookingHistory;
        }
        public double GetPricings(MovieLang movieLang)
        {
            switch (movieLang)
            {
                case MovieLang.English:
                    return 250;
                case MovieLang.Hindi:
                    return 100;
                case MovieLang.Regional:
                    return 50;
                default:
                    break;
            }
            return 0;
        }
    }
}
