using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SQL_DATABASE.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HelloWorldController : ControllerBase
    {
        [HttpGet]
        public ActionResult<string> Get()
        {
            return "Hello World";
        }
    }
}
