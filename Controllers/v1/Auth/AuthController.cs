using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PruebaNET_SantiagoPineda.DTOs.Auth;
using PruebaNET_SantiagoPineda.Repositories;

namespace PruebaNET_SantiagoPineda.Controllers.v1.Auth
{
    [ApiController]
    [Route("api/v1/auth")]
    public class AuthController : ControllerBase
    {
        protected readonly IEmployeeRepository _employeeRepository;
        
        public AuthController(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        [HttpPost]
        [Route("login")]
        public async Task<ActionResult<string>> login( LoginDTO login)
        {
            var token = await _employeeRepository.Login(login);
            return Ok($"Token: {token}");
        }
        
    }
}