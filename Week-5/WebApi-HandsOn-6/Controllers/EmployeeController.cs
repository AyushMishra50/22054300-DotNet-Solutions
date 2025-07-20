using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MyFirstWebApi.Models;
using MyFirstWebApi.Services;

namespace MyFirstWebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Authorize(Roles = "Admin,POC")]
    public class EmployeeController : ControllerBase
    {
        private readonly KafkaProducerService _kafka;
        private static List<Employee> _employees = new();

        public EmployeeController(KafkaProducerService kafka)
        {
            _kafka = kafka;

            // Load default employee if list is empty
            if (!_employees.Any())
            {
                _employees.Add(new Employee
                {
                    Id = 1,
                    Name = "Alice",
                    Salary = 50000,
                    Permanent = true,
                    Department = new Department { Id = 1, Name = "HR" },
                    Skills = new List<Skill>
                    {
                        new Skill { Id = 1, Name = "Communication" },
                        new Skill { Id = 2, Name = "Leadership" }
                    },
                    DateOfBirth = new DateTime(1990, 1, 1)
                });
            }
        }

        [HttpGet]
        public ActionResult<List<Employee>> Get()
        {
            return Ok(_employees);
        }

        [HttpPost]
        public async Task<ActionResult> Post([FromBody] Employee emp)
        {
            _employees.Add(emp);
            await _kafka.ProduceMessageAsync(emp); // ✅ Send message to Kafka topic
            return Ok("Employee added and published to Kafka.");
        }
    }
}
