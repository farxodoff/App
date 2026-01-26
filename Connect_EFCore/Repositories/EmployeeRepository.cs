using System;
using System.Collections.Generic;
using System.Text;
using Connect_EFCore.Data;
using Connect_EFCore.Entities;
using Connect_EFCore.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Connect_EFCore.Repositories
{
    public class EmployeeRepository : IEmployeeRepository
    {
        public readonly AppDbContext _context;

        public EmployeeRepository(AppDbContext context)
        {
            _context = context;
        }






        // Interface metodlari
        public void Add(Employee employee)
        {
            _context.Employees.Add(employee);
        }


        public void Delete(int id)
        {
            var employee = _context.Employees.Find(id);

            if (employee != null)
            {
                _context.Employees.Remove(employee);
            }
        }

        public IEnumerable<Employee> GetAll()
        {
            return _context.Employees
                .AsNoTracking()
                //.Select(e => e.Id)
                .Include(e => e.Department)
                .Include(e => e.Role)
                .ToList();
        }

        public Employee GetById(int id)
        {
            return _context.Employees
                .Include(e => e.Department)
                .Include(e => e.Role)
                .FirstOrDefault(e => e.Id == id);
        }
        public IEnumerable<Employee> GetWithIncludes()
        {
            return _context.Employees
                .Include(e => e.Department)
                .Include(e => e.Role)
                .ToList();
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }

        public void Update(Employee employee)
        {
            _context.Employees.Update(employee);
        }
    }
}
