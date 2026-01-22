using Connect_EFCore.Data;
using Connect_EFCore.Entities;
using Connect_EFCore.Services;
using Connect_EFCore.Services.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Connect_EFCore
{
    class Program
    {
        static void Main(string[] args)
        {
            var employeeService = new EmployeeService();

            // Get All
            var allEmployees = employeeService.GetAllEmployees();
            Console.WriteLine("Barcha xodimlar:");
            foreach (var e in allEmployees)
            {
                Console.WriteLine($"{e.Id} - {e.FullName} - {e.Salary}");
            }
            Console.WriteLine(Environment.NewLine);


            // By Department
            var deps = employeeService.GetEmployeesByDepartment("IT");
            Console.WriteLine("IT bo‘limidagi xodimlar:");
            foreach (var name in deps)
            {
                Console.WriteLine(name);
            }
            Console.WriteLine(Environment.NewLine);


            // By Salary
            var highSalary = employeeService.GetEmployeesBySalary(5000);
            Console.WriteLine("5000+ maoshli xodimlar:");
            foreach (var e in highSalary)
            {
                Console.WriteLine($"{e.FullName} - {e.Salary}");
            }
            Console.WriteLine(Environment.NewLine);


            // Count
            int count = employeeService.CountEmployeesBySalary(5000);
            Console.WriteLine($"5000 dan yuqori maosh oluvchilar Soni: {count}");
            Console.WriteLine(Environment.NewLine);


            // Add
            /*var addEmployee = new Employee
            {
                FullName = "Ali Valiyev",
                Salary = 5200,
                DepartmentId = 5,
                RoleId = 9
            };

            employeeService.AddEmployee(addEmployee);
            Console.WriteLine("Ishchi qo‘shildi");
            Console.WriteLine(Environment.NewLine);*/


            // Include
            var includeRole = employeeService.GetEmployeesWithRoles();

            foreach (var e in includeRole)
            {
                Console.WriteLine($"{e.Id}. {e.FullName} - {e.Role.Name}");
            }
            Console.WriteLine(Environment.NewLine);


            // OrderBy
            var asc = employeeService.OrderBySalary();
            foreach (var e in asc)
            {
                Console.WriteLine($"{e.Id}. {e.FullName} | {e.Salary}");
            }
            Console.WriteLine(Environment.NewLine);


            // OrderByDesc 
            var desc = employeeService.OrderBySalaryDescending();
            foreach (var e in desc)
            {
                Console.WriteLine($"{e.Id}. {e.FullName} | {e.Salary}");
            }
            Console.WriteLine(Environment.NewLine);


            // Average
            decimal average = employeeService.GetAverageSalary();
            Console.WriteLine($"Ishchilar o'rtacha maoshi = {average}");
            Console.WriteLine(Environment.NewLine);

            // Max
            decimal max = employeeService.GetMaxSalary();
            Console.WriteLine($"Eng katta oylik = {max}");
            Console.WriteLine(Environment.NewLine);


            // Min
            decimal min = employeeService.GetMinSalary();
            Console.WriteLine($"Eng kichik oylik = {min}");
            Console.WriteLine(Environment.NewLine);


            // Sum
            decimal sum = employeeService.GetTotalSalary();
            Console.WriteLine($"Totol oylik maosh = {sum}");
            Console.WriteLine(Environment.NewLine);

            // Take
            var takeEmployee = employeeService.GetEmployeesTake(5);

            Console.WriteLine("Birinchi 5 ta xodim:");
            foreach (var e in takeEmployee)
            {
                Console.WriteLine($"{e.Id} - {e.FullName} - {e.Salary}");
            }
            Console.WriteLine(Environment.NewLine);

            // Skip
            var skipEmployee = employeeService.GetEmployeesSkip(10);

            Console.WriteLine("Birinchi 10 ta xodimdan tashqarisi:");
            foreach (var e in skipEmployee)
            {
                Console.WriteLine($"{e.Id} - {e.FullName} - {e.Salary}");
            }
            Console.WriteLine(Environment.NewLine);



        }
    }
}