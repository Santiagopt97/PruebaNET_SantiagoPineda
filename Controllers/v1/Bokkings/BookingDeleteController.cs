using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PruebaNET_SantiagoPineda.Repositories;

namespace PruebaNET_SantiagoPineda.Controllers.v1.Bokkings
{
    [ApiController]
    [Route("api/v1/bookings")]
    [Tags("bookings")]
    public class BookingDeleteController : BokkingController
    {
        public BookingDeleteController(IBookingRepository bookingRepository) : base(bookingRepository)
        {
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete (int id){
            await _bookingRepository.Delete(id);
            return NoContent();
        }
    }
}