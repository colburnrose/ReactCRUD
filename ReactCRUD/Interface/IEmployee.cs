using ReactCRUD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReactCRUDAPP.Interface
{
    public interface IEmployee
    {
        Employee GetById(int id);
        IEnumerable<Employee> GetAllEmployees();
        int CreateEmployeeAsync(Employee employee);
        int UpdateEmployeeAsync(Employee employee);
        int DeleteById(int id);
    }
}
