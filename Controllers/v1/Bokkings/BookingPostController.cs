using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PruebaNET_SantiagoPineda.DTOs.BookingDTO;
using PruebaNET_SantiagoPineda.Models;
using PruebaNET_SantiagoPineda.Repositories;

namespace PruebaNET_SantiagoPineda.Controllers.v1.Bokkings
{
    [ApiController]
    [Route("api/v1/bookings")]
    [Tags("bookings")]
    public class BookingPostController : BokkingController
    {
        public BookingPostController(IBookingRepository bookingRepository) : base(bookingRepository)
        {
        }

        [HttpPost]
        public async Task<ActionResult<Booking>> Post([FromBody] BookingDTO guest)
        {
            await _bookingRepository.Add(guest);
            return Ok();
        }
    }
}