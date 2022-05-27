using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
   public class Comment
    {
      public  int CommentId { get; set; }
      public string CommentContent { get; set; }
        
      public int UserId { get; set; }
      public virtual User User { get; set; }
        public int? BlogId  { get; set; }
        public virtual Blog Blog { get; set; }
        
    }
}
