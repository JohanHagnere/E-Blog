namespace E_Blog.API.Models
{
    public class Article
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Author { get; set; } = "Johan Hagnéré";
        public string Content { get; set; } = string.Empty;
    }
}