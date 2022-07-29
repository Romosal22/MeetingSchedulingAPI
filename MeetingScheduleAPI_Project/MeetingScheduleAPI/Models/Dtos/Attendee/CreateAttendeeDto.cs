using System.ComponentModel.DataAnnotations;

namespace MeetingScheduleAPI.Models.Dtos.Attendee
{
    public class CreateAttendeeDto
    {
        [Required]
        public Boolean Asisted { get; set; }
    }
}
