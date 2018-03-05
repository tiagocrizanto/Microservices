using System;
using MassTransit;
using Users.Messaging;
using Notification.Service.Consumers;

namespace Notification.Service
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Serviço de notificação";

            var bus = BusConfigurator.ConfigureBus((cfg, host) =>
            {
                cfg.ReceiveEndpoint(host, RabbitMqConstants.EmailNotificationServiceQueue, e =>
                {
                    e.Consumer<RegisteredUserConsumer>();
                });
            });

            bus.Start();

            Console.WriteLine("Listening for Order registered events.. Press enter to exit");
            Console.ReadLine();

            bus.Stop();
        }
    }
}