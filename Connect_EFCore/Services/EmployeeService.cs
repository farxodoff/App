using Connect_EFCore.Data;
using Connect_EFCore.Entities;
using Connect_EFCore.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Connect_EFCore.Services
{
    public class EmployeeService : IEmployeeService
    {

        // Methods in interface
        public IEnumerable<Employee> GetAllEmployees()
        {
           using var context = new AppDbContext();

            return context.Employees.ToList();
        }

        public IEnumerable<string> GetEmployeesByDepartment(string departmentName)
        {
            using var context = new AppDbContext();

            return context.Employees
                .Where(e => e.Department.Name == departmentName)
                .Select(e => e.FullName)
                .ToList();
        }

        public IEnumerable<string> GetEmployeesByRole(string roleName)
        {
            using var context = new AppDbContext();

            return context.Employees
                .Where(e => e.Role.Name == roleName)
                .Select(e => e.FullName)
                .ToList();
        }

        public IEnumerable<Employee> GetEmployeesBySalary(decimal minSalary)
        {
            using var context = new AppDbContext();

            return context.Employees
                .Where(e => e.Salary >= minSalary)
                .ToList();
        }

        public IEnumerable<Employee> GetEmployeesSkip(int count)
        {
            using var context = new AppDbContext();

            return context.Employees
                .OrderBy(e => e.Id)
                .Skip(count)
                .ToList();
        }

        public IEnumerable<Employee> GetEmployeesTake(int count)
        {
            using var context = new AppDbContext();

            return context.Employees
                .OrderBy(e => e.Id)
                .Take(count)
                .ToList();
        }

        public IEnumerable<Employee> GetEmployeesWithRoles()
        {
            using var context = new AppDbContext();

            return context.Employees
                .Include(e => e.Role)
                .ToList();
        }

        public IEnumerable<Employee> OrderBySalary()
        {
            using var context = new AppDbContext();

            return context.Employees
                .OrderBy(e => e.Salary)
                .ToList();
        }

        public IEnumerable<Employee> OrderBySalaryDescending()
        {
            using var context = new AppDbContext();

            return context.Employees
                .OrderByDescending(e => e.Salary)
                .ToList();
        }

        public int CountEmployeesBySalary(decimal minSalary)
        {
            using var context = new AppDbContext();

            return context.Employees
                .Count(e => e.Salary >= minSalary);
        }
        public void AddEmployee(Employee employee)
        {
            using (var context = new AppDbContext())
            {
                context.Employees.Add(employee);
                context.SaveChanges();
            }
        }
        public decimal GetAverageSalary()
        {
            using (var context = new AppDbContext())
            
                return context.Employees.Average(x => x.Salary);
            
        }
        public decimal GetMaxSalary()
        {
            using (var context = new AppDbContext())
            
                return context.Employees.Max(x => x.Salary);
            
        }

        public decimal GetMinSalary()
        {
            using (var context = new AppDbContext())
            
                return context.Employees.Min(x => x.Salary);
            
        }

        public decimal GetTotalSalary()
        {
            using (var context = new AppDbContext())
            
                return context.Employees.Sum(x => x.Salary);
            
        }
    }
}
