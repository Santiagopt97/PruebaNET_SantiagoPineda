using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PruebaNET_SantiagoPineda.DTOs.GuestDTO;
using PruebaNET_SantiagoPineda.Models;
using PruebaNET_SantiagoPineda.Repositories;

namespace PruebaNET_SantiagoPineda.Controllers.v1.Guests
{
    [ApiController]
    [Route("api/v1/guest")]
    [Tags("guest")]
    public class GuestPostController : GuestController
    {
        public GuestPostController(IGuestRepository guestRepository) : base(guestRepository)
        {
        }

        [HttpPost]
        public async Task<ActionResult<Guest>> Post([FromBody] GuestDTO guest)
        {
            await _guestRepository.Add(guest);
            return Ok();
        }
    }
}