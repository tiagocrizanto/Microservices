using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanResources.Messaging
{
    public static class RabbitMqConstants
    {
        public const string RabbitMqUri = "rabbitmq://localhost/microservices/";
        public const string UserName = "guest";
        public const string Password = "guest";
        public const string RegisterEmployeeServiceQueue = "registeremployee.service";
    }
}
