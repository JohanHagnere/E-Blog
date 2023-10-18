using E_Blog.API.Models;

namespace E_Blog.API.Services
{
    public interface IBlogService
    {
        public List<Article> GetAllArticles();

        public Article GetArticleById(int id);

        public Article UpdateArticle(int id, Article article);
    }
}