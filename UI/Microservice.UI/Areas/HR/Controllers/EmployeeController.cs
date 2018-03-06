using HumanResources.Domain.Entities;
using HumanResources.Messaging.Commands;
using Microservice.UI.Areas.HR.Models.Employee;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Web.Mvc;
using Users.Messaging;

namespace Microservice.UI.Areas.HR.Controllers
{
    public class EmployeeController : Controller
    {
        public ActionResult New()
        {
            return View(new NewEmployeeViewModel
                {
                    JobRoles = new List<SelectListItem>
                    {
                        new SelectListItem
                        {
                            Selected = true,
                            Text = "Programmer",
                            Value = "1"
                        },
                        new SelectListItem
                        {
                            Selected = true,
                            Text = "System Analyst",
                            Value = "2"
                        },
                        new SelectListItem
                        {
                            Selected = true,
                            Text = "IT Manager",
                            Value = "3"
                        }
                    }
                });
        }

        [HttpPost]
        public async Task<ActionResult> New(NewEmployeeViewModel employee)
        {
            //Send RegisterOrderCommand
            var bus = BusConfigurator.ConfigureBus();

            var sendToUserRegistratioUri = new Uri(RabbitMqConstants.RabbitMqUri + HumanResources.Messaging.RabbitMqConstants.RegisterEmployeeServiceQueue);
            var endPoint = await bus.GetSendEndpoint(sendToUserRegistratioUri);

            await endPoint.Send<IRegisterEmployeeCommand>(new Employee
            {
                IdJobRole = employee.IdJobRole,
                Name = employee.Name,
                Salary = employee.Salary
            });

            return RedirectToAction("Sucess");
        }

        public ActionResult Sucess()
        {
            return View();
        }
    }
}