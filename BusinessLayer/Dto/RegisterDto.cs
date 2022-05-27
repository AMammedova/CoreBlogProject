using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Dto
{
 public class RegisterDto
    {
        public int UserId { get; set; }
        public string NickName { get; set; }
        public string UserName { get; set; }
        public string UserSurname { get; set; }
        public string UserMail { get; set; }
        public string UserPassword { get; set; }
        public string UserPassword1 { get; set; }
    }
}
