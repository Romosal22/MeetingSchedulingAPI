using MeetingScheduleAPI.Model.Entities;
using Microsoft.EntityFrameworkCore;

namespace MeetingScheduleAPI.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Room> Rooms { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<Attendee> Atendees { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Attendee>()
                .HasOne(a => a.Reservation)
                .WithMany(r => r.Attendees)
                .OnDelete(DeleteBehavior.NoAction);

            
        }
    }
}
