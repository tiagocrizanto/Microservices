using System;

namespace HumanResources.Messaging.Events
{
    public interface IRegisteredEmployeeEvent
    {
        Guid Id { get; set; }
        string Name { get; set; }
        int IdJobRole { get; set; }
        double Salary { get; set; }
    }
}
