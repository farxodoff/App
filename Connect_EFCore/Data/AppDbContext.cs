using System;
using System.Collections.Generic;
using System.Text;
using Connect_EFCore.Entities;
using Microsoft.EntityFrameworkCore;

namespace Connect_EFCore.Data
{
    public class AppDbContext : DBContext
    {
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Role> Roles { get; set; }
        

        public AppDbContext(DbContext context) : base(context)
        {
        }


    }
}
