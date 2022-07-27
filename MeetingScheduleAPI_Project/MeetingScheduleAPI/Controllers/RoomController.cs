using AutoMapper;
using MeetingScheduleAPI.Controllers.Base;
using MeetingScheduleAPI.Data.Base;
using MeetingScheduleAPI.Model.Entities;
using MeetingScheduleAPI.Models.Dtos.Room;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MeetingScheduleAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoomController : CustomControllerBase<Room>
    {
        private const string getRoomRouteName = "getRoom";

        public RoomController(IRepository<Room> repository, IMapper mapper) : base(repository, mapper)
        {

        }

        [HttpGet]
        public async Task<ActionResult<List<RoomDto>>> Get()
        {
            return await Get<RoomDto>();
        }

        /// <summary>
        /// Permite obtener un curso por su Id.
        /// </summary>
        [HttpGet("{id:int}", Name = getRoomRouteName)]
        public async Task<ActionResult<RoomDto>> Get(int id)
        {
            return await Get<RoomDto>(id);
        }

        /// <summary>
        /// Permite crear un curso.
        /// </summary>
        [HttpPost]
        public async Task<ActionResult<RoomDto>> Post([FromBody] CreateRoomDto createRoomDto)
        {
            return await Post<CreateRoomDto, RoomDto>(createRoomDto, getRoomRouteName);
        }

        /// <summary>
        /// Permite actualizar un curso.
        /// </summary>
        [HttpPut]
        public async Task<ActionResult> Put([FromBody] UpdateRoomDto updateRoomDto)
        {
            return await Put<UpdateRoomDto>(updateRoomDto);
        }

        /// <summary>
        /// Permite eliminar un curso por Id.
        /// </summary>
        [HttpDelete("{id:int}")]
        public async Task<ActionResult> Delete(int id)
        {
            return await base.Delete(id);
        }
    }
}

