using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MeetingScheduleAPI.Model.Entities
{
    public class Reservation
    {
        public int Id { get; set; }

        [Required]
        [DataType(DataType.DateTime)]
        public DateTime Date_Time { get; set; }

        [ForeignKey("Employee")]
        public int EmployeeId { get; set; }
        public Employee Employee { get; set; }

        [ForeignKey("Room")]
        public int  RoomId { get; set; }
        public Room Room { get; set; }

        public List<Attendee>? Attendees { get; set; }
    }
}
