using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PruebaNET_SantiagoPineda.Data;
using PruebaNET_SantiagoPineda.DTOs.RoomDTO;
using PruebaNET_SantiagoPineda.Repositories;

namespace PruebaNET_SantiagoPineda.Services
{
    public class RoomService : IRoomRepository
    {
        protected readonly ApplicationDbContext _context;
        public RoomService(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<RoomDTO>> GetAll()
        {
            var room = await _context.Rooms.Include(r => r.RoomTypes).Select(r => new RoomDTO
            {
                Id = r.Id,
                RoomNumber = r.RoomNumber,
                PricePerNight = r.PricePerNight,
                Availability = r.Availability,
                MaxOccupancyPerson = r.MaxOccupancyPerson,
                RoomTypeId = r.RoomTypeId,
                RoomTypeName = r.RoomTypes.Name

            }).ToListAsync();
            return room;
        }

        public async Task<IEnumerable<RoomDTO>> GetAvailable()
        {
            var room = await _context.Rooms.Include(r => r.RoomTypes).Where(r => r.Availability == true).Select(r => new RoomDTO
            {
                Id = r.Id,
                RoomNumber = r.RoomNumber,
                PricePerNight = r.PricePerNight,
                Availability = r.Availability,
                MaxOccupancyPerson = r.MaxOccupancyPerson,
                RoomTypeId = r.RoomTypeId,
                RoomTypeName = r.RoomTypes.Name

            }).ToListAsync();
            return room;
        }

        public async Task<RoomDTO> GetById(int id)
        {
            var room = await _context.Rooms.Include(r => r.RoomTypes).Where(r => r.Id == id).Select(r => new RoomDTO
            {
                Id = r.Id,
                RoomNumber = r.RoomNumber,
                PricePerNight = r.PricePerNight,
                Availability = r.Availability,
                MaxOccupancyPerson = r.MaxOccupancyPerson,
                RoomTypeId = r.RoomTypeId,
                RoomTypeName = r.RoomTypes.Name
            }).ToListAsync();
            return room.FirstOrDefault();
        }

        public async Task<IEnumerable<RoomDTO>> GetOccupied()
        {
            var room = await _context.Rooms.Include(r => r.RoomTypes).Where(r => r.Availability == false).Select(r => new RoomDTO
            {
                Id = r.Id,
                RoomNumber = r.RoomNumber,
                PricePerNight = r.PricePerNight,
                Availability = r.Availability,
                MaxOccupancyPerson = r.MaxOccupancyPerson,
                RoomTypeId = r.RoomTypeId,
                RoomTypeName = r.RoomTypes.Name
            }).ToListAsync();
            return room;
        }

        public async Task<IEnumerable<RoomDTOStatus>> GetStatus()
        {
            var room = await _context.Rooms.Select(r => new RoomDTOStatus
            {
                Id = r.Id,
                RoomNumber = r.RoomNumber,
                Availability = r.Availability,
            }).ToListAsync();
            return room;
        }
    }
}