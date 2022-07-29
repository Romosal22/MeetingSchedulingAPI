using AutoMapper;
using MeetingScheduleAPI.Model.Entities;
using MeetingScheduleAPI.Models.Dtos.Employee;


namespace MeetingScheduleAPI.Models.AutoMapper
{
    public class EmployeeProfile : Profile
    {
        public EmployeeProfile()
        {
            CreateMap<CreateEmployeeDto, Employee>();
            CreateMap<UpdateEmployeeDto, Employee>();
            CreateMap<Employee, EmployeeDto>();
        }
    }
}
