using MailKit.Net.Smtp;
using Microsoft.AspNetCore.Mvc;
using MimeKit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreBlogProject.Controllers
{
    public class NewsLetterController : Controller
    {
        public IActionResult SubscribeToNewsLetter(string email)
        {
            var message = new MimeMessage();
            message.From.Add(new MailboxAddress("Aysel Memedova", "xxmixx25@gmail.com"));
            message.To.Add(new MailboxAddress("User", email));
            message.Subject = "welcome to my website";
            message.Body = new TextPart("plain")
            {
                Text = "hello,dear"

            };
            using (SmtpClient client = new SmtpClient())
            {
                client.Connect("smtp.gmail.com", 587,false);
                client.Authenticate("xxmixx25@gmail.com", "vusalavtos");
                client.Send(message);
                client.Disconnect(true);
            }
            return RedirectToAction("Index","About");
        }
    }
}
