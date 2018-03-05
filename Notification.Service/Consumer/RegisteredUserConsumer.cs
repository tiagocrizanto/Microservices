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
            await Console.Out.WriteLineAsync("Usuário " + context.Message.Name + " cadastrado com sucesso!");
        }
    }
}
