using System;
using System.Collections.Generic;
using System.Text;

namespace BookMyShow.Models
{
    public class User
    {
        public User(string name, string email)
        {
            UserId = Guid.NewGuid();
            UserName = name;
            EmailId = email;
            TicketsBookingHistory = new List<Booking>();
        }
        public Guid UserId { get; set; }
        public string UserName { get; set; }
        public string EmailId { get; set; }
        public List<Booking> TicketsBookingHistory { get; set; }
    }
}
