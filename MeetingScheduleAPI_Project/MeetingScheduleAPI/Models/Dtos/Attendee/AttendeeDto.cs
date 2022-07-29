using System.ComponentModel.DataAnnotations;

namespace MeetingScheduleAPI.Models.Dtos.Attendee
{
    public class AttendeeDto
    {
        public int Id { get; set; }

        [Required]
        public Boolean Asisted { get; set; }

    }
}
