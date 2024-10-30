using Microsoft.AspNetCore.Mvc;

namespace MyWebApiProject.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class NameController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetName()
        {
            return Ok(new { name = "Xander Marsden" });
        }
    }
}
