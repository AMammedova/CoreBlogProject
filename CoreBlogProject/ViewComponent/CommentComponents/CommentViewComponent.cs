using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BusinessLayer.Concrete;
using DataAccessLayer.Repositories;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace CoreBlogProject.ViewComponents.CommentComponents
{
    public class CommentViewComponent:ViewComponent
    {
        public IViewComponentResult Invoke(int id)
        {
            CommentManager cm = new CommentManager(new CommentRepository());
            List<Comment> comments = cm.GetCommentsById(id);

            return View("Comment",comments);
        }

    }
}
