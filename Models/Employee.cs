using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PruebaNET_SantiagoPineda.Models
{
    [Table("employees")]
    public class Employee
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public int Id { get; set; }

        [Required]
        [Column("first_name")]
        [StringLength(50)]
        public string FirstName { get; set; }

        [Required]
        [Column("last_name")]
        [StringLength(50)]
        public string LastName { get; set; }

        [Required]
        [Column("email")]
        [StringLength(255)]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [Column("identification_number")]
        [StringLength(20)]
        public string IdentificationNumber { get; set; }

        [Required]
        [Column("password")]
        [StringLength(255)]
        public string Password { get; set; }

        public ICollection<Booking> Bookings { get; set; }
    }
}