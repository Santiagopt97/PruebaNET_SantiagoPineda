using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PruebaNET_SantiagoPineda.Repositories;

namespace PruebaNET_SantiagoPineda.Controllers.v1.Guests
{
    [ApiController]
    [Route("api/v1/guest")]
    [Tags("guest")]
    public class GuestDeleteController : GuestController
    {
        public GuestDeleteController(IGuestRepository guestRepository) : base(guestRepository)
        {
        }

        [HttpDelete("{id}")]
        [Authorize]
        public async Task<IActionResult> Delete (int id){
            await _guestRepository.Delete(id);
            return NoContent();
        }
    }
}