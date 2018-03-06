using HumanResource.DomainServices;
using HumanResources.Domain.Entities;
using HumanResources.Messaging.Commands;
using HumanResources.Messaging.Events;
using MassTransit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanResources.Consumers
{
    public class RegisterEmployeeCommandConsumer: IConsumer<IRegisterEmployeeCommand>
    {
        public async Task Consume(ConsumeContext<IRegisterEmployeeCommand> context)
        {
            var command = context.Message;

            var employeeService = new EmployeeService();

            //Store employee registration and get Id
            var id = employeeService.AddEmployee(new Employee
            {
                IdJobRole = command.IdJobRole,
                Name = command.Name,
                Salary = command.Salary
            });

            await Console.Out.WriteLineAsync("Employee " + command.Name + " successfully registered!");

            //notify subscribers that a order is registered
            //var employeeRegisteredEvent = new EmployeeRegisteredEvent(command);

            ////publish event
            //await context.Publish<IRegisteredEmployeeEvent>(employeeRegisteredEvent);
        }
    }
}