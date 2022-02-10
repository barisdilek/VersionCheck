using Microsoft.AspNetCore.Mvc;

namespace VersionCheck.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VersionController : ControllerBase
    {
        public IConfiguration Configuration { get; }

        public VersionController(IConfiguration _configuration)
        {
            Configuration = _configuration;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok($"Api Version: {Configuration.GetSection("ApiVersion").Value}");
        }
    }
}
