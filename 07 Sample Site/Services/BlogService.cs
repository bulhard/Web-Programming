using MyBlog.Data;
using MyBlog.Models.Blog;
using MyBlog.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyBlog.Services
{
    public class BlogService : IBlogService
    {
        private readonly MyBlogContext blogContext;

        public BlogService(MyBlogContext blogContext)
        {
            this.blogContext = blogContext;
        }

        public List<CategoryViewModel> GetCategories()
        {
            return blogContext
                .Categories
                .OrderBy(c => c.Title)
                .Select(c => new CategoryViewModel { Id = c.Id, Title = c.Title })
                .ToList();
        }

        public List<PostViewModel> GetPosts()
        {
            return blogContext
                .Posts
                .Select(p =>
                    new PostViewModel
                    {
                        Id = p.Id,
                        CategoryId = p.CategoryId,
                        CategoryTitle = p.Category.Title,
                        Content = p.Content,
                        DateCreated = p.DateCreated,
                        DateModified = p.DateModified,
                        Photo = p.Photo,
                        SubTitle = p.SubTitle,
                        Title = p.Title
                    }
                    )
                .ToList();
        }

        public PostViewModel GetPost(int Id)
        {
            return blogContext
                .Posts
                .Where(p => p.Id == Id)
                .Select(p =>
                    new PostViewModel
                    {
                        Id = p.Id,
                        CategoryId = p.CategoryId,
                        CategoryTitle = p.Category.Title,
                        Content = p.Content,
                        DateCreated = p.DateCreated,
                        DateModified = p.DateModified,
                        Photo = p.Photo,
                        SubTitle = p.SubTitle,
                        Title = p.Title
                    }
                    )
                .FirstOrDefault();
        }
    }
}