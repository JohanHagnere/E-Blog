using E_Blog.API.Models;

namespace E_Blog.API.Services
{
    public class BlogService : IBlogService
    {
        private readonly List<Article> _articles = new()
        {
            new Article
            {
                Id = 1,
                Content = "Coucou, c'est le premier article de mon blog !"
            },
            new Article
            {
                Id = 2,
                Content = "Ceci est le deuxième article."
            },
              new Article
            {
                Id = 3,
                Content = "Ceci est le troisième article."
            },
                new Article
            {
                Id = 4,
                Content = "J'aime jouer à Candry Crush.",
                Author = "Nicolas"
            },
                  new Article
            {
                Id = 5,
                Content = "Ceci est le deuxième article car je ne sais pas compter.",
                Author = "Tommy"
            }
        };

        public List<Article> GetAllArticles()
        {
            return _articles;
        }

        public Article GetArticleById(int id)
        {
            var result = _articles.Find(x => x.Id == id);
            if (result is not null) return result;
            else return new Article { Id = 0, Content = "Article par défaut, lol." };
        }

        public Article UpdateArticle(int id, Article article)
        {
            if (article == null)
            {
                throw new ArgumentNullException(nameof(article));
            }

            var articleToUpdate = _articles.Find(x => x.Id == id);
            if (articleToUpdate != null)
            {
                articleToUpdate.Title = article.Title;
                articleToUpdate.Content = article.Content;
                articleToUpdate.Author = article.Author;

                return articleToUpdate;
            }
            else
            {
                throw new InvalidOperationException("Article non trouvé");
            }
        }
    }
}