using System.ComponentModel.DataAnnotations;

namespace MeetingScheduleAPI.Models.Dtos.Employee
{
    public class EmployeeDto
    {
        public int Id { get; set; }

        [Required]
        [StringLength(30)]
        public string Full_Name { get; set; }

        [Required, StringLength(30)]
        public string Position { get; set; }

    }
}
