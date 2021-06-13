using SelfHostingConsole.Models;
using System.Collections.Generic;
using System.Web.Http;

namespace SelfHostingConsole.Controllers
{
    public class EmployeeController : ApiController
    {
        List<Employee> employees = new List<Employee>()
        {
            new Employee {FirstName = "Shishir", LastName="Peeru", Address="Thakurli"},
            new Employee {FirstName = "Shashank", LastName="Peeru", Address="Pune"},
            new Employee {FirstName = "Sadanand", LastName="Peeru", Address="Bunder"},
            new Employee {FirstName = "Seema", LastName="Peeru", Address="Keni"}
        };

        public IHttpActionResult GetAllEmployees()
        {
            return Ok(employees);
        }
    }
}
