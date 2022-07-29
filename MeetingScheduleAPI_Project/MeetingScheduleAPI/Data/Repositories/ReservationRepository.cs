using MeetingScheduleAPI.Data.Base;
using MeetingScheduleAPI.Model.Entities;

namespace MeetingScheduleAPI.Data.Repositories
{
    public class ReservationRepository : RepositoryBase<Reservation, ApplicationDbContext>, IReservationRepository
    {
        public ReservationRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }
    }
}
