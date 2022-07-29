using MeetingScheduleAPI.Data.Base;
using MeetingScheduleAPI.Model.Entities;

namespace MeetingScheduleAPI.Data.Repositories
{
    public class AttendeeRepository : RepositoryBase<Attendee, ApplicationDbContext>, IAttendeeRepository
    {
        public AttendeeRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }
    }
}
