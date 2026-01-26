using Connect_EFCore.Entities;
using Connect_EFCore.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;


namespace Connect_EFCore_WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EmployeeController : ControllerBase
    {


        private readonly IEmployeeService _employeeService;

        public EmployeeController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }

        [HttpGet]
        public IActionResult GetAllEmployee()
        {
            var employees = _employeeService.GetEmployeesWithRoles();
            return Ok(employees);
        }
    }
}
