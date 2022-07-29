using AutoMapper;
using MeetingScheduleAPI.Model.Entities;
using MeetingScheduleAPI.Models.Dtos.Attendee;


namespace MeetingScheduleAPI.Models.AutoMapper
{
    public class AttendeeProfile : Profile
    {
        public AttendeeProfile()
        {
            CreateMap<CreateAttendeeDto, Attendee>();
            CreateMap<UpdateAttendeeDto, Attendee>();
            CreateMap<Attendee, AttendeeDto>();
        }
    }
}
