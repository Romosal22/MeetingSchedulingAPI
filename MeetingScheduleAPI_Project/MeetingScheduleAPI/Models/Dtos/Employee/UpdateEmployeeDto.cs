using MeetingScheduleAPI.Models.Base;

namespace MeetingScheduleAPI.Models.Dtos.Employee
{
    public class UpdateEmployeeDto : CreateEmployeeDto, IHasId
    {
        public int Id { get; set; }
    }
}
