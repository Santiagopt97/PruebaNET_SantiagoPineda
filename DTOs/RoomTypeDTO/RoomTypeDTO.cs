using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PruebaNET_SantiagoPineda.DTOs.RoomTypeDTO
{
    public class RoomTypeDTO
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public string Description { get; set; }
    }
}