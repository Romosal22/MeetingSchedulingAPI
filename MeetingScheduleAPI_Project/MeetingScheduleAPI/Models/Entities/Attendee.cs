using MeetingScheduleAPI.Models.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MeetingScheduleAPI.Model.Entities
{
    public class Attendee : IHasId
    {
        public int Id { get; set; }

        [ForeignKey("Reservation")]
        public int? ReservationId { get; set; }
        public Reservation Reservation { get; set; }

        [ForeignKey("Employee")]
        public int? EmployeeId { get; set; }
        public Employee Employee { get; set; }

        [Required]
        public Boolean Asisted { get; set; }
    }
}
