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
        public int CreateEmployeeAsync(Employee employee)
        {
            try
            {
                _db.Employees.Add(employee);
                _db.SaveChanges();
                return 1;
            }
            catch
            {
                throw;
            }
        }

        public int DeleteById(int id)
        {
            try
            {
                var emp = GetById(id);
                _db.Employees.Remove(emp);
                _db.SaveChanges();
                return 1;
            }
            catch
            {
                throw;
            }
        }

        public IEnumerable<Employee> GetAllEmployees()
        {
            try
            {
                return _db.Employees.ToList();
            }
            catch
            {
                throw;
            }
        }

        public Employee GetById(int id)
        {
            return _db.Employees.Where(x => x.Id == id).FirstOrDefault();        
        }

        public int UpdateEmployeeAsync(Employee employee)
        {
            try
            {
                _db.Employees.Update(employee);
                _db.SaveChanges();
                return 1;
            }
            catch
            {
                throw;
            }
        }
    }
}
