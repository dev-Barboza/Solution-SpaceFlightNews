using Microsoft.AspNetCore.Mvc;
using SF.Core.Domain;
using System;
using System.Collections.Generic;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SF.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ArticlesController : ControllerBase
    {
       
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(new List<Article>()
            {
                new Article
                {
                    Id = 1,
                    Featured = true,
                    Title = "Titulo1",
                    Url = "urlteste",
                    ImageUrl = "imageurlteste",
                    NewsSite = "newssiteteste",
                    Summary = "sumary test",
                    PublishedAt = new DateTime(2021,01,01)


                }
            });
        }

        
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
