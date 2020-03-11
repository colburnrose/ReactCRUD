using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ReactCRUD.Models;
using ReactCRUDAPP.Service;

namespace ReactCRUDAPP.Controllers
{
    public class EmployeeController : Controller
    {
        EmployeeService employeeService = new EmployeeService();


        [HttpGet]
        [Route("api/Employee/Index")]
        public IEnumerable<Employee> Index()
        {
            return employeeService.GetAllEmployees();
        }

        [HttpPost]
        [Route("api/Employee/Create")]
        public int Create(Employee employee)
        {
            return employeeService.CreateEmployeeAsync(employee);
        }

        [HttpPut]
        [Route("api/Employee/Edit")]
        public int Edit(Employee employee)
        {
            return employeeService.UpdateEmployeeAsync(employee);
        }
        [HttpGet]
        [Route("api/Employee/Details/{id}")]
        public Employee Details(int id)
        {
            return employeeService.GetById(id);
        }

        [HttpDelete]
        [Route("api/Employee/Delete/{id}")]
        public int Delete(int id)
        {
            return employeeService.DeleteById(id);
        }
    }
}