using System;
using System.Collections.Generic;
using System.Text;
using Connect_EFCore.Entities;

namespace Connect_EFCore.Services.Interfaces
{
    public interface IRoleRepository
    {
        IEnumerable<Role> GetAll();
        Role GetById(int id);
        IEnumerable<Role> GetWithEmployee();
    }
}
