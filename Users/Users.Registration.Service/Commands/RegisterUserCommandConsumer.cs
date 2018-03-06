using MassTransit;
using System;
using System.Threading.Tasks;
using Users.DomainService;
using Users.Messaging.Commands;
using Users.Messaging.Events;
using Users.Registration.Service.Events;

namespace Users.Registration.Service.Consumers
{
    public class RegisterUserCommandConsumer : IConsumer<IRegisterUserCommand>
    {
        public async Task Consume(ConsumeContext<IRegisterUserCommand> context)
        {
            var command = context.Message;

            var userService = new UserService();

            //Store order registration and get Id
            var id = userService.AddUser(new Domain.Entities.Users
            {
                Email = command.Email,
                Name = command.Name,
                Password = command.Password,
                Username = command.Username
            });

            await Console.Out.WriteLineAsync("Usuário " + command.Name + " registrado com sucesso!");

            //notify subscribers that a order is registered
            var orderRegisteredEvent = new UserRegisteredEvent(command, id);

            //publish event
            await context.Publish<IRegisteredUserEvent>(orderRegisteredEvent);
        }
    }
}