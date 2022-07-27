using AutoMapper;
using MeetingScheduleAPI.Model.Entities;
using MeetingScheduleAPI.Models.Dtos.Room;

namespace MeetingScheduleAPI.Models.AutoMapper
{
    public class RoomProfile : Profile
    {
        public RoomProfile()
        {
            CreateMap<CreateRoomDto, Room>();
            CreateMap<UpdateRoomDto, Room>();
            CreateMap<Room, RoomDto>();
        }
    }
}
