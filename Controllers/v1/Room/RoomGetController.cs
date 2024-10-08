using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PruebaNET_SantiagoPineda.Repositories;

namespace PruebaNET_SantiagoPineda.Controllers.v1.Room
{
    [ApiController]
    [Route("api/v1/rooms")]
    [Tags("rooms")]
    public class RoomGetController : RoomController
    {
        public RoomGetController(IRoomRepository roomRepository) : base(roomRepository)
        {
        }

        [HttpGet]
        [Route("available")]
        public async Task<IActionResult> GetAvailableRooms()
        {
            var rooms = await _roomRepository.GetAvailable();
            return Ok(rooms);
        }

        [HttpGet("{id}")]
        [Authorize]
        public async Task<ActionResult<Models.Room>> GetById(int id)
        {
            var room = await _roomRepository.GetById(id);
            if (room == null)
            {
                return NotFound();
            }
            return Ok(room);
        }

        [HttpGet]
        [Authorize]
        public async Task<ActionResult> GetAllRooms(){
            var rooms = await _roomRepository.GetAll();
            return Ok(rooms);
        }

        [HttpGet]
        [Route("status")]
        public async Task<IActionResult> GetStatus()
        {
            var rooms = await _roomRepository.GetStatus();
            return Ok(rooms);
        }

        [HttpGet]
        [Route("ocuppied")]
        [Authorize]
        public async Task<IActionResult> GetOcuppiedRooms()
        {
            var rooms = await _roomRepository.GetOccupied();
            return Ok(rooms);
        }

    }

}