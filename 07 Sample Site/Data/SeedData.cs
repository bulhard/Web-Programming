using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MyBlog.DataEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyBlog.Data
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MyBlogContext(serviceProvider.GetRequiredService<DbContextOptions<MyBlogContext>>()))
            {
                // Look for any movies.
                if (context.Categories.Any())
                {
                    return;   // DB has been seeded
                }

                context.Categories.AddRange(
                    new Category
                    {
                        Title = "Web"
                    },

                    new Category
                    {
                        Title = "Design"
                    },

                    new Category
                    {
                        Title = "Branding"
                    },

                    new Category
                    {
                        Title = "Photography"
                    }
                );

                if (context.Posts.Any())
                {
                    return;   // DB has been seeded
                }

                context.Posts.AddRange(
                    new Post
                    {
                        Title = "Work Single Page 1",
                        SubTitle = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Quisquam necessitatibus incidunt ut officiis explicabo inventore.",
                        Content = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Quisquam necessitatibus incidunt ut officiis explicabo inventore.",
                        DateCreated = DateTime.Now,
                        DateModified = DateTime.Now,
                        CategoryId = 1,
                        Photo = "1.gif"
                    },

                    new Post
                    {
                        Title = "Work Single Page 2",
                        SubTitle = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Quisquam necessitatibus incidunt ut officiis explicabo inventore.",
                        Content = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Quisquam necessitatibus incidunt ut officiis explicabo inventore.",
                        DateCreated = DateTime.Now,
                        DateModified = DateTime.Now,
                        CategoryId = 2,
                        Photo = "2.gif"
                    },

                    new Post
                    {
                        Title = "Work Single Page 3",
                        SubTitle = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Quisquam necessitatibus incidunt ut officiis explicabo inventore.",
                        Content = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Quisquam necessitatibus incidunt ut officiis explicabo inventore.",
                        DateCreated = DateTime.Now,
                        DateModified = DateTime.Now,
                        CategoryId = 2,
                        Photo = "2.gif"
                    },

                    new Post
                    {
                        Title = "Work Single Page 4",
                        SubTitle = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Quisquam necessitatibus incidunt ut officiis explicabo inventore.",
                        Content = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Quisquam necessitatibus incidunt ut officiis explicabo inventore.",
                        DateCreated = DateTime.Now,
                        DateModified = DateTime.Now,
                        CategoryId = 3,
                        Photo = "3.gif"
                    },

                    new Post
                    {
                        Title = "Work Single Page 5",
                        SubTitle = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Quisquam necessitatibus incidunt ut officiis explicabo inventore.",
                        Content = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Quisquam necessitatibus incidunt ut officiis explicabo inventore.",
                        DateCreated = DateTime.Now,
                        DateModified = DateTime.Now,
                        CategoryId = 3,
                        Photo = "3.gif"
                    },

                    new Post
                    {
                        Title = "Work Single Page 6",
                        SubTitle = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Quisquam necessitatibus incidunt ut officiis explicabo inventore.",
                        Content = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Quisquam necessitatibus incidunt ut officiis explicabo inventore.",
                        DateCreated = DateTime.Now,
                        DateModified = DateTime.Now,
                        CategoryId = 4,
                        Photo = "4.gif"
                    },

                    new Post
                    {
                        Title = "Work Single Page 7",
                        SubTitle = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Quisquam necessitatibus incidunt ut officiis explicabo inventore.",
                        Content = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Quisquam necessitatibus incidunt ut officiis explicabo inventore.",
                        DateCreated = DateTime.Now,
                        DateModified = DateTime.Now,
                        CategoryId = 5,
                        Photo = "5.gif"
                    },

                    new Post
                    {
                        Title = "Work Single Page 8",
                        SubTitle = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Quisquam necessitatibus incidunt ut officiis explicabo inventore.",
                        Content = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Quisquam necessitatibus incidunt ut officiis explicabo inventore.",
                        DateCreated = DateTime.Now,
                        DateModified = DateTime.Now,
                        CategoryId = 6,
                        Photo = "6.gif"
                    }
                );

                context.SaveChanges();
            }
        }
    }
}