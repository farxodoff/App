using System;
using System.Collections.Generic;
using System.Text;
using Connect_EFCore.Data;
using Connect_EFCore.Entities;
using Microsoft.EntityFrameworkCore;

namespace Connect_EFCore.Repositories
{
    public class DepartmentRepository
    {
        private readonly AppDbContext _context;

        public DepartmentRepository(AppDbContext context)
        {
            _context = context;
        }



        // Methods
        public IEnumerable<Department> GetAll()
        {
            return _context.Departments
                .AsNoTracking()
                .ToList();
        }

        public Department GetById(int id)
        {
            return _context.Departments
                .Include(d => d.Employees)
                .FirstOrDefault(d => d.Id == id);
        }

        public IEnumerable<Department> GetWithEmployees()
        {
            return _context.Departments
                .Include(d => d.Employees)
                .ToList();
        }

    }
}
