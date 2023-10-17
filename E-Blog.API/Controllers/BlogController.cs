using Microsoft.AspNetCore.Mvc;

namespace E_Blog.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BlogController : ControllerBase
    {
        [HttpGet(Name = "hello-world")]
        public IActionResult GetHelloWorld()
        {
            string htmlContent = "<h1>Hello world!</h1>";
            return Content(htmlContent, "text/html");
        }
    }
}