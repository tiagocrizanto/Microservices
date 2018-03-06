using System;

namespace HumanResources.Messaging.Commands
{
    public interface IRegisterEmployeeCommand
    {
        Guid Id { get; set; }
        string Name { get; set; }
        int IdJobRole { get; set; }
        double Salary { get; set; }
    }
}