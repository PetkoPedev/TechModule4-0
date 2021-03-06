﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SoftUniTwitter.Data;
using SoftUniTwitter.Models;

namespace SoftUniTwitter.Controllers
{
    public class HomeController : Controller
    {
        ApplicationDbContext db;
        public HomeController(ApplicationDbContext db)
        {
            this.db = db; 
        }
        public IActionResult Index()
        {
            var model = db.Tweets.Select(x =>
            new TweetViewModel
            {
                Text = x.Text,
                CreatedOn = x.CreatedOn,
                Username = x.User.UserName,
            })
            .OrderByDescending(x => x.CreatedOn)
            .ToList();

            //foreach (var tweet in model)
            //{
            //    tweet.Text = Regex.Replace(
            //        tweet.Text,
            //        @"#(?<name>[\w]+)",
            //        @"<a href='/Tweets/ByHashtag/${name}'>$0</a>");
            //}

            return View(model);
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
