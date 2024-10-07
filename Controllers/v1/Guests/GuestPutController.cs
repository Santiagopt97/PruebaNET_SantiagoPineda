using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PruebaNET_SantiagoPineda.DTOs.GuestDTO;
using PruebaNET_SantiagoPineda.Models;
using PruebaNET_SantiagoPineda.Repositories;

namespace PruebaNET_SantiagoPineda.Controllers.v1.Guests
{
    [ApiController]
    [Route("api/v1/guest")]
    [Tags("guest")]
    public class GuestPutController : GuestController
    {
        public GuestPutController(IGuestRepository guestRepository) : base(guestRepository)
        {
        }

        [HttpPut]
        [Authorize]
        public async Task<ActionResult<Guest>> Update([FromHeader]int id, [FromBody] GuestDTO user){
            await _guestRepository.Update(id, user);
            return Ok();
        }
    }
}