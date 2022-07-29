using MeetingScheduleAPI.Data.Repositories;

namespace Microsoft.Extensions.DependencyInjection
{

    public static class RepositoriesServiceCollection
    {
        public static IServiceCollection AddRepositories(this IServiceCollection services) =>
            services.AddScoped<IRoomRepository, RoomRepository>()
            .AddScoped<IReservationRepository, ReservationRepository>()
            .AddScoped<IAttendeeRepository, AttendeeRepository>()
            .AddScoped<IEmployeeRepository, EmployeeRepository>();  
    }

}
