using Microsoft.AspNetCore.Mvc;

namespace MicroS.Services.SignalR.Controllers
{
    [Route("")]
    public class HomeController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get() => Ok("MicroS SignalR Service");
    }
}
