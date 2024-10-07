using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PruebaNET_SantiagoPineda.DTOs.BookingDTO
{
    public class BookingDTO
    {
        public int Id { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public double TotalCost { get; set; }
        public int RoomId { get; set; }
        public int GuestId { get; set; }
        public int EmployeeId { get; set; }
    }
}