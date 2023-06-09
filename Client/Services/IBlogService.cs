﻿using Blog.Shared;

namespace Blog.Client.Services
{
    public interface IBlogService
    {
        Task<List<BlogPost>?> GetAllBlogPosts();
        Task<BlogPost?> GetBlogPostUrl(string url);
        Task<BlogPost?> CreateNewBlogPost(BlogPost request);
        Task<List<BlogPost>> SearchBlogs(string searchText);
    }
}
