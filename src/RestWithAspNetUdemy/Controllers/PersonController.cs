using Microsoft.AspNetCore.Mvc;
using RestWithAspNetUdemy.Models;
using RestWithAspNetUdemy.Services.Implementations;

namespace RestWithAspNetUdemy.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        private readonly IPersonService _personService;
        private readonly ILogger<PersonController> _logger;

        public PersonController(IPersonService personService, ILogger<PersonController> logger)
        {
            _personService = personService;
            _logger = logger;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            _logger.LogInformation("GetAll Person");
            return Ok(_personService.GetAll());
        }

        [HttpGet("getById")]
        public IActionResult Get(int id)
        {
            var person = _personService.Get(id);

            if (person == null) return NotFound();

            _logger.LogInformation($"Get Person-{id}");
            return Ok(person);
        }

        [HttpPost("create")]
        public IActionResult Post([FromBody] Person person)
        {
            if (person == null) return BadRequest();

            _logger.LogInformation($"Create-{person}");
            return Ok(_personService.Create(person));
        }

        [HttpPut("update")]
        public IActionResult Put([FromBody] Person person)
        {
            if (person == null) return BadRequest();
            _logger.LogInformation($"Update-{person}");
            return Ok(_personService.Update(person));
        }

        [HttpDelete("delete")]
        public IActionResult Delelte(int id)
        {
            _logger.LogInformation($"Delete-{id}");
            _personService.Delete(id);
            return NoContent();
        }
    }
}