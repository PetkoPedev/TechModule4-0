using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SoftUniTwitter.Data;
using SoftUniTwitter.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SoftUniTwitter.Controllers
{
    [Authorize]
    public class TweetsController : Controller
    {
        ApplicationDbContext db;
        public TweetsController(ApplicationDbContext db)
        {
            this.db = db;
        }

        public IActionResult Create()
        {
            return View();
        }

        public IActionResult SaveToDatabase(string text)
        {
            //create tweet with text
            var tweet = new Tweet();
            tweet.Text = text;
            tweet.CreatedOn = DateTime.Now;
            tweet.UserId = this.User.FindFirst(ClaimTypes.NameIdentifier).Value;

            //save to db
            db.Tweets.Add(tweet);
            db.SaveChanges();

            //redirect to home page
            return Redirect("/");
        }

        public IActionResult ByHashTag(string hashtag)
        {
            var model = db.Tweets.Select(x =>
            new TweetViewModel
            {
                CreatedOn = x.CreatedOn,
                Text = x.Text,
                Username = x.User.UserName,
            }).OrderByDescending(x => x.CreatedOn)
            .ToList();
            
            return View(model);
        }
    }
}
