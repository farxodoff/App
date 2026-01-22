using System;
using System.Collections.Generic;
using System.Text;
using Connect_EFCore.Data;
using Connect_EFCore.Entities;
using Microsoft.EntityFrameworkCore;

namespace Connect_EFCore.Repositories
{
    public class RoleRepository
    {
        private readonly AppDbContext _context;

        public RoleRepository(AppDbContext context)
        {
            _context = context; 
        }

        public IEnumerable<Role> GetAll()
        {
            return _context.Roles
                .AsNoTracking()
                .ToList();
        }

        public Role GetById(int id)
        {
            return _context.Roles
                .Include(r => r.Name)
                .FirstOrDefault(r => r.Id == id);
        }

        public IEnumerable<Role> GetWithEmployees()
        {
            return _context.Roles
                .Include(r => r.Name)
                .ToList();
        }


    }
}
