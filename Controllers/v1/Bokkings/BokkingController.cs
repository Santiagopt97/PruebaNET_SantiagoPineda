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
    public class BokkingController : ControllerBase
    {
        protected readonly IBookingRepository _bookingRepository;
        
        public BokkingController(IBookingRepository bookingRepository)
        {
            _bookingRepository = bookingRepository;
        }
        
    }
}