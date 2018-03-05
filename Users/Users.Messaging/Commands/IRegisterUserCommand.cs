
namespace Users.Messaging.Commands
{
    public interface IRegisterUserCommand
    {
        int UserId { get; }
        string Name { get; }
        string Username { get; }
        string Password { get; }
        string Email { get; }
    }
}