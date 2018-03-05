using Users.Messaging.Commands;

namespace Users.Registration.Service.Events
{
    public class UserRegisteredEvent
    {
        private IRegisterUserCommand command;
        private int userId;

        public UserRegisteredEvent(IRegisterUserCommand command, int userId)
        {
            this.command = command;
            this.userId = userId;
        }

        public string Name { get { return command.Name; } }
        public string Username { get { return command.Username; } }
        public string Password { get { return command.Password; } }
        public string Email { get { return command.Email; } }
    }
}