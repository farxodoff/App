using System;
using System.Collections.Generic;
using System.Text;
using Connect_EFCore.Entities;

namespace Connect_EFCore.Services.Interfaces
{
    public interface IEmployeeService
    {
        IEnumerable<Employee> GetAllEmployees();
        IEnumerable<Employee> GetEmployeesBySalary(decimal minSalary);
        IEnumerable<Employee> OrderBySalary();
        IEnumerable<Employee> OrderBySalaryDescending();
        decimal GetAverageSalary();
        decimal GetTotalSalary();
        decimal GetMaxSalary();
        decimal GetMinSalary();
        int CountEmployeesBySalary(decimal minSalary);
        void AddEmployee(Employee employee);
        IEnumerable<string> GetEmployeesByDepartment(string departmentName);
        IEnumerable<string> GetEmployeesByRole(string roleName);
        IEnumerable<Employee> GetEmployeesWithRoles();
        IEnumerable<Employee> GetEmployeesSkip(int count);
        IEnumerable<Employee> GetEmployeesTake(int count);
    }
}
