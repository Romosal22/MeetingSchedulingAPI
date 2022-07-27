using System.ComponentModel.DataAnnotations;

namespace MeetingScheduleAPI.Models.Dtos.Room
{
    public class CreateRoomDto
    {
        [Required]
        [StringLength(80)]
        public string Name { get; set; }

        [StringLength(300)]
        public string Description { get; set; }

        [Required]
        public int Capacity { get; set; }

        [Required]
        public Boolean IsActive { get; set; }
    }
}
