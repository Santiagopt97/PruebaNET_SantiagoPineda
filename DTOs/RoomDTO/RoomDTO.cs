using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PruebaNET_SantiagoPineda.DTOs.RoomDTO
{
    public class RoomDTO
    {
        public int Id { get; set; }
        public required string RoomNumber { get; set; }
        public required double PricePerNight { get; set; }
        public required bool Availability { get; set; }
        public required int MaxOccupancyPerson { get; set; }
        public required int RoomTypeId { get; set; }
    }
}