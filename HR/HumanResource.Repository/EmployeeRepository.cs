using HumanResources.Domain.Entities;
using System;

namespace HumanResource.Repository
{
    public class EmployeeRepository
    {
        public Guid AddEmployee(Employee employee)
        {
            return Guid.NewGuid();
        }
    }
}