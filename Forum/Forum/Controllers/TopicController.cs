using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Forum.Data;
using Forum.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Forum.Controllers
{
    public class TopicController : Controller
    {
        private readonly ForumDbContext context;

        public TopicController(ForumDbContext context)
        {
            this.context = context;
        }
        public IActionResult Index()
        {
            return View();
        }

        //GET: Topic/Details/id
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Index", "Home");
            }

            Topic topic = context.Topics
                .Include(t => t.Author)
                .Include(t => t.Comments)
                .ThenInclude(c => c.Author)
                .Where(t => t.Id == id)
                .SingleOrDefault();

            if (topic == null)
            {
                return RedirectToAction("Index", "Home");
            }

            return View(topic);
        }


        //GET: Topic/Create
        [Authorize]
        public IActionResult Create()
        {
            return View();
        }

        //POST: Topic/Create
        [HttpPost]
        [Authorize]
        public IActionResult Create(Topic topic)
        {
            if (ModelState.IsValid)
            {
                //set CreatedDate and LastUpdate
                topic.CreatedDate = DateTime.Now;
                topic.LastUpdatedDate = DateTime.Now;

                //get user id
                string authorId = context.Users
                    .Where(u => u.UserName == User.Identity.Name)
                    .First()
                    .Id;

                //set topic author id
                topic.AuthorId = authorId;

                //save topic
                context.Topics.Add(topic);
                context.SaveChanges();

                return RedirectToAction("Index", "Home");
            }

            return View(topic);
        }

        //GET: Topic/Delete/id
        [Authorize]
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Index", "Home");
            }

            var topic = context.Topics
                .Include(t => t.Author)
                .SingleOrDefault(m => m.Id == id);

            if (topic == null)
            {
                return RedirectToAction("Index", "Home");
            }

            return View(topic);

        }

        //POST: Topic/Delete/id
        [HttpPost]
        [Authorize]
        public IActionResult Delete(int id)
        {
            //get topic
            Topic topic = context.Topics
                .Include(t => t.Author)
                .SingleOrDefault(m => m.Id == id);

            //check if topic exists
            if (topic != null)
            {
                //delete topic
                context.Topics.Remove(topic);
                context.SaveChanges();
            }

            //redirect to index
            return RedirectToAction("Index", "Home");
        }

        //GET: Topic/Edit/5
        [Authorize]
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Index", "Home");
            }

            //get topic from db
            Topic topic = context.Topics
                .Include(t => t.Author)
                .Where(t => t.Id == id)
                .SingleOrDefault();

            //check if topic exists
            if (topic == null)
            {
                return RedirectToAction("Index", "Home");
            }

            //pass the model to view
            return View(topic);
        }

        //POST: Topic/Edit/id
        [HttpPost]
        [Authorize]
        public IActionResult Edit(Topic topic)
        {
            if (ModelState.IsValid)
            {
                //get the topic from the db
                Topic topicFromDb = context.Topics
                    .Include(t => t.Author)
                    .SingleOrDefault(t => t.Id.Equals(topic.Id));

                //check if topic exists
                if (topicFromDb == null)
                {
                    return RedirectToAction("Index", "Home");
                }

                //set new properties
                topicFromDb.Description = topic.Description;
                topicFromDb.Title = topic.Title;

                topicFromDb.LastUpdatedDate = DateTime.Now;

                //save changes
                context.SaveChanges();

                //redirect to index
                return RedirectToAction("Index", "Home");
            }

            //if model is invalid return the same  view
            return View(topic);
        }
    }
}