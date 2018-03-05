using System;
using MassTransit;
using Users.Messaging;
using Users.Registration.Service.Consumers;

namespace Users.Registration.Service
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Registration service";

            var bus = BusConfigurator.ConfigureBus((cfg, host) =>
            {
                cfg.ReceiveEndpoint(host, RabbitMqConstants.RegisterUserServiceQueue, e =>
                {
                    e.Consumer<RegisterUserCommandConsumer>();

                });
            });

            bus.Start();

            Console.WriteLine("Listening for Register order commands.. Press enter to exit");
            Console.ReadLine();

            bus.Stop();
        }
    }
}
