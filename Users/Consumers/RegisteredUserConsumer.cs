using MassTransit;
using System.Threading.Tasks;
using Users.Messaging.Events;

namespace Users.Registration.Service.Consumers
{
    public class RegisteredUserConsumer : IConsumer<IRegisteredUserEvent>
    {

        public async Task Consume(ConsumeContext<IRegisteredUserEvent> context)
        {
            throw new System.NotImplementedException();
        }
    }
}
