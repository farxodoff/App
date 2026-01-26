using Connect_EFCore.Entities;
using Connect_EFCore.Services;
using Connect_EFCore.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;


namespace Connect_EFCore_WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EmployeeController : ControllerBase
    {


        private readonly EmployeeService _employeeService;

        public EmployeeController(EmployeeService employeeService)
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
