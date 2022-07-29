using AutoMapper;
using MeetingScheduleAPI.Data.Repositories;
using MeetingScheduleAPI.Model.Entities;
using MeetingScheduleAPI.Models.Dtos.Attendee;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MeetingScheduleAPI.Controllers.Base
{
    [Route("api/[controller]")]
    [ApiController]
    public class AttendeeController : CustomControllerBase<Attendee>
    {
        private const string getAttendeeRouteName = "getAttendee";

        public AttendeeController(IAttendeeRepository repository, IMapper mapper) : base(repository, mapper)
        {

        }

        [HttpGet]
        public async Task<ActionResult<List<AttendeeDto>>> Get()
        {
            return await Get<AttendeeDto>();
        }

        [HttpGet("{id:int}", Name = getAttendeeRouteName)]
        public async Task<ActionResult<AttendeeDto>> Get(int id)
        {
            return await Get<AttendeeDto>(id);
        }

        [HttpPost]
        public async Task<ActionResult<AttendeeDto>> Post([FromBody] CreateAttendeeDto createAttendeeDto)
        {
            return await Post<CreateAttendeeDto, AttendeeDto>(createAttendeeDto, getAttendeeRouteName);
        }

        [HttpPut]
        public async Task<ActionResult> Put([FromBody] UpdateAttendeeDto updateAttendeeDto)
        {
            return await Put<UpdateAttendeeDto>(updateAttendeeDto);
        }

        [HttpDelete("{id:int}")]
        public async Task<ActionResult> Delete(int id)
        {
            return await base.Delete(id);
        }

    }
}
