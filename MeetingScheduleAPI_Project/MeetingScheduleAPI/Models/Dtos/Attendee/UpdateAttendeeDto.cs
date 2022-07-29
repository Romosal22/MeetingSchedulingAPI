using MeetingScheduleAPI.Models.Base;

namespace MeetingScheduleAPI.Models.Dtos.Attendee
{
    public class UpdateAttendeeDto : CreateAttendeeDto, IHasId
    {
        public int Id { get; set; }
    }
}
