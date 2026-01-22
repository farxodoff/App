using System;
using System.Collections.Generic;
using System.Text;
using Connect_EFCore.Entities;

namespace Connect_EFCore.Services.Interfaces
{
    public interface IDepartmentRepository
    {
        IEnumerable<Department> GetAll();
        Department GetById(int id);
        IEnumerable<Department> GetWithEmployee();
    }
}
