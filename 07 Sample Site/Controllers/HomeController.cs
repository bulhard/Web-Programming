﻿using MyBlog.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Diagnostics;
using MyBlog.Services.Interfaces;
using MyBlog.Models.Home;

namespace MyBlog.Controllers
{
    [AllowAnonymous]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> logger;
        private readonly IBlogService blogService;

        public HomeController(ILogger<HomeController> logger, IBlogService blogService)
        {
            this.logger = logger;
            this.blogService = blogService;
        }

        public IActionResult Index()
        {
            HomeViewModel homeViewModel = new HomeViewModel();

            homeViewModel.UserName = User.Identity.Name;

            homeViewModel.Categories = blogService.GetCategories();

            homeViewModel.Posts = blogService.GetPosts();

            return View(homeViewModel);
        }
    }
}