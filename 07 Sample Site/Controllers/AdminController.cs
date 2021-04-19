using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyBlog.Models.Blog;
using MyBlog.Services.Interfaces;

namespace MyBlog.Controllers
{
    public class AdminController : Controller
    {
        private readonly IBlogService blogService;

        public AdminController(IBlogService blogService)
        {
            this.blogService = blogService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Posts()
        {
            var posts = blogService.GetPosts();

            return View(posts);
        }

        public IActionResult EditPost(int id)
        {
            var post = blogService.GetPost(id);

            return View(post);
        }

        [HttpPost]
        public IActionResult EditPost(PostViewModel postViewModel)
        {
            ViewBag["Categories"] = blogService.GetCategories();

            var post = blogService.GetPost(postViewModel.Id);

            return View(post);
        }
    }
}