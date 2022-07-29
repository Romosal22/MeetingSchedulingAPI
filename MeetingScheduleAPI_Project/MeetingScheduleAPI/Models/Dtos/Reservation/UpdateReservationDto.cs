using MeetingScheduleAPI.Models.Base;

namespace MeetingScheduleAPI.Models.Dtos.Reservation
{
    public class UpdateReservationDto : CreateReservationDto, IHasId
    {
        public int Id { get; set; }
    }
}
