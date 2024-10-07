using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PruebaNET_SantiagoPineda.DTOs.RoomDTO;

namespace PruebaNET_SantiagoPineda.Repositories
{
    public interface IRoomRepository
    {
        Task<IEnumerable<RoomDTO>> GetAll();
        Task<RoomDTO> GetById(int id);
        Task<IEnumerable<RoomDTO>> GetAvailable();
        Task<IEnumerable<RoomDTO>> GetOccupied();
        Task<IEnumerable<RoomDTOStatus>> GetStatus();
    }
}