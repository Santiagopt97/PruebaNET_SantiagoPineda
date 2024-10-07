using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PruebaNET_SantiagoPineda.Models
{
    [Table("rooms")]
    public class Room
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public int Id { get; set; }

        [Required]
        [Column("room_number")]
        public string RoomNumber { get; set; }

        [Required]
        [Column("price_per_night")]
        public double PricePerNight { get; set; }

        [Required]
        [Column("availability")]
        public bool Availability { get; set; }

        [Required]
        [Column("max_occupancy_person")]
        public byte MaxOccupancyPerson { get; set; }


        //relation with RoomType one to many
        [ForeignKey("room_type_id")]
        public int  RoomTypeId { get; set; }
        public RoomType RoomTypes { get; set; }

        //relation with Booking one to many
        public ICollection<Booking> Bookings { get; set; }
    }
}