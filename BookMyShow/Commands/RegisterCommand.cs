using BookMyShow.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookMyShow.Commands
{
    public class RegisterCommand
    {
        public RegisterCommand(User user)
        {
            RegisterUser = user;
        }

        public User RegisterUser { get; set; }
    }
}
