using Blog.Shared;

namespace Blog.Server.Repositories
{
    public interface IBlogRepository
    {
        //? boş olabilir demek
        Task<List<BlogPost>?> GetAllBlogPosts();
        Task<BlogPost?> GetBlogPostUrl(string url);
        Task<BlogPost?> CreateNewBlogPost(BlogPost request);
        Task<List<BlogPost>> SearchBlogs(string searchText);
    }
}