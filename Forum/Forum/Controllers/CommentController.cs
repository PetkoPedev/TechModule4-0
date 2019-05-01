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
    public class CommentController : Controller
    {
        private readonly ForumDbContext context;

        public CommentController(ForumDbContext context)
        {
            this.context = context;
        }

        //GET: /Topic/Details/{topicId}/Comment/Create
        [Authorize]
        [HttpGet]
        [Route("/Topic/Details/{id}/Comment/Create")]
        public IActionResult Create(int id)
        {
            return View();
        }

        //POST: /Topic/Details/5/Comment/Create
        [Authorize]
        [HttpPost]
        [Route("/Topic/Details/{TopicId}/Comment/Create")]
        public IActionResult Create(Comment comment)
        {
            if (ModelState.IsValid)
            {
                //set CreatedDate and LastUpdatedDate
                comment.CreatedDate = DateTime.Now;
                comment.LastUpdatedDate = DateTime.Now;

                //get userId from DB and set it to comment's authorId
                string authorId = context
                    .Users
                    .Where(u => u.UserName == User.Identity.Name)
                    .SingleOrDefault()
                    .Id;

                comment.AuthorId = authorId;

                //get the topic from DB and set LastUpdatedDate to Now
                Topic topic = context.Topics.Find(comment.TopicId);
                topic.LastUpdatedDate = DateTime.Now;

                //add comment to DB
                context.Comments.Add(comment);
                context.SaveChanges();
                return Redirect($"/Topic/Details/{comment.TopicId}");
            }

            return View(comment);
        }

        //GET: /Topic/Details/5/Comment/Edit/1
        [Route("/Topic/Details/{TopicId}/Comment/Edit/{id}")]
        public IActionResult Edit(int? topicId, int? id)
        {
            if (id == null)
            {
                return RedirectPermanent($"/Topic/Details/{topicId}");
            }

            Comment comment = context
                .Comments
                .Include(c => c.Author)
                .Include(c => c.Topic)
                .ThenInclude(t => t.Author)
                .SingleOrDefault(c => c.CommentId == id);

            if (comment == null)
            {
                return RedirectPermanent($"/Topic/Details/{topicId}");
            }

            return View(comment);
        }

        //POST: /Topic/Details/5/Comment/Edit/1
        [Authorize]
        [HttpPost]
        [Route("/Topic/Details/{TopicId}/Comment/Edit/{id}")]
        public IActionResult Edit(Comment comment)
        {
            if (ModelState.IsValid)
            {
                //get comment from DB and include author
                var commentFromDb = context
                    .Comments
                    .Include(c => c.Author)
                    .SingleOrDefault(c => c.CommentId.Equals(comment.CommentId));

                //if comment is null redirect to topic details
                if (commentFromDb == null)
                {
                    RedirectPermanent($"/Topic/Details/{comment.TopicId}");
                }

                //if comment is not null update properties and set LastUpdatedDate with current date
                commentFromDb.Description = comment.Description;
                commentFromDb.LastUpdatedDate = DateTime.Now;

                Topic topic = context.Topics.Find(comment.TopicId);
                topic.LastUpdatedDate = DateTime.Now;

                //save changes
                context.SaveChanges();

                //redirect to topic details
                return RedirectPermanent($"/Topic/Details/{comment.TopicId}");
            }

            return View(comment);
        }

        //GET: /Topic/Details/5/Comment/Delete/1
        [Route("/Topic/Details/{TopicId}/Comment/Delete/{id}")]
        public IActionResult Delete(int topicId, int? id)
        {
            if (id == null)
            {
                return RedirectPermanent($"/Topic/Details/{topicId}");
            }

            var comment = context
                .Comments
                .Include(c => c.Author)
                .Include(c => c.Topic)
                .ThenInclude(t => t.Author)
                .SingleOrDefault(c => c.CommentId == id);

            if (comment == null)
            {
                return RedirectPermanent($"/Topic/Details/{topicId}");
            }

            return View(comment);
        }

        //POST: /Topic/Details/5/Comment/Delete/1
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Route("/Topic/Details/{TopicId}/Comment/Delete/{id}")]
        public IActionResult Delete(int id)
        {
            //get comment from DB
            var comment = context
                .Comments
                .Find(id);

            //check if comment is not null
            if (comment != null)
            {
                //get topic from DB and update LastUpdatedDate
                Topic topic = context.Topics.Find(comment.TopicId);
                topic.LastUpdatedDate = DateTime.Now;

                //remove comment and save changes
                context.Comments.Remove(comment);
                context.SaveChanges();
            }

            //redirect to topic details
            return RedirectPermanent($"/Topic/Details/{comment.TopicId}");
        }



        public IActionResult Index()
        {
            return View();
        }
    }
}