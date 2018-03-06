using HumanResources.Consumers;
using HumanResources.Messaging;
using System;
using MassTransit;

namespace HumanResources
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Employee service";

            var bus = BusConfigurator.ConfigureBus((cfg, host) =>
            {
                cfg.ReceiveEndpoint(host, RabbitMqConstants.RegisterEmployeeServiceQueue, e =>
                {
                    e.Consumer<RegisterEmployeeCommandConsumer>();
                });
            });

            bus.Start();

            Console.WriteLine("Listening for notification events.. Press enter to exit");
            Console.ReadLine();

            bus.Stop();
        }
    }
}