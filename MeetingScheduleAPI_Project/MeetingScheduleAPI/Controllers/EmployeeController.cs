using AutoMapper;
using MeetingScheduleAPI.Controllers.Base;
using MeetingScheduleAPI.Data.Repositories;
using MeetingScheduleAPI.Model.Entities;
using MeetingScheduleAPI.Models.Dtos.Employee;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MeetingScheduleAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : CustomControllerBase<Employee>
    {
        private const string getEmployeeRouteName = "getEmployee";

        public EmployeeController(IEmployeeRepository repository, IMapper mapper) : base(repository, mapper)
        {

        }

        [HttpGet]
        public async Task<ActionResult<List<EmployeeDto>>> Get()
        {
            return await Get<EmployeeDto>();
        }

        [HttpGet("{id:int}", Name = getEmployeeRouteName)]
        public async Task<ActionResult<EmployeeDto>> Get(int id)
        {
            return await Get<EmployeeDto>(id);
        }

        [HttpPost]
        public async Task<ActionResult<EmployeeDto>> Post([FromBody] CreateEmployeeDto createEmployeeDto)
        {
            return await Post<CreateEmployeeDto, EmployeeDto>(createEmployeeDto, getEmployeeRouteName);
        }

        [HttpPut]
        public async Task<ActionResult> Put([FromBody] UpdateEmployeeDto updateEmployeeDto)
        {
            return await Put<UpdateEmployeeDto>(updateEmployeeDto);
        }

        [HttpDelete("{id:int}")]
        public async Task<ActionResult> Delete(int id)
        {
            return await base.Delete(id);
        }
    }
}
