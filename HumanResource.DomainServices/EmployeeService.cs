using HumanResource.Repository;
using HumanResources.Domain.Entities;
using System;

namespace HumanResource.DomainServices
{
    public class EmployeeService
    {
        private EmployeeRepository employeeRepository;

        public EmployeeService()
        {
            employeeRepository = new EmployeeRepository();
        }

        public Guid AddEmployee(Employee employee)
        {
            return employeeRepository.AddEmployee(employee);
        }
    }
}