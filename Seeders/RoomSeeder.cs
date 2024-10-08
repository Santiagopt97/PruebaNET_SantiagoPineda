using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PruebaNET_SantiagoPineda.Models;

namespace PruebaNET_SantiagoPineda.Seeders
{
    public class RoomSeeder
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Room>().HasData(
            // Rooms 101-110 with mixed RoomTypeId and availability
            new Room { Id = 1, RoomNumber = "101", PricePerNight = 50, Availability = true, MaxOccupancyPerson = 1, RoomTypeId = 1 },  // Single Room
            new Room { Id = 2, RoomNumber = "102", PricePerNight = 150, Availability = false, MaxOccupancyPerson = 2, RoomTypeId = 3 }, // Suite (Unavailable)
            new Room { Id = 3, RoomNumber = "103", PricePerNight = 80, Availability = true, MaxOccupancyPerson = 2, RoomTypeId = 2 },  // Double Room
            new Room { Id = 4, RoomNumber = "104", PricePerNight = 200, Availability = true, MaxOccupancyPerson = 4, RoomTypeId = 4 }, // Family Room
            new Room { Id = 5, RoomNumber = "105", PricePerNight = 50, Availability = true, MaxOccupancyPerson = 1, RoomTypeId = 1 },  // Single Room
            new Room { Id = 6, RoomNumber = "106", PricePerNight = 150, Availability = false, MaxOccupancyPerson = 2, RoomTypeId = 3 }, // Suite (Unavailable)
            new Room { Id = 7, RoomNumber = "107", PricePerNight = 80, Availability = true, MaxOccupancyPerson = 2, RoomTypeId = 2 },  // Double Room
            new Room { Id = 8, RoomNumber = "108", PricePerNight = 200, Availability = true, MaxOccupancyPerson = 4, RoomTypeId = 4 }, // Family Room
            new Room { Id = 9, RoomNumber = "109", PricePerNight = 50, Availability = false, MaxOccupancyPerson = 1, RoomTypeId = 1 },  // Single Room (Unavailable)
            new Room { Id = 10, RoomNumber = "110", PricePerNight = 150, Availability = true, MaxOccupancyPerson = 2, RoomTypeId = 3 }, // Suite

            // Rooms 201-210 with mixed RoomTypeId and availability
            new Room { Id = 11, RoomNumber = "201", PricePerNight = 200, Availability = true, MaxOccupancyPerson = 4, RoomTypeId = 4 }, // Family Room
            new Room { Id = 12, RoomNumber = "202", PricePerNight = 80, Availability = false, MaxOccupancyPerson = 2, RoomTypeId = 2 },  // Double Room (Unavailable)
            new Room { Id = 13, RoomNumber = "203", PricePerNight = 50, Availability = true, MaxOccupancyPerson = 1, RoomTypeId = 1 },  // Single Room
            new Room { Id = 14, RoomNumber = "204", PricePerNight = 150, Availability = true, MaxOccupancyPerson = 2, RoomTypeId = 3 }, // Suite
            new Room { Id = 15, RoomNumber = "205", PricePerNight = 200, Availability = true, MaxOccupancyPerson = 4, RoomTypeId = 4 }, // Family Room
            new Room { Id = 16, RoomNumber = "206", PricePerNight = 80, Availability = true, MaxOccupancyPerson = 2, RoomTypeId = 2 },  // Double Room
            new Room { Id = 17, RoomNumber = "207", PricePerNight = 50, Availability = false, MaxOccupancyPerson = 1, RoomTypeId = 1 },  // Single Room (Unavailable)
            new Room { Id = 18, RoomNumber = "208", PricePerNight = 150, Availability = true, MaxOccupancyPerson = 2, RoomTypeId = 3 }, // Suite
            new Room { Id = 19, RoomNumber = "209", PricePerNight = 200, Availability = false, MaxOccupancyPerson = 4, RoomTypeId = 4 }, // Family Room (Unavailable)
            new Room { Id = 20, RoomNumber = "210", PricePerNight = 80, Availability = true, MaxOccupancyPerson = 2, RoomTypeId = 2 },  // Double Room

            // Rooms 301-310 with mixed RoomTypeId and availability
            new Room { Id = 21, RoomNumber = "301", PricePerNight = 50, Availability = true, MaxOccupancyPerson = 1, RoomTypeId = 1 },  // Single Room
            new Room { Id = 22, RoomNumber = "302", PricePerNight = 150, Availability = false, MaxOccupancyPerson = 2, RoomTypeId = 3 }, // Suite (Unavailable)
            new Room { Id = 23, RoomNumber = "303", PricePerNight = 80, Availability = true, MaxOccupancyPerson = 2, RoomTypeId = 2 },  // Double Room
            new Room { Id = 24, RoomNumber = "304", PricePerNight = 200, Availability = true, MaxOccupancyPerson = 4, RoomTypeId = 4 }, // Family Room
            new Room { Id = 25, RoomNumber = "305", PricePerNight = 50, Availability = true, MaxOccupancyPerson = 1, RoomTypeId = 1 },  // Single Room
            new Room { Id = 26, RoomNumber = "306", PricePerNight = 150, Availability = true, MaxOccupancyPerson = 2, RoomTypeId = 3 }, // Suite
            new Room { Id = 27, RoomNumber = "307", PricePerNight = 80, Availability = false, MaxOccupancyPerson = 2, RoomTypeId = 2 },  // Double Room (Unavailable)
            new Room { Id = 28, RoomNumber = "308", PricePerNight = 200, Availability = true, MaxOccupancyPerson = 4, RoomTypeId = 4 }, // Family Room
            new Room { Id = 29, RoomNumber = "309", PricePerNight = 50, Availability = true, MaxOccupancyPerson = 1, RoomTypeId = 1 },  // Single Room
            new Room { Id = 30, RoomNumber = "310", PricePerNight = 150, Availability = true, MaxOccupancyPerson = 2, RoomTypeId = 3 }, // Suite

            // Rooms 401-410 with mixed RoomTypeId and availability
            new Room { Id = 31, RoomNumber = "401", PricePerNight = 80, Availability = true, MaxOccupancyPerson = 2, RoomTypeId = 2 },  // Double Room
            new Room { Id = 32, RoomNumber = "402", PricePerNight = 200, Availability = false, MaxOccupancyPerson = 4, RoomTypeId = 4 }, // Family Room (Unavailable)
            new Room { Id = 33, RoomNumber = "403", PricePerNight = 50, Availability = true, MaxOccupancyPerson = 1, RoomTypeId = 1 },  // Single Room
            new Room { Id = 34, RoomNumber = "404", PricePerNight = 150, Availability = true, MaxOccupancyPerson = 2, RoomTypeId = 3 }, // Suite
            new Room { Id = 35, RoomNumber = "405", PricePerNight = 80, Availability = true, MaxOccupancyPerson = 2, RoomTypeId = 2 },  // Double Room
            new Room { Id = 36, RoomNumber = "406", PricePerNight = 200, Availability = true, MaxOccupancyPerson = 4, RoomTypeId = 4 }, // Family Room
            new Room { Id = 37, RoomNumber = "407", PricePerNight = 50, Availability = true, MaxOccupancyPerson = 1, RoomTypeId = 1 },  // Single Room
            new Room { Id = 38, RoomNumber = "408", PricePerNight = 150, Availability = false, MaxOccupancyPerson = 2, RoomTypeId = 3 }, // Suite (Unavailable)
            new Room { Id = 39, RoomNumber = "409", PricePerNight = 80, Availability = true, MaxOccupancyPerson = 2, RoomTypeId = 2 },  // Double Room
            new Room { Id = 40, RoomNumber = "410", PricePerNight = 200, Availability = true, MaxOccupancyPerson = 4, RoomTypeId = 4 }, // Family Room

            // Rooms 501-510 with mixed RoomTypeId
            new Room { Id = 41, RoomNumber = "501", PricePerNight = 50, Availability = false, MaxOccupancyPerson = 1, RoomTypeId = 1 },  // Single Room
            new Room { Id = 42, RoomNumber = "502", PricePerNight = 150, Availability = true, MaxOccupancyPerson = 2, RoomTypeId = 3 }, // Suite
            new Room { Id = 43, RoomNumber = "503", PricePerNight = 80, Availability = true, MaxOccupancyPerson = 2, RoomTypeId = 2 },  // Double Room
            new Room { Id = 44, RoomNumber = "504", PricePerNight = 200, Availability = false, MaxOccupancyPerson = 4, RoomTypeId = 4 }, // Family Room
            new Room { Id = 45, RoomNumber = "505", PricePerNight = 50, Availability = true, MaxOccupancyPerson = 1, RoomTypeId = 1 },  // Single Room
            new Room { Id = 46, RoomNumber = "506", PricePerNight = 150, Availability = false, MaxOccupancyPerson = 2, RoomTypeId = 3 }, // Suite
            new Room { Id = 47, RoomNumber = "507", PricePerNight = 80, Availability = false, MaxOccupancyPerson = 2, RoomTypeId = 2 },  // Double Room
            new Room { Id = 48, RoomNumber = "508", PricePerNight = 200, Availability = true, MaxOccupancyPerson = 4, RoomTypeId = 4 }, // Family Room
            new Room { Id = 49, RoomNumber = "509", PricePerNight = 50, Availability = true, MaxOccupancyPerson = 1, RoomTypeId = 1 },  // Single Room
            new Room { Id = 50, RoomNumber = "510", PricePerNight = 150, Availability = false, MaxOccupancyPerson = 2, RoomTypeId = 3 }  // Suite
        );
    }
    }
}