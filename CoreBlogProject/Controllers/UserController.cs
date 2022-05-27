using BusinessLayer.Concrete;
using BusinessLayer.Utilities;
using BusinessLayer.ViewModels;
using DataAccessLayer.Repositories;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreBlogProject.Controllers
{
    
    public class UserController : Controller
    {
        UserManager um = new UserManager(new UserRepository());
        public IActionResult EditProfile()
        {
           string email= User.Identity.Name;
            int id = FunctionHelper.GetUserIdByEmail(email);
            User user = um.GetById(id);
            EditProfileViewModel editprofile = new EditProfileViewModel()
            {
                NickName=user.NickName,
                UserImage=user.UserImage,
                UserMail=user.UserMail,
                UserName=user.UserName,
                UserSurname=user.UserSurname
                
            };
            return View(editprofile);
        }
        [HttpPost]
        public IActionResult EditProfile(EditProfileViewModel editUser)
        {
            string email = User.Identity.Name;
            int id = FunctionHelper.GetUserIdByEmail(email);
            User user = um.GetById(id);
            user.UserName = editUser.UserName;
            user.NickName = editUser.NickName;
            user.UserImage = editUser.UserImage;
            user.UserMail = editUser.UserMail;
            user.UserSurname = editUser.UserSurname;
           
            um.Update(user);
            return RedirectToAction("Index","Blog");
        }
    }
}
