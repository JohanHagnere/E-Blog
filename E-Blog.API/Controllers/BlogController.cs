using Microsoft.AspNetCore.Mvc;

namespace E_Blog.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BlogController : ControllerBase
    {
        [HttpGet("/")]
        public IActionResult Get()
        {
            return Content("<html><body><h1>Hello, World</h1></body></html>", "text/html");
        }
    }
}