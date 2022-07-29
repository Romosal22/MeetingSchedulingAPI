using System.ComponentModel.DataAnnotations;

namespace MeetingScheduleAPI.Models.Dtos.Reservation
{
    public class ReservationDto
    {
        public int Id { get; set; }

        [Required]
        [DataType(DataType.DateTime)]
        public DateTime Date_Time { get; set; }

    }
}
