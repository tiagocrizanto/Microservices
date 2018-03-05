
namespace Users.Messaging.Events
{
    public interface IRegisteredUserEvent
    {
        int UserId { get; }
        string Name { get; }
        string Username { get; }
        string Password { get; }
        string Email { get; }
    }
}
