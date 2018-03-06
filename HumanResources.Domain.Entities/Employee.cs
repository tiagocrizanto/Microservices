using System;

namespace HumanResources.Domain.Entities
{
    public class Employee
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int IdJobRole { get; set; }
        public double Salary { get; set; }

        public virtual JobRole Jobrole { get; set; }
    }
}