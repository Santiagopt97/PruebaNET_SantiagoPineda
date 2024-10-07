using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PruebaNET_SantiagoPineda.Models
{
    [Table("room_types")]
    public class RoomType
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public required int Id { get; set; }

        [Column("name")]
        [Required]
        [MaxLength(50)]
        public required string Name { get; set; }

        [Column("description")]
        [MaxLength(200)]
        public string Description {get; set; }

        // realtion with Rooms one to many
        public ICollection<Room> Rooms { get; set; }
    }
}