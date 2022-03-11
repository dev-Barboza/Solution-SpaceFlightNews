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
    }
}
