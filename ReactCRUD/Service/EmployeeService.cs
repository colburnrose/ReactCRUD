using ReactCRUD.Data;
using ReactCRUD.Models;
using ReactCRUDAPP.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReactCRUDAPP.Service
{
    public class EmployeeService : IEmployee
    {
        private readonly ApplicationDbContext _db;
        public async Task CreateEmployeeAsync(Employee employee)
        {
            _db.Employees.Add(employee);
            await _db.SaveChangesAsync();
        }

        public async Task DeleteEmployee(int id)
        {
            var emp = GetById(id);
            _db.Employees.Remove(emp);
            await _db.SaveChangesAsync();
        }

        public IEnumerable<Employee> GetAllEmployees()
        {
            return _db.Employees.ToList();
        }

        public Employee GetById(int id)
        {
            return _db.Employees.Where(x => x.Id == id).FirstOrDefault();        
        }

        public async Task UpdateEmployeeAsync(Employee employee)
        {
            _db.Employees.Update(employee);
            await _db.SaveChangesAsync();
        }
    }
}
