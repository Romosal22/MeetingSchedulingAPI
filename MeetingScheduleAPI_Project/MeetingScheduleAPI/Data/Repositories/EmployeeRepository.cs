using MeetingScheduleAPI.Data.Base;
using MeetingScheduleAPI.Model.Entities;

namespace MeetingScheduleAPI.Data.Repositories
{
    public class EmployeeRepository : RepositoryBase<Employee, ApplicationDbContext>, IEmployeeRepository
    {
        public EmployeeRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }
    }
}
