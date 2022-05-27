using BusinessLayer.Concrete;
using BusinessLayer.Dto;
using BusinessLayer.Utilities;
using DataAccessLayer.Repositories;
using EntityLayer.Concrete;
using MailKit.Net.Smtp;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MimeKit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreBlogProject.Controllers
{
    [AllowAnonymous]
    public class RegisterController : Controller
    {
        UserManager um = new UserManager(new UserRepository());
        

        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Register(RegisterDto registerDto)
        { 
            EntityLayer.Concrete.User user=new EntityLayer.Concrete.User
            
            {
                NickName=registerDto.NickName,
                UserName = registerDto.UserName,
                UserSurname=registerDto.UserSurname,
                UserMail=registerDto.UserMail,
                UserPassword=registerDto.UserPassword,
                UserStatus=false
            
            };
            um.Add(user);
            Random random = new Random();
            //number = random.Next(100000, 999999);
            var message = new MimeKit.MimeMessage();
            message.From.Add(new MailboxAddress("Aysel Memedova", "xxmixx25@gmail.com"));
            message.To.Add(new MailboxAddress("User", registerDto.UserMail));
            message.Subject = "welcome to my website";
            message.Body = new TextPart("html")
            {
                //Text = $"<h2>hello,dear</h2><br> <a>localhost:44354/Register/ActivateUser/{number}?email={registerDto.UserMail} </a>"

            };
            using (SmtpClient client = new SmtpClient())
            {
                client.Connect("smtp.gmail.com", 587, false);
                client.Authenticate("xxmixx25@gmail.com", "vusalavtos");
                client.Send(message);
                client.Disconnect(true);
            }

            return RedirectToAction("Index","Login");
        }
       //public IActionResult ActivateUser(int id,string email)
       // {
       //     if (id == number)
       //     {
       //         int userId = FunctionHelper.GetUserIdByEmail(email);
       //         User user = um.GetById(userId);
       //         user.UserStatus = true;
       //         um.Update(user);
       //         ViewBag.status = "Succesfull";
       //     }
       //     else
       //     {
       //         ViewBag.status = "Error";
               
       //     }
       //     return View();

       // }

    }
}
