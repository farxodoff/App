using System;
using Connect_EFCore.Data;
using Connect_EFCore.Entities;
using Connect_EFCore.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Connect_EFCore.Services
{
    public class EmployeeService : BaseService, IEmployeeService
    {
        public EmployeeService(DbContext context) : base(context)
        {

        }

        // Methods in interface
        public IEnumerable<Employee> GetAllEmployees()
        {
            return _context.Employees.ToList();
        }

        public IEnumerable<string> GetEmployeesByDepartment(string departmentName)
        {
            return _context.Employees
                .Where(e => e.Department.Name == departmentName)
                .Select(e => e.FullName)
                .ToList();
        }

        public IEnumerable<string> GetEmployeesByRole(string roleName)
        {
            return _context.Employees
                .Where(e => e.Role.Name == roleName)
                .Select(e => e.FullName)
                .ToList();
        }

        public IEnumerable<Employee> GetEmployeesBySalary(decimal minSalary)
        {
            return _context.Employees
                .Where(e => e.Salary >= minSalary)
                .ToList();
        }

        public IEnumerable<Employee> GetEmployeesSkip(int count)
        {
            return _context.Employees
                .OrderBy(e => e.Id)
                .Skip(count)
                .ToList();
        }

        public IEnumerable<Employee> GetEmployeesTake(int count)
        {
            return _context.Employees
                .OrderBy(e => e.Id)
                .Take(count)
                .ToList();
        }

        public IEnumerable<Employee> GetEmployeesWithRoles()
        {
            return _context.Employees
                .Include(e => e.Role)
                .ToList();
        }

        public IEnumerable<Employee> OrderBySalary()
        {
            return _context.Employees
                .OrderBy(e => e.Salary)
                .ToList();
        }

        public IEnumerable<Employee> OrderBySalaryDescending()
        {
            return _context.Employees
                .OrderByDescending(e => e.Salary)
                .ToList();
        }

        public int CountEmployeesBySalary(decimal minSalary)
        {
            return _context.Employees
                .Count(e => e.Salary >= minSalary);
        }
        public void AddEmployee(Employee employee)
        {
            _context.Employees.Add(employee);
            _context.SaveChanges();
        }
        public decimal GetAverageSalary()
        {
           return _context.Employees.Average(x => x.Salary);
        }
        public decimal GetMaxSalary()
        {
            return _context.Employees.Max(x => x.Salary);
        }

        public decimal GetMinSalary()
        {
            return _context.Employees.Min(x => x.Salary);
        }

        public decimal GetTotalSalary()
        {
            return _context.Employees.Sum(x => x.Salary);
        }
    }
}
