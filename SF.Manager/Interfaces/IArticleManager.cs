using SF.Core.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SF.Manager.Interfaces
{
    public interface IArticleManager
    {
        Task<Article> GetArticleAsync(int id);
        Task<IEnumerable<Article>> GetArticlesAsync();
    }
}
