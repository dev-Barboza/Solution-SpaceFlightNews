using Microsoft.EntityFrameworkCore;
using SF.Core.Domain;
using SF.Data.Context;
using SF.Manager.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SF.Data.Repository
{
    public class ArticleRepository : IArticleRepository
    {
        private readonly SFContext context;

        //Adicionando Injeção de independencia  
        public ArticleRepository(SFContext context)
        {
            this.context = context;
        }

        /// <summary>
        /// Retornando todos os articles
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<Article>> GetArticlesAsync()
        {
            return await context.Articles.AsNoTracking().ToListAsync();
        }

        public async Task<Article>GetArticleAsync(int id)
        {
            return await context.Articles.FindAsync(id);
        }
        
        //Insert 
        public async  Task<Article> InsertArticleAsync(Article article)
        {
            await context.Articles.AddAsync(article);
            await context.SaveChangesAsync();
            return article;
        }

        //Update
        public async Task<Article> UpdateArticleAsync(Article article)
        {
            var articleConsultado = await context.Articles.FindAsync(article.Id);
            if (articleConsultado == null)
            {
                return null;
            }

            context.Entry(articleConsultado).CurrentValues.SetValues(article);

            await context.SaveChangesAsync();
            return articleConsultado;
            
        }

        //Delete
        public async Task DeleteArticleAsync(int id)
        {
            var articleConsultado = await context.Articles.FindAsync(id);
            context.Articles.Remove(articleConsultado);
            await context.SaveChangesAsync();
        }

    }
}
