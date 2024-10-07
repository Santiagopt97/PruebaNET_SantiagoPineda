using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PruebaNET_SantiagoPineda.Config;
using PruebaNET_SantiagoPineda.Data;
using PruebaNET_SantiagoPineda.DTOs.Auth;
using PruebaNET_SantiagoPineda.DTOs.EmployeeDTO;
using PruebaNET_SantiagoPineda.Models;
using PruebaNET_SantiagoPineda.Repositories;

namespace PruebaNET_SantiagoPineda.Services
{
    public class EmployeeService : IEmployeeRepository
    {
        protected readonly ApplicationDbContext _context;
        protected readonly Utilities _utilities;
        public EmployeeService(ApplicationDbContext context, Utilities utilities)
        {
            _context = context;
            _utilities = utilities;
        }
        public async Task Add(EmployeeDTO user)
        {
            user.Password = _utilities.EncryptSHA256(user.Password);
            var user1 = new Employee
            {
                Id = user.Id,
                FirstName = user.FirstName,
                LastName = user.LastName,
                Email = user.Email,
                IdentificationNumber = user.IdentificationNumber,
                Password = user.Password, 
            };
            _context.Employees.Add(user1);
            await _context.SaveChangesAsync();
        }

        public async Task<string> Login(LoginDTO login)
        {
            var user1 = await _context.Employees.FirstOrDefaultAsync(u => u.Email == login.Email);

            if (user1 != null)
            {
                if (user1.Password == _utilities.EncryptSHA256(login.Password)) //valida la contraseña que sea igual a la del hasheo
                {
                        var token = _utilities.GenerateJwtToken(user1);
                        return token;
                }
                return "usuario o contraseña invalida";
            }
            return "usuario o contraseña invalida";
        }
    }
}