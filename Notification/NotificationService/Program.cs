using System;
using MassTransit;
using Users.Messaging;
using NotificationService.Consumers;

namespace NotificationService
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

            Console.WriteLine("Listening for notification events.. Press enter to exit");
            Console.ReadLine();

            bus.Stop();
        }
    }
}