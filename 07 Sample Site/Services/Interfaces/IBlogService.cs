using MyBlog.Models.Blog;
using System.Collections.Generic;

namespace MyBlog.Services.Interfaces
{
    public interface IBlogService
    {
        List<PostViewModel> GetPosts();

        PostViewModel GetPost(int Id);

        bool UpdatePost(PostViewModel postViewModel);

        List<CategoryViewModel> GetCategories();

        CategoryViewModel GetCategory(int Id);

        bool UpdateCategory(CategoryViewModel categoryViewModel);
    }
}