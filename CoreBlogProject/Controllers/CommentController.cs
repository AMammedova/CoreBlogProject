using BusinessLayer.Concrete;
using BusinessLayer.Utilities;
using BusinessLayer.ViewModels;
using DataAccessLayer.Repositories;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreBlogProject.Controllers
{
    public class CommentController : Controller
    {
        CommentManager cm = new CommentManager(new CommentRepository());

        public IActionResult Index()
        {
            List<Comment> data = cm.GetList();
            return View(data);
        }

        [HttpPost]
        public IActionResult CommentPost(CommentPostViewModel comment)
        {
            Comment Comment = new Comment()
            {
                UserId = FunctionHelper.GetUserIdByEmail(User.Identity.Name),
                CommentContent = comment.content,
                BlogId = comment.blogid
            };
            cm.Add(Comment);
            return Json(comment);
        }
    }
}
