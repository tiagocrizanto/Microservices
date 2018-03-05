using MassTransit;
using System;
using System.Threading.Tasks;
using Users.Messaging.Events;

namespace Notification.Service.Consumers
{
    public class RegisteredUserConsumer : IConsumer<IRegisteredUserEvent>
    {
        public async Task Consume(ConsumeContext<IRegisteredUserEvent> context)
        {
            await Console.Out.WriteLineAsync("Email " + context.Message.Email + " enviado com sucesso para o usuário " + context.Message.Name);
        }
    }
}