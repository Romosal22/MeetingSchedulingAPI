using MeetingScheduleAPI.Models.Base;
using System.ComponentModel.DataAnnotations;

namespace MeetingScheduleAPI.Model.Entities
{
    public class Room : IHasId
    {
        public int Id { get; set; }

        [Required]
        [StringLength(80)]
        public string Name { get; set; }

        [StringLength(300)]
        public string Description { get; set; }

        [Required]
        public int Capacity { get; set; }

        [Required]
        public Boolean IsActive { get; set; }

        public List<Reservation>? Reservations { get; set; }
    }
}
