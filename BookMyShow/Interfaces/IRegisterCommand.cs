using BookMyShow.Commands;

namespace BookMyShow.Interfaces
{
    public interface IRegisterCommand
    {
        void RegisterUserToPortal(RegisterCommand user);
    }
}