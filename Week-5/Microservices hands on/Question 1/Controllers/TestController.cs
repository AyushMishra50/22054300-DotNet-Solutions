using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace JwtAuthDemo.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TestController : ControllerBase
    {
        [HttpGet("public")]
        public IActionResult Public() => Ok("This is a public endpoint.");

        [Authorize]
        [HttpGet("private")]
        public IActionResult Private() => Ok("You are authorized to see this.");
    }
}
