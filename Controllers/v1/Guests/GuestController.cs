using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PruebaNET_SantiagoPineda.Repositories;

namespace PruebaNET_SantiagoPineda.Controllers.v1.Guests
{
    [ApiController]
    [Route("api/v1/guest")]
    public class GuestController : ControllerBase
    {
        protected readonly IGuestRepository _guestRepository;
        
        public GuestController(IGuestRepository guestRepository)
        {
            _guestRepository = guestRepository;
        }
    }
}