using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PruebaNET_SantiagoPineda.Models;

namespace PruebaNET_SantiagoPineda.Seeders
{
    public class RoomTypeSeeder
    {
        public static void Seed(ModelBuilder modelBuilder){
            modelBuilder.Entity<RoomType>().HasData(
            new RoomType
            {
                Id = 1,
                Name = "Single Room",
                Description = "A cozy basic room with a single bed, ideal for solo travelers.",
            },
            new RoomType
            {
                Id = 2,
                Name = "Double Room",
                Description = "Offers flexibility with either two single beds or a double bed, perfect for couples or friends.",
            },
            new RoomType
            {
                Id = 3,
                Name = "Suite",
                Description = "Spacious and luxurious, with a king-size bed and a separate living area, ideal for those seeking comfort and exclusivity.",
            },
            new RoomType
            {
                Id = 4,
                Name = "Family Room",
                Description = "Designed for families, with extra space and multiple beds for a comfortable stay.",
            }
        );
        }
    }
}