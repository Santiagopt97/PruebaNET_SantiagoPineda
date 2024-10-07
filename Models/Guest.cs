using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PruebaNET_SantiagoPineda.Models
{
    [Table("guests")]
    public class Guest
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public required int Id { get; set; }

        [Required]
        [Column("first_name")]
        [StringLength(255)]
        public required string FirstName { get; set; }

        [Required]
        [Column("last_name")]
        [StringLength(255)]
        public required string LastName { get; set; }

        [Required]
        [Column("email")]
        [StringLength(255)]
        [EmailAddress]
        public required string Email { get; set; }

        [Required]
        [Column("identification_number")]
        [StringLength(20)]
        //[RegularExpression(@"^[0-9]{13}$")]  // Valida que sea un número de 13 dígitos
        public required string IdentificationNumber { get; set; }

        [Required]
        [Column("phone_number")]
        [StringLength(20)]
        [Phone]
        public required string PhoneNumber { get; set; }

        [Column("birthdate")]
        public DateTime Birthdate { get; set; }

        public ICollection<Booking> Bookings { get; set; }
        
    }
}