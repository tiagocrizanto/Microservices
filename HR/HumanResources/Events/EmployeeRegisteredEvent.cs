using HumanResources.Messaging.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanResources.Events
{
    public class EmployeeRegisteredEvent
    {
        private IRegisterEmployeeCommand command;
        private int userId;

        public EmployeeRegisteredEvent(IRegisterEmployeeCommand command)
        {
            this.command = command;
        }

        public Guid Id { get { return command.Id; } }
        public string Name { get { return command.Name; } }
        public int IdJobrole { get { return command.IdJobRole; } }
        public double Salary { get { return command.Salary; } }
    }
}
