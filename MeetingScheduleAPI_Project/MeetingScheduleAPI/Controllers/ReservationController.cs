using AutoMapper;
using MeetingScheduleAPI.Controllers.Base;
using MeetingScheduleAPI.Data.Repositories;
using MeetingScheduleAPI.Model.Entities;
using MeetingScheduleAPI.Models.Dtos.Reservation;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;



namespace MeetingScheduleAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReservationController : CustomControllerBase<Reservation>
    {
        private const string getReservationRouteName = "getReservation";

        public ReservationController(IReservationRepository repository, IMapper mapper) : base(repository, mapper)
        {

        }

        [HttpGet]
        public async Task<ActionResult<List<ReservationDto>>> Get()
        {
            return await Get<ReservationDto>();
        }

        [HttpGet("{id:int}", Name = getReservationRouteName)]
        public async Task<ActionResult<ReservationDto>> Get(int id)
        {
            return await Get<ReservationDto>(id);
        }

        [HttpPost]
        public async Task<ActionResult<ReservationDto>> Post([FromBody] CreateReservationDto createReservationDto)
        {
            return await Post<CreateReservationDto, ReservationDto>(createReservationDto, getReservationRouteName);
        }

        [HttpPut]
        public async Task<ActionResult> Put([FromBody] UpdateReservationDto updateReservationDto)
        {
            return await Put<UpdateReservationDto>(updateReservationDto);
        }

        [HttpDelete("{id:int}")]
        public async Task<ActionResult> Delete(int id)
        {
            return await base.Delete(id);
        }
    }
}
