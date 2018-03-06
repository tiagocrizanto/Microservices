using System;
using System.Collections.Generic;
using System.Web.Mvc;

namespace Microservice.UI.Areas.HR.Models.Employee
{
    public class NewEmployeeViewModel
    {
        public string Name { get; set; }
        public int IdJobRole { get; set; }
        public double Salary { get; set; }

        public IEnumerable<SelectListItem> JobRoles { get; set; }
    }
}