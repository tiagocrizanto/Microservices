using Microservice.UI.Models;
using System;
using System.Threading.Tasks;
using System.Web.Mvc;
using Users.Messaging;
using Users.Messaging.Commands;

namespace Microservice.UI.Controllers
{
    public class RegisterController : Controller
    {
        public ActionResult User()
        {
            return View(new UserViewModel());
        }

        [HttpPost]
        public async Task<ActionResult> User(UserViewModel user)
        {
            //Send RegisterOrderCommand
            var bus = BusConfigurator.ConfigureBus();

            var sendToUserRegistratioUri = new Uri(RabbitMqConstants.RabbitMqUri + RabbitMqConstants.RegisterUserServiceQueue);
            var endPoint = await bus.GetSendEndpoint(sendToUserRegistratioUri);

            await endPoint.Send<IRegisterUserCommand>(new Users.Domain.Entities.Users
                {
                    Email = user.Email,
                    Name = user.Name,
                    Password = user.Password,
                    Username = user.Username
                });

            return RedirectToAction("Registered");
        }

        public ActionResult Registered()
        {
            return View();
        }
    }
}