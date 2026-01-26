using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Connect_EFCore.Entities;


namespace Connect_EFCore_WebAPI.Controllers
{
    [ApiController]
    [Route("controller")]
    public class EmployeeController : ControllerBase
    {
        [HttpGet(Name = "GetAllEmployee")]
        public IEnumerable<Employee> GetAllEmployees()
        {
            return _context.Employees.ToList();
        }
    }
}
