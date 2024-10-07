using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PruebaNET_SantiagoPineda.DTOs.Auth
{
    public class LoginDTO
    {
        public required string Email { get; set; }
        public required string Password { get; set; }
    }
}