using SF.Core.Domain;
using SF.Manager.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SF.Manager.Implementation
{
    public class ArticleManager : IArticleManager
    {
        private readonly IArticleRepository articleRepository;

        public ArticleManager(IArticleRepository articleRepository)
        {
            this.articleRepository = articleRepository;
        }

        public async Task<IEnumerable<Article>> GetArticlesAsync()
        {
            return await articleRepository.GetArticlesAsync();  
        }

        public async Task<Article> GetArticleAsync(int id)
        {
            return await articleRepository.GetArticleAsync(id);
        }

        public async Task DeleteArticleAsync(int id)
        {
            await articleRepository.DeleteArticleAsync(id);
        }

        public async Task<Article> InsertArticleAsync(Article article)
        {
            return await articleRepository.InsertArticleAsync(article);
        }

        public async Task<Article> UpdateArticleAsync(Article article)
        {
            return await articleRepository.UpdateArticleAsync(article);
        }
    }
}
