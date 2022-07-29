using System.ComponentModel.DataAnnotations;

namespace MeetingScheduleAPI.Models.Dtos.Reservation
{
    public class CreateReservationDto
    {
        [Required]
        [DataType(DataType.DateTime)]
        public DateTime Date_Time { get; set; }
    }
}
