using Microsoft.AspNetCore.Mvc;
using SF.Core.Domain;
using SF.Manager.Interfaces;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SF.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ArticlesController : ControllerBase
    {
        private readonly IArticleManager articleManager;

        public ArticlesController(IArticleManager articleManager)
        {
            this.articleManager = articleManager;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await articleManager.GetArticlesAsync());
        }

        
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            return Ok(await articleManager.GetArticleAsync(id));
        }

        
        [HttpPost]
        public async Task<IActionResult> Post(Article article)
        {
            var articleInserido = await articleManager.InsertArticleAsync(article);
            return CreatedAtAction(nameof(Get),new {id = article.Id}, article);
        }

        
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(Article article)
        {
            var articleAtualizado = await articleManager.UpdateArticleAsync(article);
            if (articleAtualizado == null)
            {
                return NotFound();
            }

            return Ok(articleAtualizado);
        }

        
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await articleManager.DeleteArticleAsync(id);
            return NoContent();
        }
    }
}
