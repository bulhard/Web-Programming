using MyBlog.Models.Blog;
using System.Collections.Generic;

namespace MyBlog.Services.Interfaces
{
    public interface IBlogService
    {
        List<PostViewModel> GetPosts();

        PostViewModel GetPost(int Id);

        List<CategoryViewModel> GetCategories();
    }
}