using BookMyShow.Commands;
using BookMyShow.DbFactory;
using BookMyShow.Exceptions;
using BookMyShow.Interfaces;
using BookMyShow.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BookMyShow.CommandHandlers
{
    public class RegisterCommandHandler: MovieBookingBaseFactory,IRegisterCommand
    {
        private readonly List<User> _registeredUsers;
        public RegisterCommandHandler()
        {
            _registeredUsers = _users;
        }

        public void RegisterUserToPortal(RegisterCommand registerCommand)
        {
            if(!_registeredUsers.Any(x=>x.UserId== registerCommand.RegisterUser.UserId))
            {
                _registeredUsers.Add(registerCommand.RegisterUser);
                Console.WriteLine($"Successfully Registered User {registerCommand.RegisterUser.UserName} with Id {registerCommand.RegisterUser.UserId}");
            }
            else
            {
                throw new UserAlreadyExistException("User already exists in the database records.");
            }
            
        }
    }
}
