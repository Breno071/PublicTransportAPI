using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Repository.Interfaces.Business;

namespace PublicTransportAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LinhaController : ControllerBase
    {
        private readonly ILinhaService _service;

        public LinhaController(ILinhaService service)
        {
            _service = service;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_service.GetLinhasAsync());
        }
    }
}
