using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PruebaNET_SantiagoPineda.DTOs.RoomTypeDTO;
using PruebaNET_SantiagoPineda.Models;

namespace PruebaNET_SantiagoPineda.Repositories
{
    public interface IRoomTypeRepository
    {
        Task<IEnumerable<RoomTypeDTO>> GetAll();
        Task<RoomTypeDTO> GetById(int id);
    }
}