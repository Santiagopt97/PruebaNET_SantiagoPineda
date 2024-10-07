using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PruebaNET_SantiagoPineda.Data;
using PruebaNET_SantiagoPineda.Models;
using PruebaNET_SantiagoPineda.Repositories;

namespace PruebaNET_SantiagoPineda.Services
{
    public class RoomTypeService : IRoomTypeRepository
    {
        protected readonly ApplicationDbContext _context;
        public RoomTypeService(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<RoomType>> GetAll()
        {
            return await _context.RoomTypes.ToListAsync();
        }

        public async Task<RoomType> GetById(int id)
        {
            return await _context.RoomTypes.FindAsync(id);
        }
    }
}