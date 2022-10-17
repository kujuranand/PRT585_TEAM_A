using _2DataAccessLayer.Context;
using _2DataAccessLayer.Context.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace WebApplication3tierApp.Controllers
{
    [ApiController]
    [Route("/api/employees")]
    public class EmployeesController : Controller
    {
        private readonly DBEntitiesContext _dBEntitiesContext;

        public EmployeesController(DBEntitiesContext dBEntitiesContext)
        {
            _dBEntitiesContext = dBEntitiesContext;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllEmployees() 
        {
            var employees = await _dBEntitiesContext.Employees.ToListAsync();
            return Ok(employees);
        }

        [HttpPost]
        public async Task<IActionResult> AddEmployee([FromBody] Employee employeeRequest)
        { 
            employeeRequest.Id = Guid.NewGuid();
            await _dBEntitiesContext.Employees.AddAsync(employeeRequest);
            await _dBEntitiesContext.SaveChangesAsync();
            return Ok(employeeRequest);
        }

        [HttpGet]
        [Route("{id:Guid}")]
        public async Task<IActionResult> GetEmployee([FromRoute] Guid id)
        {
            var employee =
                await _dBEntitiesContext.Employees.FirstOrDefaultAsync(x => x.Id == id);

            if (employee == null)
            {
                return NotFound();
            }

            return Ok(employee);
        }
        [HttpPut]
        [Route("{id:Guid}")]
        public async Task<IActionResult> UpdateEmployee([FromRoute] Guid id, Employee updateEmployeeRequest)
        {
            var employee = await _dBEntitiesContext.Employees.FindAsync(id);

            if (employee == null)
            {
                return NotFound();
            }

            employee.Name = updateEmployeeRequest.Name;
            employee.Email = updateEmployeeRequest.Email;
            employee.Phone = updateEmployeeRequest.Phone;
            employee.Salary = updateEmployeeRequest.Salary;
            employee.Department = updateEmployeeRequest.Department;

            await _dBEntitiesContext.SaveChangesAsync();

            return Ok(employee);
        }

        [HttpDelete]
        [Route("{id:Guid}")]
        public async Task<IActionResult> DeleteEmployee([FromRoute] Guid id)
        {
            var employee = await _dBEntitiesContext.Employees.FindAsync(id);

            if (employee == null)
            {
                return NotFound();
            }

            _dBEntitiesContext.Employees.Remove(employee);
            await _dBEntitiesContext.SaveChangesAsync();

            return Ok(employee);
        }
    }
}