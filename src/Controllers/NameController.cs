using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Random.API.Models;

namespace Random.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class NameController : ControllerBase
    {
        private readonly ILogger<NameController> _logger;

        public NameController(ILogger<NameController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public ActionResult<string> Get()
        {
            return Names.CreateNew();
        }
    }
}
