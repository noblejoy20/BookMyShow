using BookMyShow.Enums;
using BookMyShow.Models;
using BookMyShow.Services;
using System;

namespace BookMyShow
{
    public class EntryCounter
    {
        public static void Main(string[] args)
        {
            var theatre = new Theatre("Delhi");

            var bookingService = new BookingService();
            var registrationService = new RegistrationService();
            var screenService = new ScreenService();

            screenService.SetScreens(new Screen(theatre.TheatreId, "Singham", MovieType.Action, MovieLang.Hindi));
            screenService.SetScreens(new Screen(theatre.TheatreId, "Toy Story", MovieType.Drama, MovieLang.English));
            screenService.SetScreens(new Screen(theatre.TheatreId, "Mummy", MovieType.Horror, MovieLang.English));
            screenService.SetScreens(new Screen(theatre.TheatreId, "Kuruthi", MovieType.Action, MovieLang.Regional));

            registrationService.UserRegistration(new User("Noble Joy", "noblejoy20@gmail.com"));
        }
    }
}
