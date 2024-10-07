using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PruebaNET_SantiagoPineda.DTOs.EmployeeDTO;
using PruebaNET_SantiagoPineda.Models;
using PruebaNET_SantiagoPineda.Repositories;

namespace PruebaNET_SantiagoPineda.Controllers.v1.Employees
{
    [ApiController]
    [Route("api/v1/employees")]
    [Tags("employee")]
    public class EmployeePostController : EmployeeController
    {
        public EmployeePostController(IEmployeeRepository employeeRepository) : base(employeeRepository)
        {
        }

        [HttpPost]
        public async Task<ActionResult<Employee>> Post([FromBody] EmployeeDTO user)
        {
            await _employeeRepository.Add(user);
            return Ok();
        }
    }
}