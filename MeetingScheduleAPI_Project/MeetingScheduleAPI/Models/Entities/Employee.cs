using MeetingScheduleAPI.Models.Base;
using System.ComponentModel.DataAnnotations;

namespace MeetingScheduleAPI.Model.Entities
{
    public class Employee : IHasId
    {
        public int Id { get; set; }

        [Required]
        [StringLength(30)]
        public string Full_Name { get; set; }

        [Required,StringLength(30)]
        public string Position { get; set; }

        public List<Reservation>? Reservations { get; set; }

        public List<Attendee>? Attendees { get; set; }
    }
}
