using System;
using System.Collections.Generic;
using System.Text;
using Connect_EFCore.Entities;

namespace Connect_EFCore.Services.Interfaces
{
    public interface IEmployeeRepository
    {
        // CRUD amallari uchun
        IEnumerable<Employee> GetAll();
        Employee GetById(int id);
        IEnumerable<Employee> GetWithIncludes();
        void Add(Employee employee);
        void Update(Employee employee);
        void Delete(int id);
        void SaveChanges();



    }
}
