using MeetingScheduleAPI.Data.Base;
using MeetingScheduleAPI.Model.Entities;

namespace MeetingScheduleAPI.Data.Repositories
{
    public class RoomRepository : RepositoryBase<Room, ApplicationDbContext>, IRoomRepository
    {
        public RoomRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }
    }
}
