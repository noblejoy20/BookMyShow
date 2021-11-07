using BookMyShow.CommandHandlers;
using BookMyShow.Commands;
using BookMyShow.Interfaces;
using BookMyShow.Models;
using System;

namespace BookMyShow.Services
{
    public class RegistrationService
    {
        private readonly IRegisterCommand _registerCommand;

        public RegistrationService()
        {
            _registerCommand = new RegisterCommandHandler();
        }

        public void UserRegistration(User user)
        {            
            try
            {
                var registerCmd = new RegisterCommand(user);
                _registerCommand.RegisterUserToPortal(registerCmd);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}