using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PruebaNET_SantiagoPineda.Repositories;

namespace PruebaNET_SantiagoPineda.Controllers.v1.Bokkings
{
    [ApiController]
    [Route("api/v1/bookings")]
    [Tags("bookings")]
    public class BokingGetController : BokkingController
    {
        public BokingGetController(IBookingRepository bookingRepository) : base(bookingRepository)
        {
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Models.Booking>> Get(int id)
        {
            var booking = await _bookingRepository.GetById(id);
            if (booking == null)
            {
                return NotFound();
            }
            return Ok(booking);
        }
    }
}