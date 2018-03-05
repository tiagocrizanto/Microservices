using System.ServiceProcess;
using Users.Messaging;

namespace Users.Registration.Service
{
    partial class RegistrationService : ServiceBase
    {
        BusConfigurator bus;

        public RegistrationService()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            bus = BusConfigurator.ConfigureBus((cfg, host) =>
                {
                    cfg.ReceiveEndpoint(host, RabbitMqConstants.EmailNotificationServiceQueue, e =>
                    {
                        e.Consumer<OrderRegisteredConsumer>();
                    });
                });
        }

        protected override void OnStop()
        {
            // TODO: Add code here to perform any tear-down necessary to stop your service.
        }
    }
}
