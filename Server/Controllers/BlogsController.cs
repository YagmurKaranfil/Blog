using Blog.Server.Repositories;
using Blog.Shared;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics.Metrics;

namespace Blog.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BlogsController : ControllerBase
    {
        private readonly IBlogRepository blogRepository;
        public BlogsController(IBlogRepository blogRepository)
        { this.blogRepository = blogRepository; }
        [HttpGet]

        //Task<ActionResult<BlogPost>> ifadesi, ActionResult<BlogPost> türündeki bir değeri döndüren bir asenkron metot veya 
        //işlemi temsil eder.Task sınıfı, metotların veya işlemlerin asenkron olarak çalıştırılmasını sağlayarak, anahtar kelime 
        //olan await ile kullanılır.


        public async Task<ActionResult<BlogPost>> GimmeAllPosts()
        { return Ok(await blogRepository.GetAllBlogPosts()); }


        [HttpGet("{url}")]
        public async Task<ActionResult<BlogPost>> GimmeSinglePost(string url)
        { return Ok(await blogRepository.GetBlogPostUrl(url)); }


        [HttpPost]
        public async Task<ActionResult<BlogPost>> CreateNewBlogPost(BlogPost request)
        { return Ok(await blogRepository.CreateNewBlogPost(request)); }

        [HttpGet("search/{searchText}")]
        public async Task<ActionResult<List<BlogPost>>> SearchBlogs(string searchText)
        { return Ok(await blogRepository.SearchBlogs(searchText)); }
    }
}