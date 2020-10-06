
using Microsoft.AspNetCore.Mvc;


namespace dot_net_core_practice.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TestController : ControllerBase
    {


        [HttpGet]
        public string Get()
        {
            return "test";
        }
    }
}
