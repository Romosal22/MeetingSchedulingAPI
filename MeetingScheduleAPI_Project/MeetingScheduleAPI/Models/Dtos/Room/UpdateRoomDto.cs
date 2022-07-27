using MeetingScheduleAPI.Models.Base;

namespace MeetingScheduleAPI.Models.Dtos.Room
{
    public class UpdateRoomDto : CreateRoomDto, IHasId
    {
        public int Id { get; set; }
    }
}
