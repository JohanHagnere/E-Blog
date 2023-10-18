using E_Blog.API.Models;
using E_Blog.API.Services;
using Microsoft.AspNetCore.Mvc;

namespace E_Blog.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BlogController : ControllerBase
    {
        private readonly BlogService _blogService;

        public BlogController(BlogService blogService)
        {
            _blogService = blogService;
        }

        [HttpGet("/")]
        public IActionResult Get()
        {
            return Content("<html><body><h1>Hello, World</h1></body></html>", "text/html");
        }

        [HttpPut("article")]
        public IActionResult PutArticle(string title)
        {
            if (!string.IsNullOrEmpty(title))
            {
                return Content($"<html><body><h1>{title}</h1></body></html>", "text/html");
            }
            return BadRequest("Contenu HTML invalide.");
        }

        [HttpPut("article/{id}")]
        public IActionResult PutArticle(int id, [FromBody] Article article)
        {
            if (article == null)
            {
                return BadRequest("Données invalides");
            }

            var updatedArticle = _blogService.UpdateArticle(id, article);

            return Ok(updatedArticle);
        }
    }
}