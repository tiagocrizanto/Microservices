using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Users.Messaging
{
    public static class RabbitMqConstants
    {
        public const string RabbitMqUri = "rabbitmq://localhost/microservices/";
        public const string UserName = "guest";
        public const string Password = "guest";
        public const string RegisterUserServiceQueue = "registerorder.service";
        public const string EmailNotificationServiceQueue = "emailnotification.service";
    }
}
