using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PruebaNET_SantiagoPineda.Models
{
    [Table("bookings")]
    public class Booking
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public int Id { get; set; }

        [Required]
        [Column("start_date")]
        public DateTime StartDate { get; set; }

        [Column("end_date")]
        public DateTime EndDate { get; set; }

        [Required]
        [Column("total_cost")]
        public double TotalCost { get; set; }


        //Relations with other entities/clases

        [ForeignKey("room_id")]
        public int RoomId { get; set; }
        public Room Rooms { get; set; }

        [ForeignKey("guest_id")]
        public int GuestId { get; set; }
        public Guest Guests { get; set; }

        [ForeignKey("employee_id")]
        public int EmployeeId { get; set; }
        public Employee Employees { get; set; }
    }
}