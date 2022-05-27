using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class CommentManager : ICommentService
    {
        ICommentDal _commentDal;

        public CommentManager(ICommentDal commentDal)
        {
            _commentDal = commentDal;
        }

        public void Add(Comment obj)
        {
            _commentDal.Add(obj);
        }

        public void Delete(Comment obj)
        {
            _commentDal.Delete(obj.CommentId);
        }

        public Comment GetById(int id)
        {
            return _commentDal.GetById(id);
        }

        public List<Comment> GetList()
        {
            return _commentDal.GetList();
        }

        public void Update(Comment obj)
        {
            _commentDal.Update(obj);
        }
        public List<Comment> GetCommentsById(int id)
        {
            return _commentDal.GetCommentsWithUser(id);
        }
    }
}
