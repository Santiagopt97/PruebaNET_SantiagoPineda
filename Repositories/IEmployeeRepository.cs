using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PruebaNET_SantiagoPineda.DTOs.Auth;
using PruebaNET_SantiagoPineda.DTOs.EmployeeDTO;

namespace PruebaNET_SantiagoPineda.Repositories
{
    public interface IEmployeeRepository
    {
         Task Add(EmployeeDTO product);
        Task<string> Login(LoginDTO login);

    }
}