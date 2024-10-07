using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PruebaNET_SantiagoPineda.DTOs.GuestDTO;

namespace PruebaNET_SantiagoPineda.Repositories
{
    public interface IGuestRepository
    {
        Task<IEnumerable<GuestDTO>> GetAll();
        Task<GuestDTO> GetById(int id);
        Task<GuestDTO> GetByKeyword(string keyword);
        Task Add(GuestDTO product);
        Task Delete(int id);
        Task Update(int id, GuestDTO guestDTO);
    }
}